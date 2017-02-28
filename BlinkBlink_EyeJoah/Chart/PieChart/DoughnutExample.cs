using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;
using System.Windows.Media;

namespace BlinkBlink_EyeJoah.Chart.PieChart
{
    public partial class DoughnutExample : Form
    {
        public DoughnutExample()
        {
            InitializeComponent();

            //pieChart1.InnerRadius = 40; //내원 반지름
            pieChart1.LegendLocation = LegendLocation.Bottom; //슬라이스 설명 라벨 위치

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<double> {2}, //값
                    //PushOut = 5, //pushout:: 슬라이스와 슬라이스 사이 간격
                    DataLabels = true,
                    Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(1,85,157))
                    //Fill= new LinearGradientBrush
                    //{
                    //    GradientStops = new GradientStopCollection
                    //    {
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(163, 234, 228),0),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(50, 208, 186),.5),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(59, 188, 170),1)
                    //    }
                    //}
                },
                new PieSeries
                {
                    Title = "Normal",
                    Values = new ChartValues<double> {1},
                    //PushOut = 5,
                    DataLabels = true,
                        Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(0,171,188))
                    //     Fill= new LinearGradientBrush
                    //{
                    //    GradientStops = new GradientStopCollection
                    //    {
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(255, 200, 55),0),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(255, 161, 30),.5),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(255, 128, 8),1)
                    //    }
                    //}
                },
                new PieSeries
                {
                    Title = "Bad",
                    Values = new ChartValues<double> {2},
                    //PushOut = 5,
                    DataLabels = true,
                      Fill=new SolidColorBrush(System.Windows.Media.Color.FromRgb(222,111,39))
                    //     Fill= new LinearGradientBrush
                    //{
                    //    GradientStops = new GradientStopCollection
                    //    {
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(248, 80, 50),0),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(240, 69, 186),.5),
                    //         new GradientStop(System.Windows.Media.Color.FromRgb(231, 56, 39),1)
                    //    }
                    //}
                },
            };

        }
    }
}
