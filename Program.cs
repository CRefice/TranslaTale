using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TranslaTale.Projects;
using TranslaTale.Settings;

namespace TranslaTale
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Count() > 0 &&
                File.Exists(args[0]) &&
                Path.GetExtension(args[0]) == ".ttp")
            {
                var mainForm = new MainForm();
                mainForm.Open(Project.Read(args[0]));
                mainForm.Show();
            }
            else
            {
                new StartUpForm().Show();
            }

            Application.Run();
        }
    }
}
