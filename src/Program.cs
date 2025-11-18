using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAMCL
{
    internal static class Program
    {
        public static MainForm frm;
        public static string YAMCLFolder;

        private static void Init()
        {
            try
            {
                YAMCLFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "YAMCL");
                string instancesDirPath = Path.Combine(YAMCLFolder, "instances");

                if (!Directory.Exists(YAMCLFolder))
                    Directory.CreateDirectory(YAMCLFolder);

                if (!Directory.Exists(instancesDirPath))
                    Directory.CreateDirectory(instancesDirPath);

                ConfigManager.CreateDefaultConfig();
            }
            catch { }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm = new MainForm();
            Application.Run(frm);
        }
    }
}
