using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace BlinkBlink_EyeJoah.Chart._360
{
    public partial class Gauge360Example : Form
    {
        public Gauge360Example()
        {
            InitializeComponent();

            //standard gauge
            //solidGauge5.From = 0;
            //solidGauge5.To = 100;
            //solidGauge5.Value = 50;

            //custom fill
            solidGauge5.Uses360Mode = true;
            solidGauge5.From = 0;
            solidGauge5.To = 100;
            solidGauge5.Value = 60;
            solidGauge5.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge5.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.SkyBlue, 0),
                    new GradientStop(Colors.SteelBlue, .5),
                    new GradientStop(Colors.DarkBlue, 1)
                }
            };

            //standard gauge
            //solidGauge6.From = 0;
            //solidGauge6.To = 100;
            //solidGauge6.Value = 50;

            //custom fill
            solidGauge6.Uses360Mode = true;
            solidGauge6.From = 0;
            solidGauge6.To = 100;
            solidGauge6.Value = 40;
            solidGauge6.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge6.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                      new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.Orange, .5),
                    new GradientStop(Colors.Red, 1)
                }
            };

            //standard gauge
            //solidGauge7.From = 0;
            //solidGauge7.To = 100;
            //solidGauge7.Value = 50;

            //custom fill
            solidGauge7.Uses360Mode = true;
            solidGauge7.From = 0;
            solidGauge7.To = 100;
            solidGauge7.Value = 70;
            solidGauge7.Base.LabelsVisibility = Visibility.Hidden;
            solidGauge7.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                      new GradientStop(Colors.YellowGreen, 0),
                    new GradientStop(Colors.Olive, .5),
                    new GradientStop(Colors.DarkOliveGreen, 1)
                }
            };

        }
    }
}
