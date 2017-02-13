using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
namespace BlinkBlink_EyeJoah.Chart.Section
{
    public partial class SectionExample : Form
    {
        public SectionExample()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5),
                        new ObservableValue(5)

                    },
                    PointGeometry = DefaultGeometries.None,
                    StrokeThickness = 4,
                    Fill = System.Windows.Media.Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1),
                        new ObservableValue(1)
                    },
                    PointGeometry = DefaultGeometries.None,
                    StrokeThickness = 4,
                    Fill = System.Windows.Media.Brushes.Transparent
                }
            };

            cartesianChart1.AxisY.Add(new Axis
            {
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = 8.5,
                        Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(248, 213, 72))
                    },
                    new AxisSection
                    {
                        Label = "Good",
                        Value = 4,
                        SectionWidth = 4,
                        Fill = new SolidColorBrush
                        {
                            Color = System.Windows.Media.Color.FromRgb(204,204,204),
                            Opacity = .4
                        }
                    },
                    new AxisSection
                    {
                        Label = "Bad",
                        Value = 0,
                        SectionWidth = 4,
                        Fill = new SolidColorBrush
                        {
                            Color = System.Windows.Media.Color.FromRgb(254,132,132),
                            Opacity = .4
                        }
                    }
                }
            });

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}

