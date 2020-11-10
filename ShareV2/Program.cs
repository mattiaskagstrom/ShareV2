using System;
using System.Windows.Forms;

namespace ShareV2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using var form = new SettingsForm();
            Application.Run(form);
        }
    }
}
