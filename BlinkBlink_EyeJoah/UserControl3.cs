﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using BlinkBlink_EyeJoah.Chart.PieChart;
using BlinkBlink_EyeJoah.Chart.Section;
using BlinkBlink_EyeJoah.Chart.Uie;
using BlinkBlink_EyeJoah.Chart.Funnel_chart;
using BlinkBlink_EyeJoah.Chart._360;

namespace BlinkBlink_EyeJoah
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            makeChart();
        }

        private void makeChart()
        {
            chartPanel1.Controls.Clear();
            // FunnelExample fun = new FunnelExample();
            Gauge360Example fun = new Gauge360Example();
            fun.TopLevel = false;
            fun.AutoScroll = true;
            chartPanel1.Controls.Add(fun);
            fun.Show();
        }

    }
}
