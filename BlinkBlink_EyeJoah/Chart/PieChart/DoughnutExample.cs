using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;
using System.Windows.Media;
using LiveCharts.Defaults;

namespace BlinkBlink_EyeJoah.Chart.PieChart
{
    public partial class DoughnutExample : Form
    {
        public static DoughnutExample doughnut;

        public DoughnutExample()
        {
            doughnut = this;
            
            InitializeComponent();

            //pieChart1.InnerRadius = 40; //내원 반지름
            pieChart1.LegendLocation = LegendLocation.Bottom; //슬라이스 설명 라벨 위치

            pieChart1.InnerRadius = 50;
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<double> {0}, //값
                   
                    //PushOut = 5, //pushout:: 슬라이스와 슬라이스 사이 간격
                    DataLabels = true,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(1,85,157)),
                },
                new PieSeries
                {
                    Title = "Normal",
                    Values = new ChartValues<double> {0},
                    //PushOut = 5,
                    DataLabels = true,
                        Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,171,188))
                },
                new PieSeries
                {
                    Title = "Bad",
                    Values = new ChartValues<double> {0},
                    //PushOut = 5,
                    DataLabels = true,
                      Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(222,111,39))
                },
            };

        }

        public void updateBlinkPie(double great, double normal, double bad)
        {
            double sum = great + normal + bad;
            double greatArea = Math.Round(great/sum / .01) * .01;
            double normalArea = Math.Round(normal/sum / .01) * .01;
            double badArea = Math.Round(bad/sum / .01) * .01;
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(greatArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " %",
                    FontSize = 15,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(1,85,157))
                    //PushOut = 5, // 슬라이스와 슬라이스 사이 간격
                },
                new PieSeries
                {
                    Title = "Normal",

                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(normalArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " %",
                    FontSize = 15,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,171,188))
                },
                new PieSeries
                {
                    Title = "Bad",

                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(badArea*100),
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " %",
                    FontSize = 15,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(222,111,39))
                },
            };
        }
    }
}
