using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TranslaTale.IO
{
    static class DataWin
    {
        private static string ExtractExePath = Path.Combine(Application.StartupPath, "Resources\\WinExtract.exe");
        private static string PackExePath = Path.Combine(Application.StartupPath, "Resources\\WinPack.exe");

        private static ProcessStartInfo WinExtractInfo = new ProcessStartInfo(ExtractExePath);
        private static ProcessStartInfo WinPackInfo = new ProcessStartInfo(PackExePath);

        public static void Extract(string inputFile, string outputDirectory)
        {
            WinExtractInfo.Arguments = string.Format("\"{0}\" \"{1}\" -tt", inputFile, outputDirectory);
            WinExtractInfo.WindowStyle = ProcessWindowStyle.Hidden;
            WinExtractInfo.CreateNoWindow = true;
            using (Process process = Process.Start(WinExtractInfo))
            {
                process.WaitForExit();
            }
        }
        
        public static void Repack(string extractedDataPath, string outputFile)
        {
            WinPackInfo.Arguments = string.Format("\"{0}\" \"{1}\" -tt", extractedDataPath, outputFile);
            WinPackInfo.WindowStyle = ProcessWindowStyle.Hidden;
            WinPackInfo.CreateNoWindow = true;
            using (Process process = Process.Start(WinPackInfo))
            {
                process.WaitForExit();
            }
        }
    }
}
