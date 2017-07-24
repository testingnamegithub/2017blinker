using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using Winforms.Cartesian.ConstantChanges;
using System.Windows.Media;

namespace BlinkBlink_EyeJoah.Chart.ConstantChange
{
    public partial class ConstantChange : Form
    {
        public ConstantChange()
        {
            InitializeComponent();

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    //Fill = System.Windows.Media.Brushes.Transparent,
                    //Stroke = System.Windows.Media.Brushes.CadetBlue,
                    Values = ChartValues,
                    PointGeometrySize = 2,
                    StrokeThickness = 4,
                    Stroke=new SolidColorBrush(Color.FromRgb(50, 208, 186)),
                    Fill=new SolidColorBrush(Color.FromArgb(200,218, 253, 247))
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);

        }

        public ChartValues<MeasureModel> ChartValues { get; set; }
        public Timer Timer { get; set; }
        public Random R { get; set; }
        public ConstantChange ShowDilaog { get; internal set; }

        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0.1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(10).Ticks; //we only care about the last 8 seconds
        }

        public void ShowThresholdValue(int value)
        {
            var now = System.DateTime.Now;
            ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = value
            });
            SetAxisLimits(now);

            //Form1.lb.Text = value.ToString();
            //lets only use the last 30 values
            if (ChartValues.Count > 150) ChartValues.RemoveAt(0);
        }
        
    }
}
