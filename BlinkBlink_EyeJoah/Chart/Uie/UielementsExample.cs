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

            var lineSeries = new LineSeries //꺾은선
            {
                Values = new ChartValues<double> { 12, 10, 13, 9, 12 },
                Fill = Brushes.Transparent,
                StrokeThickness = 3,
                PointGeometry = null
            };
            var barSeries = new ColumnSeries //막대그래프
            {
                Values = new ChartValues<double> { 12, 10, 13, 9, 12 },
                StrokeThickness = 2,
                PointGeometry = null,
                MaxColumnWidth = 30,
                
            };

            //cartesianChart1.Series.Add(lineSeries);
            cartesianChart1.Series.Add(barSeries);

            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 3,
                Y = 12,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "WARNING",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Colors.IndianRed),
                    //Opacity = 0.6
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
                        Stroke = Brushes.IndianRed,
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {3d})
                    }
                }
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "9시", "10시", "11시", "12시", "13시" } //마우스 가까이댔을때 뜨는 라벨
            });

            Panel.SetZIndex(barSeries, 0);
            Panel.SetZIndex(lineSeries, 1);
        }

        private void X_Click(object sender, EventArgs e)
        {

        }
    }
}