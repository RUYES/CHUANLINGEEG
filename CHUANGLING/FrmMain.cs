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
    public partial class FrmMain : DSkin.Forms.DSkinForm
    {

        CHUANLING_EEG.TGAM_EEG TGAM_EEG = new CHUANLING_EEG.TGAM_EEG();
        public FrmMain()
        {
            InitializeComponent();
            TGAM_EEG.InitEEG();
            TGAM_EEG.UpdateEEGPara();
            initTableRecord();
        }
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
            chrtRecord.LegendLocation = LegendLocation.Right;
            //  chrtRecord.
            //   chrtRecord.MaximumSize = 2 ^ 64;
            chrtRecord.Series.Add(
                  new LineSeries
                  {
                      //Title = "Delta",
                      Values = RecordValues,
                      PointGeometrySize = 0,
                      StrokeThickness = 4,
                      DataLabels = true
                  });
            chrtRecord.LegendLocation = LegendLocation.Right;
            chrtRecord.AxisX.Add(new Axis
            {
                Title = "RealTime",
                LabelsRotation = 45,
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                Labels = new[] { "Delta", "Theta",
                "LowAlpha","HighAlpha",
                    "LowBeta","HighBeta",
                "LowGamma","MiddleGamma"}
            }
             );

        }


        Thread thread;
       

        private void button1_Click(object sender, EventArgs e)
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


    }
}
