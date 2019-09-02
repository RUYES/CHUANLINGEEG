namespace CHUANLING
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn1 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn2 = new DSkin.Controls.DSkinGridListColumn();
            DSkin.Controls.DSkinGridListColumn dSkinGridListColumn3 = new DSkin.Controls.DSkinGridListColumn();
            this.chrtRecord = new LiveCharts.WinForms.CartesianChart();
            this.btnStartRecord = new DSkin.Controls.DSkinButton();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.dSkinTableLayoutPanel1 = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinTabPage2 = new DSkin.Controls.DSkinTabPage();
            this.btnAddUser = new DSkin.Controls.DSkinButton();
            this.btnDeleUser = new DSkin.Controls.DSkinButton();
            this.btnEditPasswd = new DSkin.Controls.DSkinButton();
            this.btnEditUser = new DSkin.Controls.DSkinButton();
            this.txtRemark = new DSkin.Controls.DSkinTextBox();
            this.txtEmail = new DSkin.Controls.DSkinTextBox();
            this.txtiPhone = new DSkin.Controls.DSkinTextBox();
            this.txtWechat = new DSkin.Controls.DSkinTextBox();
            this.txtQQ = new DSkin.Controls.DSkinTextBox();
            this.txtAdress = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel15 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel14 = new DSkin.Controls.DSkinLabel();
            this.txtContray = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel13 = new DSkin.Controls.DSkinLabel();
            this.txtCity = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel12 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel11 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel10 = new DSkin.Controls.DSkinLabel();
            this.txtProvide = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel9 = new DSkin.Controls.DSkinLabel();
            this.txtSex = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel8 = new DSkin.Controls.DSkinLabel();
            this.txtHeight = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel7 = new DSkin.Controls.DSkinLabel();
            this.txtAge = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel6 = new DSkin.Controls.DSkinLabel();
            this.txtPasswd = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel5 = new DSkin.Controls.DSkinLabel();
            this.txtiName = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.txtiUserName = new DSkin.Controls.DSkinTextBox();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.btnLoadUserList = new DSkin.Controls.DSkinButton();
            this.userList = new DSkin.Controls.DSkinGridList();
            this.dSkinTabControl1.SuspendLayout();
            this.dSkinTabPage1.SuspendLayout();
            this.dSkinTableLayoutPanel1.SuspendLayout();
            this.dSkinPanel1.SuspendLayout();
            this.dSkinTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtRecord
            // 
            this.chrtRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chrtRecord.Location = new System.Drawing.Point(3, 45);
            this.chrtRecord.Name = "chrtRecord";
            this.chrtRecord.Size = new System.Drawing.Size(487, 215);
            this.chrtRecord.TabIndex = 0;
            this.chrtRecord.Text = "cartesianChart1";
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.ButtonBorderWidth = 1;
            this.btnStartRecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStartRecord.HoverColor = System.Drawing.Color.Empty;
            this.btnStartRecord.HoverImage = null;
            this.btnStartRecord.Location = new System.Drawing.Point(499, 3);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.NormalImage = null;
            this.btnStartRecord.PressColor = System.Drawing.Color.Empty;
            this.btnStartRecord.PressedImage = null;
            this.btnStartRecord.Radius = 10;
            this.btnStartRecord.ShowButtonBorder = true;
            this.btnStartRecord.Size = new System.Drawing.Size(117, 56);
            this.btnStartRecord.TabIndex = 1;
            this.btnStartRecord.Text = "aa ";
            this.btnStartRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartRecord.TextPadding = 0;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // dSkinTabControl1
            // 
            this.dSkinTabControl1.BitmapCache = false;
            this.dSkinTabControl1.Controls.Add(this.dSkinTabPage1);
            this.dSkinTabControl1.Controls.Add(this.dSkinTabPage2);
            this.dSkinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
            this.dSkinTabControl1.ItemBackgroundImage = null;
            this.dSkinTabControl1.ItemBackgroundImageHover = null;
            this.dSkinTabControl1.ItemBackgroundImageSelected = null;
            this.dSkinTabControl1.Location = new System.Drawing.Point(4, 84);
            this.dSkinTabControl1.Name = "dSkinTabControl1";
            this.dSkinTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            this.dSkinTabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.dSkinTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.White};
            this.dSkinTabControl1.Size = new System.Drawing.Size(992, 602);
            this.dSkinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dSkinTabControl1.TabIndex = 2;
            this.dSkinTabControl1.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.dSkinTabControl1.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.dSkinTabControl1.UpdownBtnBackColor = System.Drawing.Color.White;
            this.dSkinTabControl1.UpdownBtnBorderColor = System.Drawing.Color.Black;
            // 
            // dSkinTabPage1
            // 
            this.dSkinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage1.Controls.Add(this.dSkinTableLayoutPanel1);
            this.dSkinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTabPage1.Location = new System.Drawing.Point(0, 22);
            this.dSkinTabPage1.Name = "dSkinTabPage1";
            this.dSkinTabPage1.Size = new System.Drawing.Size(992, 580);
            this.dSkinTabPage1.TabIndex = 0;
            this.dSkinTabPage1.TabItemImage = null;
            this.dSkinTabPage1.Text = "参数检测";
            this.dSkinTabPage1.Visible = false;
            // 
            // dSkinTableLayoutPanel1
            // 
            this.dSkinTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTableLayoutPanel1.BitmapCache = false;
            this.dSkinTableLayoutPanel1.ColumnCount = 2;
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.Controls.Add(this.dSkinPanel1, 0, 0);
            this.dSkinTableLayoutPanel1.Controls.Add(this.btnStartRecord, 1, 0);
            this.dSkinTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dSkinTableLayoutPanel1.Name = "dSkinTableLayoutPanel1";
            this.dSkinTableLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanel1.RightBottom")));
            this.dSkinTableLayoutPanel1.RowCount = 2;
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.Size = new System.Drawing.Size(992, 580);
            this.dSkinTableLayoutPanel1.TabIndex = 2;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.BackgroundImage = global::CHUANLING.Properties.Resources.hicetea_p0_32;
            this.dSkinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dSkinPanel1.Controls.Add(this.chrtRecord);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel1.Location = new System.Drawing.Point(3, 3);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(490, 284);
            this.dSkinPanel1.TabIndex = 0;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // dSkinTabPage2
            // 
            this.dSkinTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinTabPage2.Controls.Add(this.btnAddUser);
            this.dSkinTabPage2.Controls.Add(this.btnDeleUser);
            this.dSkinTabPage2.Controls.Add(this.btnEditPasswd);
            this.dSkinTabPage2.Controls.Add(this.btnEditUser);
            this.dSkinTabPage2.Controls.Add(this.txtRemark);
            this.dSkinTabPage2.Controls.Add(this.txtEmail);
            this.dSkinTabPage2.Controls.Add(this.txtiPhone);
            this.dSkinTabPage2.Controls.Add(this.txtWechat);
            this.dSkinTabPage2.Controls.Add(this.txtQQ);
            this.dSkinTabPage2.Controls.Add(this.txtAdress);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel15);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel14);
            this.dSkinTabPage2.Controls.Add(this.txtContray);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel13);
            this.dSkinTabPage2.Controls.Add(this.txtCity);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel12);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel11);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel10);
            this.dSkinTabPage2.Controls.Add(this.txtProvide);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel9);
            this.dSkinTabPage2.Controls.Add(this.txtSex);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel8);
            this.dSkinTabPage2.Controls.Add(this.txtHeight);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel7);
            this.dSkinTabPage2.Controls.Add(this.txtAge);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel6);
            this.dSkinTabPage2.Controls.Add(this.txtPasswd);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel5);
            this.dSkinTabPage2.Controls.Add(this.txtiName);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel4);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel3);
            this.dSkinTabPage2.Controls.Add(this.txtiUserName);
            this.dSkinTabPage2.Controls.Add(this.dSkinLabel1);
            this.dSkinTabPage2.Controls.Add(this.btnLoadUserList);
            this.dSkinTabPage2.Controls.Add(this.userList);
            this.dSkinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTabPage2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinTabPage2.Location = new System.Drawing.Point(0, 22);
            this.dSkinTabPage2.Name = "dSkinTabPage2";
            this.dSkinTabPage2.Size = new System.Drawing.Size(992, 580);
            this.dSkinTabPage2.TabIndex = 1;
            this.dSkinTabPage2.TabItemImage = null;
            this.dSkinTabPage2.Text = "用户管理";
            this.dSkinTabPage2.Visible = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.ButtonBorderWidth = 1;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.HoverColor = System.Drawing.Color.Empty;
            this.btnAddUser.HoverImage = null;
            this.btnAddUser.Location = new System.Drawing.Point(468, 70);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.NormalImage = null;
            this.btnAddUser.PressColor = System.Drawing.Color.Empty;
            this.btnAddUser.PressedImage = null;
            this.btnAddUser.Radius = 10;
            this.btnAddUser.ShowButtonBorder = true;
            this.btnAddUser.Size = new System.Drawing.Size(137, 61);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "增加用户";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.TextPadding = 0;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleUser
            // 
            this.btnDeleUser.ButtonBorderWidth = 1;
            this.btnDeleUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleUser.HoverColor = System.Drawing.Color.Empty;
            this.btnDeleUser.HoverImage = null;
            this.btnDeleUser.Location = new System.Drawing.Point(754, 70);
            this.btnDeleUser.Name = "btnDeleUser";
            this.btnDeleUser.NormalImage = null;
            this.btnDeleUser.PressColor = System.Drawing.Color.Empty;
            this.btnDeleUser.PressedImage = null;
            this.btnDeleUser.Radius = 10;
            this.btnDeleUser.ShowButtonBorder = true;
            this.btnDeleUser.Size = new System.Drawing.Size(137, 61);
            this.btnDeleUser.TabIndex = 6;
            this.btnDeleUser.Text = "删除用户";
            this.btnDeleUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleUser.TextPadding = 0;
            this.btnDeleUser.Click += new System.EventHandler(this.btnDeleUser_Click);
            // 
            // btnEditPasswd
            // 
            this.btnEditPasswd.ButtonBorderWidth = 1;
            this.btnEditPasswd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditPasswd.HoverColor = System.Drawing.Color.Empty;
            this.btnEditPasswd.HoverImage = null;
            this.btnEditPasswd.Location = new System.Drawing.Point(611, 3);
            this.btnEditPasswd.Name = "btnEditPasswd";
            this.btnEditPasswd.NormalImage = null;
            this.btnEditPasswd.PressColor = System.Drawing.Color.Empty;
            this.btnEditPasswd.PressedImage = null;
            this.btnEditPasswd.Radius = 10;
            this.btnEditPasswd.ShowButtonBorder = true;
            this.btnEditPasswd.Size = new System.Drawing.Size(137, 61);
            this.btnEditPasswd.TabIndex = 7;
            this.btnEditPasswd.Text = "修改密码";
            this.btnEditPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPasswd.TextPadding = 0;
            // 
            // btnEditUser
            // 
            this.btnEditUser.ButtonBorderWidth = 1;
            this.btnEditUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditUser.HoverColor = System.Drawing.Color.Empty;
            this.btnEditUser.HoverImage = null;
            this.btnEditUser.Location = new System.Drawing.Point(611, 70);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.NormalImage = null;
            this.btnEditUser.PressColor = System.Drawing.Color.Empty;
            this.btnEditUser.PressedImage = null;
            this.btnEditUser.Radius = 10;
            this.btnEditUser.ShowButtonBorder = true;
            this.btnEditUser.Size = new System.Drawing.Size(137, 61);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.Text = "修改用户";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditUser.TextPadding = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.BitmapCache = false;
            this.txtRemark.Location = new System.Drawing.Point(502, 459);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(460, 98);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.TransparencyKey = System.Drawing.Color.Empty;
            this.txtRemark.WaterFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.WaterText = "备注";
            this.txtRemark.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BitmapCache = false;
            this.txtEmail.Location = new System.Drawing.Point(554, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TransparencyKey = System.Drawing.Color.Empty;
            this.txtEmail.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.WaterText = "";
            this.txtEmail.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtiPhone
            // 
            this.txtiPhone.BitmapCache = false;
            this.txtiPhone.Location = new System.Drawing.Point(554, 215);
            this.txtiPhone.Name = "txtiPhone";
            this.txtiPhone.Size = new System.Drawing.Size(162, 33);
            this.txtiPhone.TabIndex = 3;
            this.txtiPhone.TransparencyKey = System.Drawing.Color.Empty;
            this.txtiPhone.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtiPhone.WaterText = "";
            this.txtiPhone.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtWechat
            // 
            this.txtWechat.BitmapCache = false;
            this.txtWechat.Location = new System.Drawing.Point(800, 420);
            this.txtWechat.Name = "txtWechat";
            this.txtWechat.Size = new System.Drawing.Size(162, 33);
            this.txtWechat.TabIndex = 3;
            this.txtWechat.TransparencyKey = System.Drawing.Color.Empty;
            this.txtWechat.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWechat.WaterText = "";
            this.txtWechat.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtQQ
            // 
            this.txtQQ.BitmapCache = false;
            this.txtQQ.Location = new System.Drawing.Point(554, 420);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(162, 33);
            this.txtQQ.TabIndex = 3;
            this.txtQQ.TransparencyKey = System.Drawing.Color.Empty;
            this.txtQQ.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQQ.WaterText = "";
            this.txtQQ.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtAdress
            // 
            this.txtAdress.BitmapCache = false;
            this.txtAdress.Location = new System.Drawing.Point(800, 379);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(162, 33);
            this.txtAdress.TabIndex = 3;
            this.txtAdress.TransparencyKey = System.Drawing.Color.Empty;
            this.txtAdress.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdress.WaterText = "";
            this.txtAdress.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel15
            // 
            this.dSkinLabel15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel15.Location = new System.Drawing.Point(502, 256);
            this.dSkinLabel15.Name = "dSkinLabel15";
            this.dSkinLabel15.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel15.TabIndex = 2;
            this.dSkinLabel15.Text = "邮箱";
            // 
            // dSkinLabel14
            // 
            this.dSkinLabel14.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel14.Location = new System.Drawing.Point(502, 215);
            this.dSkinLabel14.Name = "dSkinLabel14";
            this.dSkinLabel14.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel14.TabIndex = 2;
            this.dSkinLabel14.Text = "手机";
            // 
            // txtContray
            // 
            this.txtContray.BitmapCache = false;
            this.txtContray.Location = new System.Drawing.Point(800, 338);
            this.txtContray.Name = "txtContray";
            this.txtContray.Size = new System.Drawing.Size(162, 33);
            this.txtContray.TabIndex = 3;
            this.txtContray.TransparencyKey = System.Drawing.Color.Empty;
            this.txtContray.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContray.WaterText = "";
            this.txtContray.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel13
            // 
            this.dSkinLabel13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel13.Location = new System.Drawing.Point(748, 420);
            this.dSkinLabel13.Name = "dSkinLabel13";
            this.dSkinLabel13.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel13.TabIndex = 2;
            this.dSkinLabel13.Text = "微信";
            // 
            // txtCity
            // 
            this.txtCity.BitmapCache = false;
            this.txtCity.Location = new System.Drawing.Point(800, 297);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(162, 33);
            this.txtCity.TabIndex = 3;
            this.txtCity.TransparencyKey = System.Drawing.Color.Empty;
            this.txtCity.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCity.WaterText = "";
            this.txtCity.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel12
            // 
            this.dSkinLabel12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel12.Location = new System.Drawing.Point(502, 420);
            this.dSkinLabel12.Name = "dSkinLabel12";
            this.dSkinLabel12.Size = new System.Drawing.Size(39, 28);
            this.dSkinLabel12.TabIndex = 2;
            this.dSkinLabel12.Text = "QQ";
            // 
            // dSkinLabel11
            // 
            this.dSkinLabel11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel11.Location = new System.Drawing.Point(748, 379);
            this.dSkinLabel11.Name = "dSkinLabel11";
            this.dSkinLabel11.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel11.TabIndex = 2;
            this.dSkinLabel11.Text = "地址";
            // 
            // dSkinLabel10
            // 
            this.dSkinLabel10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel10.Location = new System.Drawing.Point(748, 338);
            this.dSkinLabel10.Name = "dSkinLabel10";
            this.dSkinLabel10.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel10.TabIndex = 2;
            this.dSkinLabel10.Text = "国家";
            // 
            // txtProvide
            // 
            this.txtProvide.BitmapCache = false;
            this.txtProvide.Location = new System.Drawing.Point(800, 256);
            this.txtProvide.Name = "txtProvide";
            this.txtProvide.Size = new System.Drawing.Size(162, 33);
            this.txtProvide.TabIndex = 3;
            this.txtProvide.TransparencyKey = System.Drawing.Color.Empty;
            this.txtProvide.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProvide.WaterText = "";
            this.txtProvide.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel9
            // 
            this.dSkinLabel9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel9.Location = new System.Drawing.Point(748, 297);
            this.dSkinLabel9.Name = "dSkinLabel9";
            this.dSkinLabel9.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel9.TabIndex = 2;
            this.dSkinLabel9.Text = "城市";
            // 
            // txtSex
            // 
            this.txtSex.BitmapCache = false;
            this.txtSex.Location = new System.Drawing.Point(554, 379);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(162, 33);
            this.txtSex.TabIndex = 3;
            this.txtSex.TransparencyKey = System.Drawing.Color.Empty;
            this.txtSex.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSex.WaterText = "";
            this.txtSex.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel8
            // 
            this.dSkinLabel8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel8.Location = new System.Drawing.Point(748, 256);
            this.dSkinLabel8.Name = "dSkinLabel8";
            this.dSkinLabel8.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel8.TabIndex = 2;
            this.dSkinLabel8.Text = "省份";
            // 
            // txtHeight
            // 
            this.txtHeight.BitmapCache = false;
            this.txtHeight.Location = new System.Drawing.Point(554, 338);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(162, 33);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.TransparencyKey = System.Drawing.Color.Empty;
            this.txtHeight.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeight.WaterText = "";
            this.txtHeight.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel7
            // 
            this.dSkinLabel7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel7.Location = new System.Drawing.Point(748, 215);
            this.dSkinLabel7.Name = "dSkinLabel7";
            this.dSkinLabel7.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel7.TabIndex = 2;
            this.dSkinLabel7.Text = "密码";
            // 
            // txtAge
            // 
            this.txtAge.BitmapCache = false;
            this.txtAge.Location = new System.Drawing.Point(554, 297);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(162, 33);
            this.txtAge.TabIndex = 3;
            this.txtAge.TransparencyKey = System.Drawing.Color.Empty;
            this.txtAge.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.WaterText = "";
            this.txtAge.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel6
            // 
            this.dSkinLabel6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel6.Location = new System.Drawing.Point(502, 338);
            this.dSkinLabel6.Name = "dSkinLabel6";
            this.dSkinLabel6.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel6.TabIndex = 2;
            this.dSkinLabel6.Text = "身高";
            // 
            // txtPasswd
            // 
            this.txtPasswd.BitmapCache = false;
            this.txtPasswd.Location = new System.Drawing.Point(800, 215);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(162, 33);
            this.txtPasswd.TabIndex = 3;
            this.txtPasswd.TransparencyKey = System.Drawing.Color.Empty;
            this.txtPasswd.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswd.WaterText = "";
            this.txtPasswd.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel5
            // 
            this.dSkinLabel5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel5.Location = new System.Drawing.Point(502, 297);
            this.dSkinLabel5.Name = "dSkinLabel5";
            this.dSkinLabel5.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel5.TabIndex = 2;
            this.dSkinLabel5.Text = "年龄";
            // 
            // txtiName
            // 
            this.txtiName.BitmapCache = false;
            this.txtiName.Location = new System.Drawing.Point(800, 174);
            this.txtiName.Name = "txtiName";
            this.txtiName.Size = new System.Drawing.Size(162, 33);
            this.txtiName.TabIndex = 3;
            this.txtiName.TransparencyKey = System.Drawing.Color.Empty;
            this.txtiName.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtiName.WaterText = "";
            this.txtiName.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel4.Location = new System.Drawing.Point(502, 379);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel4.TabIndex = 2;
            this.dSkinLabel4.Text = "性别";
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel3.Location = new System.Drawing.Point(748, 174);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel3.TabIndex = 2;
            this.dSkinLabel3.Text = "姓名";
            // 
            // txtiUserName
            // 
            this.txtiUserName.BitmapCache = false;
            this.txtiUserName.Location = new System.Drawing.Point(554, 174);
            this.txtiUserName.Name = "txtiUserName";
            this.txtiUserName.Size = new System.Drawing.Size(162, 33);
            this.txtiUserName.TabIndex = 3;
            this.txtiUserName.TransparencyKey = System.Drawing.Color.Empty;
            this.txtiUserName.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtiUserName.WaterText = "";
            this.txtiUserName.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(502, 174);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(46, 28);
            this.dSkinLabel1.TabIndex = 2;
            this.dSkinLabel1.Text = "账号";
            // 
            // btnLoadUserList
            // 
            this.btnLoadUserList.ButtonBorderWidth = 1;
            this.btnLoadUserList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadUserList.HoverColor = System.Drawing.Color.Empty;
            this.btnLoadUserList.HoverImage = null;
            this.btnLoadUserList.Location = new System.Drawing.Point(468, 3);
            this.btnLoadUserList.Name = "btnLoadUserList";
            this.btnLoadUserList.NormalImage = null;
            this.btnLoadUserList.PressColor = System.Drawing.Color.Empty;
            this.btnLoadUserList.PressedImage = null;
            this.btnLoadUserList.Radius = 10;
            this.btnLoadUserList.ShowButtonBorder = true;
            this.btnLoadUserList.Size = new System.Drawing.Size(137, 61);
            this.btnLoadUserList.TabIndex = 1;
            this.btnLoadUserList.Text = "加载用户列表";
            this.btnLoadUserList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadUserList.TextPadding = 0;
            this.btnLoadUserList.Click += new System.EventHandler(this.btnLoadUserList_Click);
            // 
            // userList
            // 
            // 
            // 
            // 
            this.userList.BackPageButton.AdaptImage = true;
            this.userList.BackPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.userList.BackPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.BackPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userList.BackPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.BackPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.BackPageButton.Location = new System.Drawing.Point(386, 4);
            this.userList.BackPageButton.Name = "BtnBackPage";
            this.userList.BackPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.userList.BackPageButton.Radius = 0;
            this.userList.BackPageButton.Size = new System.Drawing.Size(50, 24);
            this.userList.BackPageButton.Text = "上一页";
            this.userList.BackPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userList.BackPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.userList.Borders.AllColor = System.Drawing.Color.Silver;
            this.userList.Borders.BottomColor = System.Drawing.Color.Silver;
            this.userList.Borders.LeftColor = System.Drawing.Color.Silver;
            this.userList.Borders.RightColor = System.Drawing.Color.Silver;
            this.userList.Borders.TopColor = System.Drawing.Color.Silver;
            this.userList.ColumnHeight = 30;
            dSkinGridListColumn1.DataPropertyName = "UserName";
            dSkinGridListColumn1.Name = "用户名";
            dSkinGridListColumn1.Visble = true;
            dSkinGridListColumn1.Width = 120;
            dSkinGridListColumn2.DataPropertyName = "Name";
            dSkinGridListColumn2.Name = "姓名";
            dSkinGridListColumn2.Visble = true;
            dSkinGridListColumn2.Width = 150;
            dSkinGridListColumn3.DataPropertyName = "Phone";
            dSkinGridListColumn3.Name = "电话";
            dSkinGridListColumn3.Visble = true;
            dSkinGridListColumn3.Width = 180;
            this.userList.Columns.AddRange(new DSkin.Controls.DSkinGridListColumn[] {
            dSkinGridListColumn1,
            dSkinGridListColumn2,
            dSkinGridListColumn3});
            this.userList.DoubleItemsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.userList.EnabledOrder = false;
            // 
            // 
            // 
            this.userList.FirstPageButton.AdaptImage = true;
            this.userList.FirstPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.userList.FirstPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.FirstPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userList.FirstPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.FirstPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.FirstPageButton.Location = new System.Drawing.Point(338, 4);
            this.userList.FirstPageButton.Name = "BtnFistPage";
            this.userList.FirstPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.userList.FirstPageButton.Radius = 0;
            this.userList.FirstPageButton.Size = new System.Drawing.Size(44, 24);
            this.userList.FirstPageButton.Text = "首页";
            this.userList.FirstPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userList.FirstPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // 
            // 
            this.userList.GoPageButton.AdaptImage = true;
            this.userList.GoPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.userList.GoPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userList.GoPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userList.GoPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.GoPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.GoPageButton.Location = new System.Drawing.Point(290, 4);
            this.userList.GoPageButton.Name = "BtnGoPage";
            this.userList.GoPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.userList.GoPageButton.Radius = 0;
            this.userList.GoPageButton.Size = new System.Drawing.Size(44, 24);
            this.userList.GoPageButton.Text = "跳转";
            this.userList.GoPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userList.GoPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.userList.GridLineColor = System.Drawing.Color.Silver;
            this.userList.HeaderFont = new System.Drawing.Font("微软雅黑", 9F);
            // 
            // 
            // 
            this.userList.HScrollBar.AutoSize = false;
            this.userList.HScrollBar.Fillet = true;
            this.userList.HScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.HScrollBar.Location = new System.Drawing.Point(0, 580);
            this.userList.HScrollBar.Maximum = 2;
            this.userList.HScrollBar.Name = "";
            this.userList.HScrollBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.userList.HScrollBar.ScrollBarLenght = 423;
            this.userList.HScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.userList.HScrollBar.Size = new System.Drawing.Size(459, 12);
            this.userList.HScrollBar.Visible = false;
            // 
            // 
            // 
            this.userList.LastPageButton.AdaptImage = true;
            this.userList.LastPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.userList.LastPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.LastPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userList.LastPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.LastPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.LastPageButton.Location = new System.Drawing.Point(494, 4);
            this.userList.LastPageButton.Name = "BtnLastPage";
            this.userList.LastPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.userList.LastPageButton.Radius = 0;
            this.userList.LastPageButton.Size = new System.Drawing.Size(44, 24);
            this.userList.LastPageButton.Text = "末页";
            this.userList.LastPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userList.LastPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.userList.Location = new System.Drawing.Point(3, 3);
            this.userList.Name = "userList";
            // 
            // 
            // 
            this.userList.NextPageButton.AdaptImage = true;
            this.userList.NextPageButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.userList.NextPageButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.NextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userList.NextPageButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.NextPageButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.userList.NextPageButton.Location = new System.Drawing.Point(440, 4);
            this.userList.NextPageButton.Name = "BtnNextPage";
            this.userList.NextPageButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.userList.NextPageButton.Radius = 0;
            this.userList.NextPageButton.Size = new System.Drawing.Size(50, 24);
            this.userList.NextPageButton.Text = "下一页";
            this.userList.NextPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userList.NextPageButton.TextRenderMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.userList.SelectedItem = null;
            this.userList.Size = new System.Drawing.Size(459, 531);
            this.userList.TabIndex = 0;
            // 
            // 
            // 
            this.userList.VScrollBar.AutoSize = false;
            this.userList.VScrollBar.BitmapCache = true;
            this.userList.VScrollBar.Fillet = true;
            this.userList.VScrollBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.VScrollBar.LargeChange = 1000;
            this.userList.VScrollBar.Location = new System.Drawing.Point(446, 1);
            this.userList.VScrollBar.Margin = new System.Windows.Forms.Padding(1);
            this.userList.VScrollBar.Maximum = 10000;
            this.userList.VScrollBar.Name = "";
            this.userList.VScrollBar.ScrollBarPartitionWidth = new System.Windows.Forms.Padding(5);
            this.userList.VScrollBar.Size = new System.Drawing.Size(12, 466);
            this.userList.VScrollBar.SmallChange = 500;
            this.userList.VScrollBar.Visible = false;
            this.userList.SelectedItemChanged += new System.EventHandler<DSkin.Controls.DSkinGridListEventArgs>(this.userList_SelectedItemChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.CaptionHeight = 80;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.CloseBox.Image = global::CHUANLING.Properties.Resources.hicetea_p0_9;
            this.CloseBox.ImageSize = new System.Drawing.Size(32, 32);
            this.CloseBox.Size = new System.Drawing.Size(32, 32);
            this.Controls.Add(this.dSkinTabControl1);
            this.IsLayeredWindowForm = false;
            this.MaximizeBox = false;
            this.MinBox.Image = global::CHUANLING.Properties.Resources.hicetea_p0_10;
            this.MinBox.ImageSize = new System.Drawing.Size(32, 32);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 10);
            this.Radius = 40;
            this.SystemButtonsGap = 20;
            this.SystemButtonsOffset = new System.Drawing.Point(5, 5);
            this.Text = "";
            this.dSkinTabControl1.ResumeLayout(false);
            this.dSkinTabPage1.ResumeLayout(false);
            this.dSkinTableLayoutPanel1.ResumeLayout(false);
            this.dSkinPanel1.ResumeLayout(false);
            this.dSkinTabPage2.ResumeLayout(false);
            this.dSkinTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chrtRecord;
        private DSkin.Controls.DSkinButton btnStartRecord;
        private DSkin.Controls.DSkinTabControl dSkinTabControl1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage1;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanel1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage2;
        private DSkin.Controls.DSkinButton btnLoadUserList;
        private DSkin.Controls.DSkinGridList userList;
        private DSkin.Controls.DSkinButton btnAddUser;
        private DSkin.Controls.DSkinButton btnDeleUser;
        private DSkin.Controls.DSkinButton btnEditPasswd;
        private DSkin.Controls.DSkinButton btnEditUser;
        private DSkin.Controls.DSkinTextBox txtRemark;
        private DSkin.Controls.DSkinTextBox txtEmail;
        private DSkin.Controls.DSkinTextBox txtiPhone;
        private DSkin.Controls.DSkinTextBox txtWechat;
        private DSkin.Controls.DSkinTextBox txtQQ;
        private DSkin.Controls.DSkinTextBox txtAdress;
        private DSkin.Controls.DSkinLabel dSkinLabel15;
        private DSkin.Controls.DSkinLabel dSkinLabel14;
        private DSkin.Controls.DSkinTextBox txtContray;
        private DSkin.Controls.DSkinLabel dSkinLabel13;
        private DSkin.Controls.DSkinTextBox txtCity;
        private DSkin.Controls.DSkinLabel dSkinLabel12;
        private DSkin.Controls.DSkinLabel dSkinLabel11;
        private DSkin.Controls.DSkinLabel dSkinLabel10;
        private DSkin.Controls.DSkinTextBox txtProvide;
        private DSkin.Controls.DSkinLabel dSkinLabel9;
        private DSkin.Controls.DSkinTextBox txtSex;
        private DSkin.Controls.DSkinLabel dSkinLabel8;
        private DSkin.Controls.DSkinTextBox txtHeight;
        private DSkin.Controls.DSkinLabel dSkinLabel7;
        private DSkin.Controls.DSkinTextBox txtAge;
        private DSkin.Controls.DSkinLabel dSkinLabel6;
        private DSkin.Controls.DSkinTextBox txtPasswd;
        private DSkin.Controls.DSkinLabel dSkinLabel5;
        private DSkin.Controls.DSkinTextBox txtiName;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        private DSkin.Controls.DSkinTextBox txtiUserName;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
    }
}