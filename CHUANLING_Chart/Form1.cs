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
using System.Windows.Forms;
using System.Windows.Media;

namespace CHUANLING_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 柱形图
        /// </summary>
        private void InitZhuXing()
        {
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(4),
                    new ObservableValue(2),
                    new ObservableValue(8),
                    new ObservableValue(2),
                    new ObservableValue(3),
                    new ObservableValue(0),
                    new ObservableValue(1),
                },
                DataLabels = true,
                LabelPoint = point => point.Y + "K"
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    "Shea Ferriera",
                    "Shea Ferriera",
                    "Scottie Brogdon",
                    "Teresa Kerman",
                    "Nell Venuti",
                    "Anibal Brothers",
                    "Anderson Dillman"
                },
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                LabelsRotation = 45
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value + ".00K items",
                Separator = new Separator()
            });

        }

        /// <summary>
        /// 折线图
        /// </summary>
        private void InitZheXian()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {5, 2, 8, 3},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LegendLocation.Right;
            //更改数据集合会触发动画并更新图表
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //直线, 1 表示平滑曲线
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = System.Windows.Media.Brushes.Gray
            });
            //更改任何series都会触发动画并更新图表
            cartesianChart1.Series[2].Values.Add(5d);
            cartesianChart1.DataClick += CartesianChart1OnDataClick;
        }

        private void Initbingtu()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
              string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }


        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Initbingtu();
        }
    }
}
