namespace CHUANLING
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUseName = new DSkin.Controls.DSkinTextBox();
            this.txtPasswd = new DSkin.Controls.DSkinTextBox();
            this.btnLogin = new DSkin.Controls.DSkinButton();
            this.btnQuit = new DSkin.Controls.DSkinButton();
            this.dSkinPictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinPictureBox2 = new DSkin.Controls.DSkinPictureBox();
            this.SuspendLayout();
            // 
            // txtUseName
            // 
            this.txtUseName.BitmapCache = false;
            this.txtUseName.BorderColor = System.Drawing.Color.Transparent;
            this.txtUseName.Borders.AllWidth = 0;
            this.txtUseName.Borders.BottomWidth = 0;
            this.txtUseName.Borders.LeftWidth = 0;
            this.txtUseName.Borders.RightWidth = 0;
            this.txtUseName.Borders.TopWidth = 0;
            this.txtUseName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUseName.Location = new System.Drawing.Point(138, 227);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(236, 35);
            this.txtUseName.TabIndex = 0;
            this.txtUseName.TransparencyKey = System.Drawing.Color.Empty;
            this.txtUseName.WaterFont = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUseName.WaterText = "请输入用户名";
            this.txtUseName.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.txtUseName.WaterTextTextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BitmapCache = false;
            this.txtPasswd.BorderColor = System.Drawing.Color.Transparent;
            this.txtPasswd.Borders.AllWidth = 0;
            this.txtPasswd.Borders.BottomWidth = 0;
            this.txtPasswd.Borders.LeftWidth = 0;
            this.txtPasswd.Borders.RightWidth = 0;
            this.txtPasswd.Borders.TopWidth = 0;
            this.txtPasswd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswd.Location = new System.Drawing.Point(138, 302);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(236, 35);
            this.txtPasswd.TabIndex = 0;
            this.txtPasswd.TransparencyKey = System.Drawing.Color.Empty;
            this.txtPasswd.WaterFont = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswd.WaterText = "请输入密码";
            this.txtPasswd.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.txtPasswd.WaterTextTextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // btnLogin
            // 
            this.btnLogin.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogin.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.ButtonBorderWidth = 1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.HoverColor = System.Drawing.Color.Empty;
            this.btnLogin.HoverImage = null;
            this.btnLogin.Location = new System.Drawing.Point(412, 291);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalImage = global::CHUANLING.Properties.Resources.hicetea_p0_2;
            this.btnLogin.PressColor = System.Drawing.Color.Empty;
            this.btnLogin.PressedImage = null;
            this.btnLogin.Radius = 10;
            this.btnLogin.ShowButtonBorder = true;
            this.btnLogin.Size = new System.Drawing.Size(108, 45);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextPadding = 0;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BaseColor = System.Drawing.Color.Transparent;
            this.btnQuit.ButtonBorderColor = System.Drawing.Color.Transparent;
            this.btnQuit.ButtonBorderWidth = 1;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuit.HoverColor = System.Drawing.Color.Empty;
            this.btnQuit.HoverImage = null;
            this.btnQuit.Location = new System.Drawing.Point(546, 291);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.NormalImage = global::CHUANLING.Properties.Resources.hicetea_p0_1;
            this.btnQuit.PressColor = System.Drawing.Color.Empty;
            this.btnQuit.PressedImage = null;
            this.btnQuit.Radius = 10;
            this.btnQuit.ShowButtonBorder = true;
            this.btnQuit.Size = new System.Drawing.Size(108, 45);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuit.TextPadding = 0;
            // 
            // dSkinPictureBox1
            // 
            this.dSkinPictureBox1.Image = global::CHUANLING.Properties.Resources.hicetea_p0_6;
            this.dSkinPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::CHUANLING.Properties.Resources.hicetea_p0_6))};
            this.dSkinPictureBox1.Location = new System.Drawing.Point(74, 218);
            this.dSkinPictureBox1.Name = "dSkinPictureBox1";
            this.dSkinPictureBox1.Size = new System.Drawing.Size(52, 52);
            this.dSkinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dSkinPictureBox1.SudokuDrawBackImage = true;
            this.dSkinPictureBox1.TabIndex = 2;
            // 
            // dSkinPictureBox2
            // 
            this.dSkinPictureBox2.Image = global::CHUANLING.Properties.Resources.hicetea_p0_3;
            this.dSkinPictureBox2.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::CHUANLING.Properties.Resources.hicetea_p0_3))};
            this.dSkinPictureBox2.Location = new System.Drawing.Point(74, 293);
            this.dSkinPictureBox2.Name = "dSkinPictureBox2";
            this.dSkinPictureBox2.Size = new System.Drawing.Size(52, 52);
            this.dSkinPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dSkinPictureBox2.SudokuDrawBackImage = true;
            this.dSkinPictureBox2.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CHUANLING.Properties.Resources.hicetea_p0_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dSkinPictureBox2);
            this.Controls.Add(this.dSkinPictureBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUseName);
            this.Name = "FrmLogin";
            this.ShowSystemButtons = false;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinTextBox txtUseName;
        private DSkin.Controls.DSkinTextBox txtPasswd;
        private DSkin.Controls.DSkinButton btnLogin;
        private DSkin.Controls.DSkinButton btnQuit;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox1;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox2;
    }
}

