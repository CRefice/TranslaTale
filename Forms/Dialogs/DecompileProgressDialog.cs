using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using TranslaTale.IO;
using TranslaTale.Projects;

namespace TranslaTale
{
    class DecompileProgressDialog : LoadingDialog
    {
        private Project DummyProject;

        public DecompileProgressDialog(string loadMessage, Project decompileProject) : base(loadMessage)
        {
            DummyProject = decompileProject;
            StartAsync();
        }

        protected override void LoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string TempFolder = Directory.CreateDirectory(Path.GetTempPath() + "\\TranslaTale").FullName;
            string TempDataPath = Directory.CreateDirectory(TempFolder + "\\DATAWIN").FullName;

            string ProjectPath = DummyProject.Path;
            string DataFilePath = DummyProject.BaseGamePath + "\\data.win";
            string ImagePath = Directory.CreateDirectory(ProjectPath + "\\Images").FullName;

            try
            {
                LoadWorker.ReportProgress(0, "Extracting data.win...");
                DataWin.Extract(DataFilePath, TempDataPath);

                //Copy text files to the project folder.
                LoadWorker.ReportProgress(50, "Copying text files...");
                File.Copy(TempDataPath + "\\STRG.txt", ProjectPath + "\\Clean Strings.txt");
                File.Copy(TempDataPath + "\\translate.txt", ProjectPath + "\\Translated Strings.txt");
                DummyProject.CleanFilePath = ProjectPath + "\\Clean Strings.txt";
                DummyProject.TransFilePath = ProjectPath + "\\Translated Strings.txt";

                //Copy image files too.
                LoadWorker.ReportProgress(70, "Copying image files...");
                foreach (var ImageFile in Directory.GetFiles(Path.Combine(TempDataPath, "TXTR"), "*.png"))
                {
                    File.Copy(ImageFile, Path.Combine(ImagePath, Path.GetFileName(ImageFile)), true);
                }
                DummyProject.ImageFilesPath = ImagePath;

                LoadWorker.ReportProgress(90, "Writing project file...");
                DummyProject.Write(ProjectPath + "\\" + DummyProject.Name + ".ttp");
                Project.CurrentProject = DummyProject;

                LoadWorker.ReportProgress(100, "Done!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TranslaTale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Directory.Delete(TempFolder, true);
                LoadWorker.CancelAsync();
            }
        }
        protected override void LoadWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.Open(DummyProject);
            mainForm.ShowDialog();
            base.LoadWorker_Completed(sender, e);
        }
    }
}
