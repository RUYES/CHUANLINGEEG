using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHUANLING
{
    public partial class FrmMenu : DSkin.Forms.DSkinForm
    {
        public FrmMenu(Models.User user)
        {
            InitializeComponent();

            System.Threading.Thread.Sleep(100);
            //auth = (Auth)user.Authority;
            Splasher.Status = "欢迎您," + user.UserName;
            System.Threading.Thread.Sleep(1000);
            Splasher.Status = "初始化.....";
            System.Threading.Thread.Sleep(800);
            Splasher.Status = "加载配置文件";
            //LoadConfig();
            // System.Threading.Thread.Sleep(800);
            // Splasher.Status = "分配用户权限";
            //AssignPermissions();
            System.Threading.Thread.Sleep(800);
            Splasher.Status = "初始化完毕";
            System.Threading.Thread.Sleep(200);
            this.lblUsername.Text = "欢迎您，" + user.UserName;
            //this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
            //this.WindowState = FormWindowState.Maximized;    //最大化窗体 
            Splasher.Close();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DSkin.Forms.DSkinMessageBox.Show("确定要退出本系统吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }
    }
}
