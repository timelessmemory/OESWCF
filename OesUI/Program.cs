using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OesUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new FormExamList());

            //Application.Run(new TestForm());

            //Application.Run(new FormResultDetails());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FormExamList());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
