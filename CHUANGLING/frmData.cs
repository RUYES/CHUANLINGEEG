using CHUANLING.Models;
using CHUANLING.Services;
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
    public partial class frmData : DSkin.Forms.DSkinForm
    {
        public frmData(Train train)
        {
            InitializeComponent();

            DataTable dataTable = Services.SqliteHelper.QueryTable(train.TableName);
            List<CHUANLING_EEG.EEG_Para> eEG_Paras = ToModel<CHUANLING_EEG.EEG_Para>.ConvertToModel(dataTable);
            //InitChartA()

            lblStart.Text = train.Start;
            lblEnd.Text = train.End;
            lblLtime.Text = train.Duration;
            lblUserName.Text = train.UserName;
            dataTable = Services.SqliteHelper.QueryTable("UserInfo", "*", "UserName='" + train.UserName + "'");
            List<User> users = Services.ToModel<User>.ConvertToModel(dataTable);
            lblName.Text = users.First().Name;
            lblSex.Text = users.First().Sex;
            lblAge.Text = users.First().Years;
            DrawChartA(eEG_Paras);
            DrawChartB(eEG_Paras);
            DrawChartC(eEG_Paras);
            DrawChartD(eEG_Paras);
            DrawChartE(eEG_Paras);
            DrawChartF(eEG_Paras);

        }

        private void DrawChartF(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Labels = new List<string>() { "0-20%", "20-40%", "40-60%", "60-80%", "80-100%" }
            };
            int iA = 0, iB = 0, iC = 0, iD = 0, iE = 0;
            foreach (EEG_Para item in eEG_Paras)
            {
                if (item.Attention >= 0 && item.Attention < 20)
                {
                    iA++;
                }
                if (item.Attention >= 20 && item.Attention < 40)
                {
                    iB++;
                }
                if (item.Attention >= 40 && item.Attention < 60)
                {
                    iC++;
                }
                if (item.Attention >= 60 && item.Attention < 80)
                {
                    iD++;
                }
                if (item.Attention >= 80 && item.Attention <= 100)
                {
                    iE++;
                }
            }


            ColumnSeries series = new ColumnSeries
            {
                Values = new ChartValues<double> { iA, iB, iC, iD, iE },
                DataLabels = true,
            };

            chartF.AxisX.Add(axisX);

            chartF.Series = new SeriesCollection { series
};
            chartF.LegendLocation = LegendLocation.None;

            #region Pie
            Func<ChartPoint, string> labelPoint = chartPoint =>
          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart2.Series = new SeriesCollection
            {
            new PieSeries
                {
                    Title = "0-20%",
                    Values = new ChartValues<double> {iA},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                        new PieSeries
                {
                    Title = "20-40%",
                    Values = new ChartValues<double> {iB},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                    new PieSeries
                {
                    Title = "40-60%",
                    Values = new ChartValues<double> {iC},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                                new PieSeries
                {
                    Title = "60-80%",
                    Values = new ChartValues<double> {iD},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                                            new PieSeries
                {
                    Title = "80-100%",
                    Values = new ChartValues<double> {iE},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart2.LegendLocation = LegendLocation.Right;
            #endregion

        }

        private void DrawChartE(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Labels = new List<string>() { "0-20%", "20-40%", "40-60%", "60-80%", "80-100%" }
            };
            int iA = 0, iB = 0, iC = 0, iD = 0, iE = 0;
            foreach (EEG_Para item in eEG_Paras)
            {
                if (item.Meditation >= 0 && item.Meditation < 20)
                {
                    iA++;
                }
                if (item.Meditation >= 20 && item.Meditation < 40)
                {
                    iB++;
                }
                if (item.Meditation >= 40 && item.Meditation < 60)
                {
                    iC++;
                }
                if (item.Meditation >= 60 && item.Meditation < 80)
                {
                    iD++;
                }
                if (item.Meditation >= 80 && item.Meditation <= 100)
                {
                    iE++;
                }
            }


            ColumnSeries series = new ColumnSeries
            {
                Values = new ChartValues<double> { iA, iB, iC, iD, iE },
                DataLabels = true,
            };

            chartE.AxisX.Add(axisX);

            chartE.Series = new SeriesCollection { series
};
            chartE.LegendLocation = LegendLocation.None;

            #region Pie
            Func<ChartPoint, string> labelPoint = chartPoint =>
          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection
            {
            new PieSeries
                {
                    Title = "0-20%",
                    Values = new ChartValues<double> {iA},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                        new PieSeries
                {
                    Title = "20-40%",
                    Values = new ChartValues<double> {iB},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                    new PieSeries
                {
                    Title = "40-60%",
                    Values = new ChartValues<double> {iC},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                                new PieSeries
                {
                    Title = "60-80%",
                    Values = new ChartValues<double> {iD},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                                                            new PieSeries
                {
                    Title = "80-100%",
                    Values = new ChartValues<double> {iE},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Right;
            #endregion


        }
        //with Pie
        private void DrawChartA(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Title = "Time",
                Labels = new List<string>() { }
            };

            LineSeries lineAtt = new LineSeries
            {
                Title = "Attition",
                Values = new ChartValues<double> { }
            };
            LineSeries lineMed = new LineSeries
            {
                Title = "Medition",
                Values = new ChartValues<double> { }
            };


            foreach (EEG_Para item in eEG_Paras)
            {
                axisX.Labels.Add(item.Time);
                lineAtt.Values.Add(double.Parse(item.Attention.ToString()));
                lineMed.Values.Add(double.Parse(item.Meditation.ToString()));
            }

            chartA.AxisX.Add(axisX); chartA.AxisY.Add(new Axis { MinValue = 0, MaxValue = 100 });
            chartA.Series = new SeriesCollection { lineAtt, lineMed
};
            chartA.LegendLocation = LegendLocation.None;



        }

        private void DrawChartB(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Title = "Time",
                Labels = new List<string>() { }
            };
            LineSeries lineAtt = new LineSeries
            {
                Title = "Attition",
                Values = new ChartValues<double> { }
            };



            foreach (EEG_Para item in eEG_Paras)
            {
                axisX.Labels.Add(item.Time);
                lineAtt.Values.Add(double.Parse(item.Attention.ToString()));
            }

            chartB.AxisX.Add(axisX); chartB.AxisY.Add(new Axis { MinValue = 0, MaxValue = 100 });
            chartB.Series = new SeriesCollection { lineAtt
};
            chartB.LegendLocation = LegendLocation.None;
        }

        private void DrawChartC(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Title = "Time",
                Labels = new List<string>() { }
            };
            Axis axisY = new Axis
            {
                MinValue = 0

            };
            LineSeries lineMed = new LineSeries
            {
                Title = "Medition",
                Values = new ChartValues<double> { }
            };


            foreach (EEG_Para item in eEG_Paras)
            {
                axisX.Labels.Add(item.Time);

                lineMed.Values.Add(double.Parse(item.Meditation.ToString()));
            }

            chartC.AxisX.Add(axisX); chartC.AxisY.Add(new Axis { MinValue = 0, MaxValue = 100 });
            chartC.Series = new SeriesCollection {  lineMed
};
            chartC.LegendLocation = LegendLocation.None;
        }

        private void DrawChartD(List<EEG_Para> eEG_Paras)
        {
            Axis axisX = new Axis
            {
                Title = "Time",
                Labels = new List<string>() { }
            };
            Axis axisY = new Axis
            {
                MinValue = 0

            };

            LineSeries lineDel = new LineSeries
            {
                Title = "Delta",
                Values = new ChartValues<double> { }
            };
            LineSeries lineThe = new LineSeries
            {
                Title = "Theta",
                Values = new ChartValues<double> { }
            };
            LineSeries lineLA = new LineSeries
            {
                Title = "LowAlpha",
                Values = new ChartValues<double> { }
            };
            LineSeries lineHA = new LineSeries
            {
                Title = "HighAlpha",
                Values = new ChartValues<double> { }
            };
            LineSeries lineLB = new LineSeries
            {
                Title = "LowBeta",
                Values = new ChartValues<double> { }
            };
            LineSeries lineHB = new LineSeries
            {
                Title = "HighBeta",
                Values = new ChartValues<double> { }
            };
            LineSeries lineLG = new LineSeries
            {
                Title = "LowGamma",
                Values = new ChartValues<double> { }
            };
            LineSeries lineMG = new LineSeries
            {
                Title = "MiddleGamma",
                Values = new ChartValues<double> { }
            };


            foreach (EEG_Para item in eEG_Paras)
            {
                axisX.Labels.Add(item.Time);

                lineDel.Values.Add(double.Parse(item.Delta.ToString()));
                lineThe.Values.Add(double.Parse(item.Theta.ToString()));

                lineLA.Values.Add(double.Parse(item.LowAlpha.ToString()));

                lineHA.Values.Add(double.Parse(item.HighAlpha.ToString()));

                lineLB.Values.Add(double.Parse(item.LowBeta.ToString()));

                lineHB.Values.Add(double.Parse(item.HighBeta.ToString()));

                lineLG.Values.Add(double.Parse(item.LowGamma.ToString()));

                lineMG.Values.Add(double.Parse(item.MiddleGamma.ToString()));


            }

            chartD.AxisX.Add(axisX); chartD.AxisY.Add(axisY);
            chartD.Series = new SeriesCollection {  lineDel,lineThe,lineLA,lineHA,lineLB,lineHB,lineLG,lineMG
};
            chartD.LegendLocation = LegendLocation.None;
        }

        private void dSkinButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                string version = app.Version;

                Microsoft.Office.Interop.Word.Document doc = app.Documents.Add("D:\\Test.docx");
                doc.ActiveWindow.Visible = true;
                foreach (Microsoft.Office.Interop.Word.Bookmark bk in doc.Bookmarks)
                {
                    bk.Range.Text = GetStrByBookmarkName(bk.Name);
                }




            });
        }

        private string GetStrByBookmarkName(string name)
        {
            string str = "";
            switch (name)
            {
                case "user_info_name"://用户名

                    break;
                case "user_info_sex"://用户性别
                    break;
                case "user_info_years"://用户年龄
                    break;
                case "":
                    break;
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
            return str;
        }
    }
}
