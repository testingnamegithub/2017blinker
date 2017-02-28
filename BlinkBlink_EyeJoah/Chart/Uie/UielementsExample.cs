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

            //var lineSeries = new LineSeries //꺾은선
            //{
            //    Values = new ChartValues<double> { 12, 10, 13, 9, 12 },
            //    Fill = Brushes.Transparent,
            //    StrokeThickness = 3,
            //    PointGeometry = null
            //};
            var barSeries = new ColumnSeries //막대그래프
            {
                Values = new ChartValues<double> { 5, 6, 9, 8, 10 },
                StrokeThickness = 1.5,
                PointGeometry = null,
                MaxColumnWidth = 30,
                Stroke = new SolidColorBrush(Colors.AliceBlue), //가장자리 색상
                //Stroke = new SolidColorBrush(Colors.Silver),
                //Fill = new SolidColorBrush(Color.FromRgb(68,125,155)) //막대 내부 색상
                Fill = new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                                                                    {
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(8,80,120),1),
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(72,149,164),.5),
                                                                         new GradientStop(System.Windows.Media.Color.FromRgb(133,216,206),0)
                                                                    }
                }
                //Fill = new LinearGradientBrush
                //{
                //    GradientStops = new GradientStopCollection
                //                                                    {
                //                                                         new GradientStop(System.Windows.Media.Color.FromRgb(44,62,80),1),
                //                                                         new GradientStop(System.Windows.Media.Color.FromRgb(47,105,146),.5),
                //                                                         new GradientStop(System.Windows.Media.Color.FromRgb(52,152,219),0)
                //                                                    }
                //}
            };

            //cartesianChart1.Series.Add(lineSeries);
            cartesianChart1.Series.Add(barSeries);

            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 1,
                Y = 8,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "WARNING",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromRgb(187, 56, 53)),
                    //Opacity = 0.6
                }
            });
            var uri = new Uri("Cartesian/UielementsExample/warning.png", UriKind.Relative);
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 2.5,
                Y = 8,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
                UIElement = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(uri),
                    Width = 40,
                    Height = 40
                }
            });

            //good or bad 영역에 따른 색
            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Sections = new SectionsCollection
                {
                    //warning 점선
                    new AxisSection
                    {
                        Value = 8,
                        //Stroke = Brushes.Crimson,
                        Stroke=new SolidColorBrush(Color.FromRgb(187,56,53)),
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {3d})
                    },
                    //good 영역
                        new AxisSection
                    {
                        //Label = "Good",
                        Value = 8,
                        SectionWidth = 4,
                        Fill = new SolidColorBrush
                        {
                            //Color=Colors.White,
                            Color = System.Windows.Media.Color.FromRgb(163, 234, 228),
                            Opacity = .4
                        }
                    },
                    //bad 영역
                    new AxisSection
                    {
                        //Label = "Bad",
                        Value = 0,
                        SectionWidth = 8,
                        Fill = new SolidColorBrush
                        {
                            Color = System.Windows.Media.Color.FromRgb(254,132,132),
                            Opacity = .4
                        }
                    }
                }
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "9시", "10시", "11시", "12시", "13시" } //마우스 가까이댔을때 뜨는 라벨
            });

            Panel.SetZIndex(barSeries, 0);
            //Panel.SetZIndex(lineSeries, 1);
        }


        private void X_Click(object sender, EventArgs e)
        {

        }
    }
}