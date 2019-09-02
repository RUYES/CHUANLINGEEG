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
            FrmLogin dlg = new FrmLogin();
            dlg.StartPosition = FormStartPosition.CenterScreen;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                Splasher.Show(typeof(FrmLoad));

                Application.ThreadException += Application_ThreadException;

                Application.Run(new FrmMenu(dlg.loginUser));
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
