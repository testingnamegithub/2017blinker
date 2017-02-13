using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using Panel = System.Windows.Controls.Panel;

namespace BlinkBlink_EyeJoah.Chart.Uie
{
    public partial class UielementsExample : Form
    {
        public UielementsExample()
        {
            InitializeComponent();

            var lineSeries = new LineSeries
            {
                Values = new ChartValues<double> { 12, 10, 13, 9, 12, 13, 14, 15 },
                Fill = Brushes.Transparent,
                StrokeThickness = 2,
                PointGeometry = null
            };
            var barSeries = new ColumnSeries
            {
                Values = new ChartValues<double> { 12, 10, 13, 9, 12, 13, 14, 15 },
                StrokeThickness = 0.2,
                PointGeometry = null
            };

            cartesianChart1.Series.Add(lineSeries);
            cartesianChart1.Series.Add(barSeries);

            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 3,
                Y = 12,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "Warning!",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Opacity = 0.6
                }
            });
            var uri = new Uri("Cartesian/UielementsExample/warning.png", UriKind.Relative);
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 0.5,
                Y = 11.9,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri),
                    Width = 24,
                    Height = 24
                }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = 12,
                        Stroke = Brushes.YellowGreen,
                        StrokeThickness = 3,
                        StrokeDashArray = new DoubleCollection(new [] {10d})
                    }
                }
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "9", "10", "11", "12", "14", "15", "16", "17" }
            });

            Panel.SetZIndex(barSeries, 0);
            Panel.SetZIndex(lineSeries, 1);
        }
    }
}