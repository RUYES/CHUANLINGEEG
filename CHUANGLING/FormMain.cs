using CHUANLING_EEG;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CHUANLING
{
    public partial class FormMain : DSkin.Forms.DSkinForm
    {
        CHUANLING_EEG.TGAM_EEG TGAM_EEG = new CHUANLING_EEG.TGAM_EEG();

        #region EEG实时曲线
        public ChartValues<ObservableValue> RecordValues { get; set; }
        private void initTableRecord()
        {
            RecordValues = new ChartValues<ObservableValue>
            {
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0)
            };
            chrtRecord.LegendLocation = LegendLocation.None;

            //chrtRecord.Series.

            //  chrtRecord.
            //   chrtRecord.MaximumSize = 2 ^ 64;
            chrtRecord.Series.Add(
                  new LineSeries
                  {
                      Title = "RT",
                      Values = RecordValues,
                      PointGeometrySize = 0,
                      StrokeThickness = 4,
                      DataLabels = true,



                  });
            //chrtRecord.LegendLocation = LegendLocation.Right;
            chrtRecord.AxisX.Add(new Axis
            {
                Title = "RealTime",
                //LabelsRotation = 45,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                ShowLabels = false,
                //Position=AxisPosition.
                //Labels = new[] { "Delta", "Theta",
                //"LowAlpha","HighAlpha",
                //    "LowBeta","HighBeta",
                //"LowGamma","MiddleGamma"}
            }
             );

        }
        #endregion



        //#region 专注度曲线
        //public ChartValues<ObservableValue> RecordAt { get; set; }
        //private void initTableReAt()
        //{
        //    RecordAt = new ChartValues<ObservableValue>
        //    {
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0)
        //    };

        //    chrtRecord.LegendLocation = LegendLocation.None;

        //    //chrtRecord.Series.

        //    //  chrtRecord.
        //    //   chrtRecord.MaximumSize = 2 ^ 64;
        //    chrtRecord.Series.Add(
        //          new LineSeries
        //          {
        //              Title = "RT",
        //              Values = RecordValues,
        //              PointGeometrySize = 0,
        //              StrokeThickness = 4,
        //              DataLabels = true,



        //          });
        //    //chrtRecord.LegendLocation = LegendLocation.Right;
        //    chrtRecord.AxisX.Add(new Axis
        //    {
        //        Title = "RealTime",
        //        //LabelsRotation = 45,
        //        Separator = new Separator // force the separator step to 1, so it always display all labels
        //        {
        //            Step = 1,
        //            IsEnabled = false //disable it to make it invisible.
        //        },
        //        ShowLabels = false,
        //        //Position=AxisPosition.
        //        //Labels = new[] { "Delta", "Theta",
        //        //"LowAlpha","HighAlpha",
        //        //    "LowBeta","HighBeta",
        //        //"LowGamma","MiddleGamma"}
        //    }
        //     );

        //}
        //#endregion

        //#region 专注度曲线
        //public ChartValues<ObservableValue> RecordAt { get; set; }
        //private void initTableReAt()
        //{
        //    RecordAt = new ChartValues<ObservableValue>
        //    {
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0),
        //        new ObservableValue(0)
        //    };

        //    chrtRecord.LegendLocation = LegendLocation.None;

        //    //chrtRecord.Series.

        //    //  chrtRecord.
        //    //   chrtRecord.MaximumSize = 2 ^ 64;
        //    chrtRecord.Series.Add(
        //          new LineSeries
        //          {
        //              Title = "RT",
        //              Values = RecordValues,
        //              PointGeometrySize = 0,
        //              StrokeThickness = 4,
        //              DataLabels = true,



        //          });
        //    //chrtRecord.LegendLocation = LegendLocation.Right;
        //    chrtRecord.AxisX.Add(new Axis
        //    {
        //        Title = "RealTime",
        //        //LabelsRotation = 45,
        //        Separator = new Separator // force the separator step to 1, so it always display all labels
        //        {
        //            Step = 1,
        //            IsEnabled = false //disable it to make it invisible.
        //        },
        //        ShowLabels = false,
        //        //Position=AxisPosition.
        //        //Labels = new[] { "Delta", "Theta",
        //        //"LowAlpha","HighAlpha",
        //        //    "LowBeta","HighBeta",
        //        //"LowGamma","MiddleGamma"}
        //    }
        //     );

        //}
        //#endregion



        public FormMain()
        {
            InitializeComponent();

            TGAM_EEG.InitEEG();
            TGAM_EEG.UpdateEEGPara();
            initTableRecord();
        }
        Thread thread;
        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {

                Dictionary<DateTime, EEG_Para> keyValues = new Dictionary<DateTime, EEG_Para>();
                string tableName = "Test" + DateTime.Now.ToString("yyyyMMddhhmmss");
                Services.DBServices.AddTrainTable(tableName);
                for (int i = 0; i < 100; i++)
                {
                    //keyValues.Add(DateTime.Now, TGAM_EEG.para);
                    Services.DBServices.InsertTrainTable(tableName, TGAM_EEG.para);
                    int icount = 0;
                    this.Invoke(new Action(() =>
                    {

                        RecordValues[icount++].Value = TGAM_EEG.para.Delta;
                        RecordValues[icount++].Value = TGAM_EEG.para.Theta;
                        RecordValues[icount++].Value = TGAM_EEG.para.LowAlpha;
                        RecordValues[icount++].Value = TGAM_EEG.para.HighAlpha;
                        RecordValues[icount++].Value = TGAM_EEG.para.LowBeta;
                        RecordValues[icount++].Value = TGAM_EEG.para.HighBeta;
                        RecordValues[icount++].Value = TGAM_EEG.para.LowGamma;
                        RecordValues[icount].Value = TGAM_EEG.para.MiddleGamma;
                    }));

                    Thread.Sleep(1000);
                }

                MessageBox.Show("Test");
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnLoadUserList_Click(object sender, EventArgs e)
        {
            DataTable userTable = Services.SqliteHelper.QueryTable("UserInfo", "UserName,Name,Phone");
            userList.DataSource = userTable;


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtiUserName.Text.Trim();
            string name = txtiName.Text.Trim();
            string passwd = txtPasswd.Text;
            string phone = txtiPhone.Text.Trim();
            if (username == "" || name == "" || phone == "")
            {
                return;
            }
            int ret = Services.DBServices.AddNewUser(new Models.User(username, name, passwd, phone));
            if (ret == 1)
            {
                DSkin.Forms.DSkinMessageBox.Show("添加用户成功！");
            }
            else
            {
                DSkin.Forms.DSkinMessageBox.Show("添加用户失败！");
            }

        }
        string selectUser = "";
        private void userList_SelectedItemChanged(object sender, DSkin.Controls.DSkinGridListEventArgs e)
        {
            try
            {
                selectUser = e.Item.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                //  throw;
            }
           // selectUser = e.Item.Cells[0].Value.ToString();

        }

        private void btnDeleUser_Click(object sender, EventArgs e)
        {
            if (DSkin.Forms.DSkinMessageBox.Show("确定要删除" + selectUser + "吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Services.DBServices.DeleteUser(new Models.User(selectUser, "N/A"));
                DataTable userTable = Services.SqliteHelper.QueryTable("UserInfo", "UserName,Name,Phone");
                userList.DataSource = userTable;

            }
        }
    }
}
