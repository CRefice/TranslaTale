using System;
using System.Windows.Forms;

using TranslaTale.Projects;

namespace TranslaTale
{
    public partial class NewProjectWizard : Form
    {
        private enum Panel { Welcome, Decompile, ExistingFiles }
        private Panel CurrentPanel;

        public NewProjectWizard()
        {
            InitializeComponent();
            CurrentPanel = Panel.Welcome;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch (CurrentPanel)
            {
                case Panel.Welcome:
                    if (DecompileButton.Checked)
                    {
                        WelcomePanel.Visible = false;
                        DecompilePanel.Visible = true;
                        NextButton.Text = "Start";
                        CurrentPanel = Panel.Decompile;
                    }
                    else if (UseExistingFilesButton.Checked)
                    {
                        WelcomePanel.Visible = false;
                        ExistingFilesPanel.Visible = true;
                        NextButton.Text = "Save as...";
                        CurrentPanel = Panel.ExistingFiles;
                    }
                    break;

                case Panel.Decompile:
                        var Project = new Project(NameTextBox.Text)
                        {
                            Name = NameTextBox.Text,
                            Path = ProjectPathTextBox.Text,
                            BaseGamePath = GamePathTextBox.Text,
                            CompilePath = CompilePathTextBox.Text
                        };
                        new DecompileProgressDialog("Decompiling...", Project).ShowDialog(this);
                        Hide();
                    break;

                case Panel.ExistingFiles:
                    var Dialog = new SaveFileDialog()
                    {
                        Title = "Save project as...",
                        Filter = "TranslaTale Project files (*.ttp)|(*.ttp)"
                    };

                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        var ExistingProject = new Project(NameTextBox.Text)
                        {
                            Name = NameTextBox2.Text,
                            Path = Dialog.FileName,
                            CleanFilePath = CleanScriptTextBox.Text,
                            TransFilePath = TransTextBox.Text,
                            ImageFilesPath = TransTextBox.Text,
                            BaseGamePath = GameFolderTextBox.Text,
                            CompilePath = CompileTextBox.Text
                        };
                        Project.CurrentProject = ExistingProject;

                        Hide();
                        var mainForm = new MainForm();
                        mainForm.Open(ExistingProject);
                        mainForm.ShowDialog();
                    }
                    break;
            }
        }

        private void PathButton1_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select your Undertale game folder"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                GamePathTextBox.Text = Dialog.SelectedPath;
            }
        }
        private void PathButton2_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select a folder for your project files"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ProjectPathTextBox.Text = Dialog.SelectedPath;
            }
        }
        private void PathButton3_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select a compilation folder"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                CompilePathTextBox.Text = Dialog.SelectedPath;
            }
        }

        private void GameFolderButton_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select your Undertale game folder"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                GameFolderTextBox.Text = Dialog.SelectedPath;
            }
        }
        private void CleanScriptButton_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog()
            {
                Title = "Select a clean text file",
                Filter = "Text files (*.txt)|*.txt"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                CleanScriptTextBox.Text = Dialog.FileName;
            }
        }
        private void TransTextButton_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog()
            {
                Title = "Select a translated text file",
                Filter = "Text files (*.txt)|*.txt"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                TransTextBox.Text = Dialog.FileName;
            }
        }
        private void ImageButton_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select an Image file folder"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImageTextBox.Text = Dialog.SelectedPath;
            }
        }
        private void CompileButton_Click(object sender, EventArgs e)
        {
            var Dialog = new FolderBrowserDialog()
            {
                Description = "Select a compilation folder"
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                CompileTextBox.Text = Dialog.SelectedPath;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
