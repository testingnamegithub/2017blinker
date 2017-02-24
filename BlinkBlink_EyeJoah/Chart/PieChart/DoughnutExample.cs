using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Drawing;

namespace BlinkBlink_EyeJoah.Chart.PieChart
{
    public partial class DoughnutExample : Form
    {
        public DoughnutExample()
        {
            InitializeComponent();

            pieChart1.InnerRadius = 40;
            pieChart1.LegendLocation = LegendLocation.Right;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Great",
                    Values = new ChartValues<double> {8},
                    PushOut = 15,
                    DataLabels = true,
                    Fill=System.Windows.Media.Brushes.DarkCyan
                },
                new PieSeries
                {
                    Title = "Normal",
                    Values = new ChartValues<double> {6},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Bad",
                    Values = new ChartValues<double> {10},
                    DataLabels = true
                },
                
            };
        }
    }
}
