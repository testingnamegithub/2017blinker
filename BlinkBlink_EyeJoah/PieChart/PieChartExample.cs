using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace BlinkBlink_EyeJoah.PieChart
{
    public partial class PieChartExample : Form
    {
        public PieChartExample()
        {
            if (pieChart1 != null)
            {
                pieChart1.InnerRadius = 100;
                pieChart1.LegendLocation = LegendLocation.Right;

                pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Chrome",
                    Values = new ChartValues<double> {8},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<double> {6},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Opera",
                    Values = new ChartValues<double> {10},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<double> {4},
                    DataLabels = true
                }
            };
            }
        }
    }
}