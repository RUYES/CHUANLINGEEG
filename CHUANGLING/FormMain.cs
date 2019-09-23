using CHUANLING.Models;
using CHUANLING_EEG;
using LiveCharts;
using LiveCharts.Configurations;
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
                      PointGeometry = DefaultGeometries.Diamond,
                      PointGeometrySize = 8,
                      StrokeThickness = 2,
                      DataLabels = true,
                      StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                      LineSmoothness = 0,

                  });
            //chrtRecord.LegendLocation = LegendLocation.Right;
            chrtRecord.AxisX.Add(new Axis
            {
                Title = "",
                IsMerged = true,
                //LabelsRotation = 45,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
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

        #region 专注度曲线
        public ChartValues<AtModel> ChartValuesat { get; set; }
        private void InitTableReAt()
        {
            var mapper = Mappers.Xy<AtModel>()
             .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
             .Y(model => model.Value);           //use the value property as Y
            Charting.For<AtModel>(mapper);
            ChartValuesat = new ChartValues<AtModel>();
            chartRealAtt.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValuesat,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            chartRealAtt.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            SetAxisLimitsat(System.DateTime.Now);

        }
        private void SetAxisLimitsat(System.DateTime now)
        {
            chartRealAtt.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            chartRealAtt.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(20).Ticks; //we only care about the last 8 seconds
        }
        #endregion
        #region 放松度曲线
        public ChartValues<DeModel> ChartValuesde { get; set; }
        private void InitTableReDe()
        {
            var mapper = Mappers.Xy<DeModel>()
             .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
             .Y(model => model.Value);           //use the value property as Y
            Charting.For<DeModel>(mapper);
            ChartValuesde = new ChartValues<DeModel>();
            chartRealMed.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValuesde,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            chartRealMed.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            SetAxisLimitsde(System.DateTime.Now);

        }
        private void SetAxisLimitsde(System.DateTime now)
        {
            chartRealMed.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            chartRealMed.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(20).Ticks; //we only care about the last 8 seconds
        }
        #endregion

        User LogUser;

        public FormMain(User user)
        {
            InitializeComponent();
            LogUser = user;
            TGAM_EEG.InitEEG();
            TGAM_EEG.UpdateEEGPara();
            initTableRecord();
            InitTableReAt();
            InitTableReDe();
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

                    RecordValues[icount++].Value = TGAM_EEG.para.Delta;
                    RecordValues[icount++].Value = TGAM_EEG.para.Theta;
                    RecordValues[icount++].Value = TGAM_EEG.para.LowAlpha;
                    RecordValues[icount++].Value = TGAM_EEG.para.HighAlpha;
                    RecordValues[icount++].Value = TGAM_EEG.para.LowBeta;
                    RecordValues[icount++].Value = TGAM_EEG.para.HighBeta;
                    RecordValues[icount++].Value = TGAM_EEG.para.LowGamma;
                    RecordValues[icount].Value = TGAM_EEG.para.MiddleGamma;

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
        frmData frm;
        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Services.SqliteHelper.QueryTable("TrainRecord");
            this.RecordList.DataSource = dataTable;


        }

        private void UpdateAllSheet(EEG_Para eEG, Models.Train train)
        {
            //A
            InitASheet();
            //B
            InitBSheet();
            //C
            InitCSheet();
            //D
            InitDSheet();
            //E
            InitESheet();

        }

        private void InitESheet()
        {
            throw new NotImplementedException();
        }

        private void InitDSheet()
        {
            throw new NotImplementedException();
        }

        private void InitCSheet()
        {
            throw new NotImplementedException();
        }

        private void InitBSheet()
        {
            throw new NotImplementedException();
        }

        private void InitASheet()
        {
            throw new NotImplementedException();
        }
        Dictionary<DateTime, EEG_Para> _Paras = new Dictionary<DateTime, EEG_Para>();
        string tableName = "";
        private void startRecord_Click(object sender, EventArgs e)
        {
            if (startRecord.Text == "开始记录")
            {
                startRecord.Text = "结束记录";

                if (TGAM_EEG.isConnected)
                {
                    _Paras.Clear();
                    thread = new Thread(() =>
                    {
                        Dictionary<DateTime, EEG_Para> keyValues = new Dictionary<DateTime, EEG_Para>();
                        tableName = LogUser.UserName + DateTime.Now.ToString("yyyyMMddhhmmss");
                        Services.DBServices.AddTrainTable(tableName);

                        while (true)
                        {
                            //keyValues.Add(DateTime.Now, TGAM_EEG.para);
                            Services.DBServices.InsertTrainTable(tableName, TGAM_EEG.para);
                            _Paras.Add(DateTime.Now, TGAM_EEG.para);
                            int icount = 0;
                            try
                            {
                                var now = System.DateTime.Now;
                                ChartValuesat.Add(new AtModel
                                {
                                    DateTime = now,
                                    Value = TGAM_EEG.para.Attention
                                });
                                ChartValuesde.Add(new DeModel
                                {
                                    DateTime = now,
                                    Value = TGAM_EEG.para.Meditation
                                });
                                this.Invoke(new Action(() => { SetAxisLimitsat(now); SetAxisLimitsde(now); }));

                                if (ChartValuesat.Count > 30) ChartValuesat.RemoveAt(0);
                                if (ChartValuesde.Count > 30) ChartValuesde.RemoveAt(0);
                                this.Invoke(new Action(() =>
                                    {
                                        lblDelta.Text = TGAM_EEG.para.Delta.ToString();
                                        lblTheta.Text = TGAM_EEG.para.Theta.ToString();
                                        lblLa.Text = TGAM_EEG.para.LowAlpha.ToString();
                                        lblHa.Text = TGAM_EEG.para.HighAlpha.ToString();
                                        lblLb.Text = TGAM_EEG.para.LowBeta.ToString();
                                        lblHb.Text = TGAM_EEG.para.HighBeta.ToString();
                                        lblLg.Text = TGAM_EEG.para.LowGamma.ToString();
                                        lblMg.Text = TGAM_EEG.para.MiddleGamma.ToString();

                                    }));
                                RecordValues[icount++].Value = TGAM_EEG.para.Delta;
                                RecordValues[icount++].Value = TGAM_EEG.para.Theta;
                                RecordValues[icount++].Value = TGAM_EEG.para.LowAlpha;
                                RecordValues[icount++].Value = TGAM_EEG.para.HighAlpha;
                                RecordValues[icount++].Value = TGAM_EEG.para.LowBeta;
                                RecordValues[icount++].Value = TGAM_EEG.para.HighBeta;
                                RecordValues[icount++].Value = TGAM_EEG.para.LowGamma;
                                RecordValues[icount].Value = TGAM_EEG.para.MiddleGamma;
                            }
                            catch (Exception ex)
                            {

                            }


                            Thread.Sleep(1000);
                        }
                    });
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            else
            {
                startRecord.Text = "开始记录";
                try
                {

                    thread.Abort();
                    if (_Paras.Count != 0)
                    {
                        Train train = new Train();
                        train.UserName = "Test";
                        train.Date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                        train.Start = _Paras.Keys.First().ToString("HH:mm:ss");
                        train.End = _Paras.Keys.Last().ToString("HH:mm:ss");
                        train.Duration = _Paras.Count.ToString();
                        train.Item = "综合记录";
                        train.TableName = tableName;
                        Services.DBServices.AddNewTrain(train);
                    }

                    //   thread.DisableComObjectEagerCleanup();
                }
                catch (Exception)
                {

                    //throw;
                }
            }
        }
        string Opentablename = "";
        private void RecordList_SelectedItemChanged(object sender, DSkin.Controls.DSkinGridListEventArgs e)
        {
            try
            {
                Opentablename = e.Item.Cells.Last().Value.ToString();
            }
            catch (Exception ex)
            {

                //throw;
            }



        }

        private void btnOpenRecordItem_Click(object sender, EventArgs e)
        {
            DataTable data = Services.SqliteHelper.QueryTable("TrainRecord", "*", "TableName='" + Opentablename + "'");
            List<Train> trains = Services.ToModel<Train>.ConvertToModel(data);
            frm = new frmData(trains.First());
            frm.ShowDialog();
        }

        private void dSkinButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
