using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CHUANLING
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new FormMain());
            //Application.Run(new frmData(new Models.Train() { TableName = "Admin_2019_07_12_09_15_30" }));
            //FrmLogin dlg = new FrmLogin();
            //dlg.StartPosition = FormStartPosition.CenterScreen;

            //if (DialogResult.OK == dlg.ShowDialog())
            //{
            //    Splasher.Show(typeof(FrmLoad));

            //    Application.ThreadException += Application_ThreadException;

            //    Application.Run(new FrmMenu(dlg.loginUser));
            //}

            FrmLogin dlga = new FrmLogin();
            dlga.StartPosition = FormStartPosition.CenterScreen;

            if (DialogResult.OK == dlga.ShowDialog())
            {
                Splasher.Show(typeof(FrmLoad));

                Application.ThreadException += Application_ThreadException;

                Application.Run(new FormMain(dlga.loginUser));
            }


        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // throw new NotImplementedException();
        }
    }
}
