using System;
using System.IO;
using System.Windows.Forms;

using TranslaTale.Projects;
using TranslaTale.Settings;

namespace TranslaTale
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < RecentProjects.Count; ++i)
            {
                try
                {
                    ProjectListBox.Items.Add(RecentProjects.Get(i).Name);
                }
                catch
                {
                    RecentProjects.Remove(i);
                }
            }
        }
        private void StartUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            Hide();
            new NewProjectWizard().ShowDialog(this);
            Close();
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            var Dialog = new OpenFileDialog()
            {
                Title = "Open a Project file or a translation file",
                Filter = "TranslaTale Project files (*.ttp)|*.ttp|Text files (*.txt)|*.txt"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(Dialog.FileName))
                {
                    case ".ttp":    //Project File
                        var OpenedProject = Project.Read(Dialog.FileName);
                        mainForm.Open(OpenedProject);
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

                        mainForm.Open(BaseTextFilePath, Dialog.FileName);
                        break;
                }

                Hide();
                mainForm.ShowDialog();
                Close();
            }
        }

        private void ProjectListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ProjectListBox.SelectedIndices.Count > 0)
            {
                var project = RecentProjects.Get(ProjectListBox.SelectedIndex);

                MainForm mainForm = new MainForm();
                Hide();
                mainForm.Open(project);
                mainForm.ShowDialog();
                Close();
            }
        }
        private void ProjectListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Cancel || e.KeyCode == Keys.Delete)
            {
                Settings.RecentProjects.Remove(ProjectListBox.SelectedIndex);
                ProjectListBox.Items.Remove(ProjectListBox.SelectedItem);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (ProjectListBox.SelectedIndices.Count > 0)
                {
                    var project = RecentProjects.Get(ProjectListBox.SelectedIndex);

                    MainForm mainForm = new MainForm();
                    Hide();
                    mainForm.Open(project);
                    mainForm.ShowDialog();
                    Close();
                }
            }
        }
    }
}
