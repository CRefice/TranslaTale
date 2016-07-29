using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using TranslaTale.Renderers;
using TranslaTale.Text;
using TranslaTale.Projects;
using TranslaTale.Settings;
using TranslaTale.Bookmarks;

namespace TranslaTale
{
    public partial class MainForm : Form
    {
        private string FileSavePath;
        private bool DirtyFlag = false;
        private int EditedLines = 0;

        public MainForm()
        {
            InitializeComponent();

            FontComboBox.SelectedIndex = 0;
            KeyPreview = true;

            MainMenuItemStrip.Renderer = new TTSystemRenderer();
            MainToolStrip.Renderer = new TTSystemRenderer();
            MainStatusStrip.Renderer = new TTSystemRenderer();

            MainSpriteFontBox.FontPath = Application.StartupPath + "\\Resources\\Fonts.png";
        }

        public void LoadItems(SearchMode selectionMode = SearchMode.Both)
        {
            MainListView.Items.Clear();

            MainListView.Enabled = false;
            MainToolStrip.Enabled = false;
            MainMenuItemStrip.Enabled = false;

            int LineNum = Lines.Count;

            MainListView.BeginUpdate();
            switch (selectionMode)
            {
                case SearchMode.Base:
                    {
                        var linesToAdd = from line in Lines.LineArray
                                         where !line.IsEdited()
                                         select line;
                        foreach (var line in linesToAdd)
                        {
                            MainListView.Items.Add(line.ToListViewItem(true));
                        }
                        EditedLines = LineNum - linesToAdd.Count();
                    }
                    break;

                case SearchMode.Translation:
                    {
                        var linesToAdd = from line in Lines.LineArray
                                                   where line.IsEdited()
                                                   select line;
                        foreach (var line in linesToAdd)
                        {
                            MainListView.Items.Add(line.ToListViewItem(true));
                        }
                        EditedLines = linesToAdd.Count();
                    }
                    break;

                case SearchMode.Both:
                    foreach (var line in Lines.LineArray)
                    {
                        MainListView.Items.Add(line.ToListViewItem(true));

                        if (line.IsEdited()) EditedLines++;
                    }
                    break;
            }
            MainListView.EndUpdate();

            MainListView.Enabled = true;
            MainToolStrip.Enabled = true;
            MainMenuItemStrip.Enabled = true;

            SelectItem(MiscSettings.LastVisitedLine);

            TotalStatusLabel.Text = LineNum.ToString();
            TranslatedStatusLabel.Text = EditedLines.ToString();
            UntranslatedStatusLabel.Text = (LineNum - EditedLines).ToString();
        }
        private void UpdateEditedCount()
        {
            var editedLines = from line in Lines.LineArray
                              where line.IsEdited()
                              select line;

            TranslatedStatusLabel.Text = editedLines.Count().ToString();
            UntranslatedStatusLabel.Text = (Lines.Count - editedLines.Count()).ToString();
        }
        public void PromptReload()
        {
            switch (MessageBox.Show("Would you like to reload the current project?", "TranslaTale",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Hide();
                    Open(Project.CurrentProject);
                    Show();
                    return;

                default:
                    return;
            }
        }

        public void Open(string cleanFile, string transFile)
        {
            try
            {
                Lines.Open(cleanFile, transFile);
                LoadItems();

                this.Text = "TranslaTale - " + Path.GetFileName(transFile);
                ProjectMenuItem.Enabled = false;
                CompileAndRunMenuItem.Enabled = false;

                FileSavePath = transFile;
                Project.CurrentProject = null;
                RecentFileSettings.SaveRecentBaseFile(cleanFile);
            }

            catch (Exception ex) when (ex is FileNotFoundException || ex is DifferentFileSizeException || ex is EmptyFileException)
            {
                MessageBox.Show(ex.Message, "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                MainListView.Enabled = true;
                MainToolStrip.Enabled = true;
                MainMenuItemStrip.Enabled = true;
            }
        }
        public void Open(Project project)
        {
            try
            {
                Lines.Open(project.CleanFilePath, project.TransFilePath);
                LoadItems();

                this.Text = "TranslaTale - " + project.Name;
                ProjectMenuItem.Enabled = true;

                Project.CurrentProject = project;
                RecentProjects.Add(project);
                FileSavePath = project.TransFilePath;
            }

            catch (Exception ex) when (ex is FileNotFoundException || ex is DifferentFileSizeException || ex is EmptyFileException)
            {
                MessageBox.Show(ex.Message, "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                MainListView.Enabled = true;
                MainToolStrip.Enabled = true;
                MainMenuItemStrip.Enabled = true;
            }
        }

        private void Save(string path)
        {
            try
            {
                Lines.Save(path);

                FileSavePath = path;
                DirtyFlag = false;
            }

            catch (Exception ex) when (ex is FileNotFoundException)
            {
                var Dialog = new SaveFileDialog()
                {
                    Title = "Save as...",
                    Filter = "Text files (*.txt)|(*.txt)"
                };

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    Save(Dialog.FileName);
                }
            }
        }

        public bool SelectItem(int index)
        {
            try
            {
                if (MainListView.Items[index].SubItems[0].Text == index.ToString())
                {
                    MainListView.Items[index].Selected = true;
                    MainListView.EnsureVisible(index);
                    MainListView.Focus();
                    return true;
                }

                return false;
            }

            catch
            {
                return false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DirtyFlag)
                return;

            switch (MessageBox.Show("There are unsaved changes!\n" +
                "Would you like to save your file?", "TranslaTale",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
            {
                case DialogResult.Yes:
                    Save(FileSavePath);
                    return;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    return;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                string SelectedString = MainListView.SelectedItems[0].SubItems[2].Text;

                MainTextBox.Text = SelectedString;
                MainSpriteFontBox.Text = SelectedString;
                AddBookmarkMenuItem.Enabled = true;

                MiscSettings.LastVisitedLine = MainListView.SelectedIndices[0];
            }
            else
            {
                MainTextBox.Text = "";
                MainSpriteFontBox.Text = "";
                AddBookmarkMenuItem.Enabled = false;
            }
        }
        private void MainListView_SizeChanged(object sender, EventArgs e)
        {
            int ColumnWidth = (MainListView.Width - MainListView.Columns[0].Width - 25) / 2;
            MainListView.Columns[1].Width = ColumnWidth;
            MainListView.Columns[2].Width = ColumnWidth;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                var SelectedItem = MainListView.SelectedItems[0];

                var SelectedLine = Lines.Get(Int32.Parse(SelectedItem.SubItems[0].Text));
                string TransLine = MainTextBox.Text;

                SelectedLine.TranslatedString = TransLine;
                MainSpriteFontBox.Text = TransLine;
                SelectedItem.SubItems[2].Text = TransLine;

                SelectedItem.BackColor = SelectedLine.IsEdited() ? Color.LightGreen : Color.LightSalmon;

                UpdateEditedCount();

            }
        }
        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var SelectedIndex = MainListView.SelectedIndices[0];
                MainListView.Items[SelectedIndex].Selected = false;
                MainListView.Items[++SelectedIndex].Selected = true;
                MainListView.EnsureVisible(SelectedIndex);
                MainTextBox.Focus();
                return;
            }
            if (!DirtyFlag)
            {
                DirtyFlag = true;
                this.Text += " *";
            }
        }

        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog()
            {
                Title = "Open a project file or a translation file",
                Filter = "TranslaTale Project files (*.ttp)|*.ttp|Text files (*.txt)|*.txt"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(Dialog.FileName))
                {
                    case ".ttp":    //Project File
                        var OpenedProject = Project.Read(Dialog.FileName);
                        Open(OpenedProject);
                        break;

                    case ".txt":    //Text File
                        string BaseTextFilePath = RecentFileSettings.GetRecentBaseFile();
                        if (!File.Exists(BaseTextFilePath))
                        {
                            var TextFileDialog = new OpenFileDialog()
                            {
                                Title = "Open a clean text file",
                                Filter = "Text files (*.txt)|*.txt"
                            };

                            if (TextFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                BaseTextFilePath = TextFileDialog.FileName;
                            }
                            else return;
                        }

                        Open(BaseTextFilePath, Dialog.FileName);
                        break;
                }
            }
        }
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenMenuItem.PerformClick();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyFlag) return;

            if (Project.CurrentProject != null)
            {
                Save(Project.CurrentProject.TransFilePath);
                this.Text = "TranslaTale - " + Project.CurrentProject.Name;
            }
            else
            {
                Save(FileSavePath);
                this.Text = "TranslaTale - " + Path.GetFileName(FileSavePath);
            }
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveMenuItem.PerformClick();
        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {
            new SearchForm(this).Show();
        }
        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
            SearchMenuItem.PerformClick();
        }

        private void CompileMenuItem_Click(object sender, EventArgs e)
        {
            Save(FileSavePath);
            new CompileProgressDialog("Compiling...", false).Show(this);
        }
        private void CompileAndRunMenuItem_Click(object sender, EventArgs e)
        {
            Save(FileSavePath);
            new CompileProgressDialog("Compiling...", true).Show(this);
        }
        private void CompileToolStripButton_Click(object sender, EventArgs e)
        {
            CompileAndRunMenuItem.PerformClick();
        }

        private void ProjectSettingsMenuItem_Click(object sender, EventArgs e)
        {
            new ProjectSettingsForm(this).Show(this);
        }

        private void AddBookmarkMenuItem_Click(object sender, EventArgs e)
        {
            if (Bookmark.GetList().Any(x => x.Line == MainListView.SelectedIndices[0]))
            {
                MessageBox.Show("There is a bookmark for that line already!", "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            new AddBookmarkDialog(MainListView.SelectedIndices[0]).ShowDialog();
        }
        private void ListBookmarksMenuItem_Click(object sender, EventArgs e)
        {
            new BookmarksForm(this).ShowDialog();
        }

        private void GoToMenuItem_Click(object sender, EventArgs e)
        {
            new GoToLineDialog(this).ShowDialog();
        }
        private void GoToToolStripButton_Click(object sender, EventArgs e)
        {
            GoToMenuItem.PerformClick();
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FontComboBox.SelectedIndex)
            {
                case 0:
                    MainSpriteFontBox.CurrentSpriteFont = UTSpriteFontBox.SpriteFontBox.SpriteFonts.BitOperator;
                    return;
                case 1:
                    MainSpriteFontBox.CurrentSpriteFont = UTSpriteFontBox.SpriteFontBox.SpriteFonts.ComicSans;
                    return;
                case 2:
                    MainSpriteFontBox.CurrentSpriteFont = UTSpriteFontBox.SpriteFontBox.SpriteFonts.Papyrus;
                    return;
            }
        }

        private void NoFaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoFaceRadioButton.Checked)
                MainSpriteFontBox.ShowFaces = false;
            else
                MainSpriteFontBox.ShowFaces = true;
        }

        private void TranslatedStatusLabel_Click(object sender, EventArgs e)
        {
            LoadItems(SearchMode.Translation);
        }
        private void UntranslatedStatusLabel_Click(object sender, EventArgs e)
        {
            LoadItems(SearchMode.Base);
        }
        private void TotalStatusLabel_Click(object sender, EventArgs e)
        {
            LoadItems(SearchMode.Both);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show(this);
        }

        private void MergeFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FileMergeForm(this).Show();
        }
    }
}
