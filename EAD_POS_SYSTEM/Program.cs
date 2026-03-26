using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAD_POS_SYSTEM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Create the Login Form first
            LOGIN login = new LOGIN();

            // 2. Show it. If the result is "OK" (from our button click), then run the Main Form
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MdiParent()); // This opens your dashboard
            }
            else
            {
                Application.Exit(); // If they close the login, close the app
            }
        }
    }
}
