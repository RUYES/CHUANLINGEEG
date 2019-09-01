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
            this.chrtRecord = new LiveCharts.WinForms.CartesianChart();
            this.btnStartRecord = new DSkin.Controls.DSkinButton();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinTabPage1 = new DSkin.Controls.DSkinTabPage();
            this.dSkinTableLayoutPanel1 = new DSkin.Controls.DSkinTableLayoutPanel();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinTabControl1.SuspendLayout();
            this.dSkinTabPage1.SuspendLayout();
            this.dSkinTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtRecord
            // 
            this.chrtRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chrtRecord.Location = new System.Drawing.Point(3, 202);
            this.chrtRecord.Name = "chrtRecord";
            this.chrtRecord.Size = new System.Drawing.Size(338, 165);
            this.chrtRecord.TabIndex = 0;
            this.chrtRecord.Text = "cartesianChart1";
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.ButtonBorderWidth = 1;
            this.btnStartRecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStartRecord.HoverColor = System.Drawing.Color.Empty;
            this.btnStartRecord.HoverImage = null;
            this.btnStartRecord.Location = new System.Drawing.Point(395, 3);
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
            this.dSkinTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
            this.dSkinTabControl1.ItemBackgroundImage = null;
            this.dSkinTabControl1.ItemBackgroundImageHover = null;
            this.dSkinTabControl1.ItemBackgroundImageSelected = null;
            this.dSkinTabControl1.Location = new System.Drawing.Point(7, 52);
            this.dSkinTabControl1.Name = "dSkinTabControl1";
            this.dSkinTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            this.dSkinTabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.dSkinTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.White};
            this.dSkinTabControl1.Size = new System.Drawing.Size(784, 421);
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
            this.dSkinTabPage1.Location = new System.Drawing.Point(0, 22);
            this.dSkinTabPage1.Name = "dSkinTabPage1";
            this.dSkinTabPage1.Size = new System.Drawing.Size(784, 399);
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
            this.dSkinTableLayoutPanel1.Controls.Add(this.chrtRecord, 0, 1);
            this.dSkinTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.dSkinTableLayoutPanel1.Name = "dSkinTableLayoutPanel1";
            this.dSkinTableLayoutPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinTableLayoutPanel1.RightBottom")));
            this.dSkinTableLayoutPanel1.RowCount = 2;
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dSkinTableLayoutPanel1.Size = new System.Drawing.Size(784, 399);
            this.dSkinTableLayoutPanel1.TabIndex = 2;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.BackgroundImage = global::CHUANLING.Properties.Resources.hicetea_p0_32;
            this.dSkinPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel1.Location = new System.Drawing.Point(3, 3);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(386, 193);
            this.dSkinPanel1.TabIndex = 0;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(798, 508);
            this.CloseBox.Image = global::CHUANLING.Properties.Resources.hicetea_p0_9;
            this.CloseBox.ImageSize = new System.Drawing.Size(32, 32);
            this.Controls.Add(this.dSkinTabControl1);
            this.IsLayeredWindowForm = false;
            this.MaximizeBox = false;
            this.MinBox.Image = global::CHUANLING.Properties.Resources.hicetea_p0_10;
            this.MinBox.ImageSize = new System.Drawing.Size(32, 32);
            this.Name = "FormMain";
            this.Radius = 80;
            this.SystemButtonsGap = 20;
            this.SystemButtonsOffset = new System.Drawing.Point(10, 30);
            this.Text = "";
            this.dSkinTabControl1.ResumeLayout(false);
            this.dSkinTabPage1.ResumeLayout(false);
            this.dSkinTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chrtRecord;
        private DSkin.Controls.DSkinButton btnStartRecord;
        private DSkin.Controls.DSkinTabControl dSkinTabControl1;
        private DSkin.Controls.DSkinTabPage dSkinTabPage1;
        private DSkin.Controls.DSkinTableLayoutPanel dSkinTableLayoutPanel1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
    }
}