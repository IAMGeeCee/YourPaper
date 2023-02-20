using System;
using System.IO;
using System.Windows.Forms;
using YourPaper_Desktop.Properties;

namespace YourPaper_Desktop
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

            if (Settings.Default.IsFirstUse)
            {
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new Splash());
            }
        }
    }
}
