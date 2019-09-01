namespace CHUANLING
{
    partial class FrmLoad
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
            this.dSkinPictureBox1 = new DSkin.Controls.DSkinPictureBox();
            this.txtInfo = new DSkin.Controls.DSkinLabel();
            this.SuspendLayout();
            // 
            // dSkinPictureBox1
            // 
            this.dSkinPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dSkinPictureBox1.Image = global::CHUANLING.Properties.Resources.微信图片_20190901171129;
            this.dSkinPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(global::CHUANLING.Properties.Resources.微信图片_20190901171129))};
            this.dSkinPictureBox1.Location = new System.Drawing.Point(4, 34);
            this.dSkinPictureBox1.Name = "dSkinPictureBox1";
            this.dSkinPictureBox1.Size = new System.Drawing.Size(685, 221);
            this.dSkinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dSkinPictureBox1.TabIndex = 0;
            this.dSkinPictureBox1.Text = "dSkinPictureBox1";
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInfo.Location = new System.Drawing.Point(4, 300);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(685, 42);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "载入中";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtInfo.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.dSkinPictureBox1);
            this.Name = "FrmLoad";
            this.ShowSystemButtons = false;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinPictureBox dSkinPictureBox1;
        private DSkin.Controls.DSkinLabel txtInfo;
    }
}