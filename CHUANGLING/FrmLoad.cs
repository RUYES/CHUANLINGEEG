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
    public partial class FrmLoad : DSkin.Forms.DSkinForm, ISplashForm
    {
        public FrmLoad()
        {
            InitializeComponent();
        }
        void ISplashForm.SetStatusInfo(string NewStatusInfo)
        {
            txtInfo.Text = NewStatusInfo;
        }
    }
}
