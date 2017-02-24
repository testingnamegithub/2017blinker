﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;


namespace BlinkBlink_EyeJoah.Chart.PieChart
{
    public partial class DoughnutExample : Form
    {
        public DoughnutExample()
        {
            InitializeComponent();

            pieChart1.InnerRadius = 100;
            pieChart1.LegendLocation = LegendLocation.Right;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Greate",
                    Values = new ChartValues<double> {8},
                    PushOut = 15,
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Nomal",
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
