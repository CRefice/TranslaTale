using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using TranslaTale.IO;
using TranslaTale.Projects;

namespace TranslaTale
{
    class CompileProgressDialog : LoadingDialog
    {
        private bool ShouldRun;

        public CompileProgressDialog(string loadMessage, bool shouldRun) : base(loadMessage)
        {
            ShouldRun = shouldRun;
            StartAsync();
        }

        protected override void LoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var project = Project.CurrentProject;

            string TempFolder = Directory.CreateDirectory(Path.GetTempPath() + "\\TranslaTale").FullName;

            string DataFilePath = Path.Combine(project.BaseGamePath, "data.win");
            string UTFontsPath = Path.Combine(Application.StartupPath, "Resources\\UTFonts.win");

            string TempDataPath = Path.Combine(TempFolder, "DATAWIN");
            string TempFontsPath = Path.Combine(TempFolder, "UTFONTS");

            try
            {
                LoadWorker.ReportProgress(0, "Extracting fonts...");
                DataWin.Extract(UTFontsPath, TempFontsPath);

                LoadWorker.ReportProgress(20, "Extracting data.win...");
                DataWin.Extract(DataFilePath, TempDataPath);

                //Replace font files in the extracted Data.win folder.
                LoadWorker.ReportProgress(40, "Replacing extracted files...");
                foreach (var FontFile in Directory.GetFiles(Path.Combine(TempFontsPath, "FONT")))
                {
                    if (Path.GetFileName(FontFile) != "fonts.txt")
                        File.Copy(FontFile, Path.Combine(TempDataPath, "FONT_new", Path.GetFileName(FontFile)));
                }

                //Record file changes to a patch file.
                LoadWorker.ReportProgress(45, "Writing patch file...");
                using (StreamWriter Patch = new StreamWriter(TempDataPath + "\\FONT_new\\patch.txt"))
                {
                    Patch.WriteLine("1;UT_8bitLarge.font.gmx");
                    Patch.WriteLine("2;UT_8bit.font.gmx");
                    Patch.WriteLine("3;UT_CryptOfTomorrow.font.gmx");
                    Patch.WriteLine("4;UT_DotumCheSmall.font.gmx");
                    Patch.WriteLine("5;UT_DotumChe.font.gmx");
                    Patch.WriteLine("6;UT_Hachicro.font.gmx");
                    Patch.WriteLine("7;UT_MarsNeedsCunninlingus.font.gmx");
                    Patch.WriteLine("8;UT_sans.font.gmx");
                    Patch.WriteLine("9;UT_Papyrus.font.gmx");
                }

                //Replace image files too.
                LoadWorker.ReportProgress(50, "Replacing additional files...");
                foreach (var ImageFile in Directory.GetFiles(project.ImageFilesPath, "*.png"))
                {
                    File.Copy(ImageFile, Path.Combine(TempDataPath, "TXTR", Path.GetFileName(ImageFile)), true);
                }
                //And the translation text file.
                File.Copy(project.TransFilePath, TempDataPath + "\\translate.txt", true);

                LoadWorker.ReportProgress(60, "Repacking data.win...");
                DataWin.Repack(TempDataPath, Path.Combine(TempFolder, "data.win"));

                //Re-copy the files to the output folder.
                LoadWorker.ReportProgress(90, "Copying additional files...");
                File.Copy(Path.Combine(TempFolder, "data.win"), Path.Combine(project.CompilePath, "data.win"), true);
                foreach (var file in Directory.GetFiles(project.BaseGamePath))
                {
                    if (!File.Exists(Path.Combine(project.CompilePath, Path.GetFileName(file))))
                        File.Copy(file, Path.Combine(project.CompilePath, Path.GetFileName(file)), true);
                }

                LoadWorker.ReportProgress(100, "Done!");

                if (ShouldRun)
                    Process.Start(Path.Combine(project.CompilePath, "UNDERTALE.exe"));
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
    }
}
