using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
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
            //Application.Run(new MainForm());
            //Application.Run(new LoginForm());
            //Application.Run(new HRMainForm());
            Start();
             }   
            public static void Start()
            {
                LoginForm loginForm = new LoginForm();
                LoadingForm loadingForm = new LoadingForm();
                HRLoadingForm LoadingHRForm = new HRLoadingForm();
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.OK && loginForm.radioHRButton.Checked)
                {
                    loginForm.Close();
                    Application.Run(new HRLoadingForm());
                }
                else if (loginForm.DialogResult == DialogResult.OK && loginForm.radioStudentButton.Checked)
                {
                    loginForm.Close();
                    Application.Run(new LoadingForm());
                }
                else
                {
                    Application.Exit();
                }
            }
        
    }
}
