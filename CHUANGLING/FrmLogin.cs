using CHUANLING.Services;
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
    public partial class FrmLogin : DSkin.Forms.DSkinForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public Models.User loginUser = new Models.User("N/A", "N/A");
        private void TryLoggin()
        {
            //string strNotify = "登录成功！";
            //User user = DBOpreate.GetUser(this.txtUserName.Text.Trim(), this.txtPasswd.Text.Trim(), ref strNotify);
            //if (user.UserName != "N/A")
            //{
            //    loginUser = user;
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    DSkin.Forms.DSkinMessageBox.Show(strNotify);
            //}

            if (txtUseName.Text.Trim() == "")
            { DSkin.Forms.DSkinMessageBox.Show("请输入正确的用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            Models.User user = DBServices.UserLogin(txtUseName.Text, txtPasswd.Text);
            if (user.UserName == "N/A")
            { DSkin.Forms.DSkinMessageBox.Show("用户名或者密码错误！请检查", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            loginUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryLoggin();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
