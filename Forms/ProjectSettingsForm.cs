using System;
using System.Windows.Forms;

using TranslaTale.Projects;

namespace TranslaTale
{
    public partial class ProjectSettingsForm : Form
    {
        private MainForm ParentMainForm;

        public ProjectSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            ParentMainForm = mainForm;
        }

        private void ProjectSettingsForm_Load(object sender, EventArgs e)
        {
            var project = Project.CurrentProject;
            NameTextBox.Text = project.Name;
            BaseFileTextBox.Text = project.CleanFilePath;
            TransFileTextBox.Text = project.TransFilePath;
            ImagePathTextBox.Text = project.ImageFilesPath;
            CleanGameTextBox.Text = project.BaseGamePath;
            CompileGameTextBox.Text = project.CompilePath;
        }

        private void BaseFileButton_Click(object sender, EventArgs e)
        {
            BrowseFileDialog.Title = "Open a clean text file";
            if(BrowseFileDialog.ShowDialog() == DialogResult.OK)
                BaseFileTextBox.Text = BrowseFileDialog.FileName;
        }
        private void TransFileButton_Click(object sender, EventArgs e)
        {
            BrowseFileDialog.Title = "Open your translation file";
            if (BrowseFileDialog.ShowDialog() == DialogResult.OK)
                TransFileTextBox.Text = BrowseFileDialog.FileName;
        }
        private void ImagePathButton_Click(object sender, EventArgs e)
        {
            BrowsePathDialog.Description = "Select your image file path";
            if (BrowsePathDialog.ShowDialog() == DialogResult.OK)
                ImagePathTextBox.Text = BrowsePathDialog.SelectedPath;
        }
        private void CleanGameButton_Click(object sender, EventArgs e)
        {
            BrowsePathDialog.Description = "Select an Undertale game folder";
            if (BrowsePathDialog.ShowDialog() == DialogResult.OK)
                CleanGameTextBox.Text = BrowsePathDialog.SelectedPath;
        }
        private void CompileGameButton_Click(object sender, EventArgs e)
        {
            BrowsePathDialog.Description = "Select a folder for compilation";
            if (BrowsePathDialog.ShowDialog() == DialogResult.OK)
                CompileGameTextBox.Text = BrowsePathDialog.SelectedPath;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var project = new Project(NameTextBox.Text, BaseFileTextBox.Text, TransFileTextBox.Text)
            {
                ImageFilesPath = ImagePathTextBox.Text,
                BaseGamePath = CleanGameTextBox.Text,
                CompilePath = CompileGameTextBox.Text
            };
            project.Write(Project.CurrentProject.Path);
            Project.CurrentProject = project;

            switch (MessageBox.Show("Would you like to reload the current project?", "TranslaTale",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Hide();
                    ParentMainForm.Open(project);
                    Close();
                    return;

                case DialogResult.No:
                    Close();
                    return;

                case DialogResult.Cancel:
                    return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
