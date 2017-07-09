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
        public static UielementsExample uiElement;

        ColumnSeries barSeries;
        ChartValues<double> Values;
       
        public UielementsExample()
        {
            uiElement = this;

            InitializeComponent();

            //var lineSeries = new LineSeries //꺾은선
            //{
            //    Values = new ChartValues<double> { 12, 10, 13, 9, 12 },
            //    Fill = Brushes.Transparent,
            //    StrokeThickness = 3,
            //    PointGeometry = null
            //};
            barSeries = new ColumnSeries //막대그래프
            {
                //Values = new ChartValues<double> { 5, 6, 9, 8, 10 },
                Values = new ChartValues<double> { 0, 0, 0, 0, 0 },
                StrokeThickness = 1.5,
                PointGeometry = null,
                MaxColumnWidth = 25,
                 
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
                X = 0.8,
                Y = 8.5,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "WARNING",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromRgb(208, 54, 0)),
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = 0.5,
                Y = 14,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock //notice this property must be a wpf control
                {
                    Text = "Good",
                    FontWeight = FontWeights.Bold,
                    FontSize = 16,
                    Foreground = new SolidColorBrush(Color.FromRgb(133, 204, 208)),
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
                MinValue = 6,
                MaxValue = 20,
                FontWeight = FontWeights.Bold,
                Sections = new SectionsCollection
                {
                    //warning 점선
                    new AxisSection
                    {
                        Value = 10,
                        //Stroke = Brushes.Crimson,
                        Stroke=new SolidColorBrush(Color.FromRgb(222,111,39)),
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {2d})
                    },
                    //Goog 점선
                    new AxisSection
                    {
                        Value = 14,
                        //Stroke = Brushes.Crimson,
                        Stroke=new SolidColorBrush(Color.FromRgb(1,85,157)),
                        StrokeThickness = 4,
                        StrokeDashArray = new DoubleCollection(new [] {2d})
                    },
                    //good 영역
                        new AxisSection
                    {
                        //Label = "Good",
                        Value = 14,

                        SectionWidth = 6,
                        Fill = new SolidColorBrush
                        {
                            //Color=Colors.White,
                            Color = System.Windows.Media.Color.FromRgb(1,85,157),
                            Opacity = .3
                        }
                    },
                    // normal 영역
                        new AxisSection
                    {
                        //Label = "Good",
                        Value = 10,
                        SectionWidth = 4,
                        Fill = new SolidColorBrush
                        {
                            //Color=Colors.White,
                            Color = System.Windows.Media.Color.FromRgb(0,171,188),
                            Opacity = .2
                        }
                    },
                    //bad 영역
                    new AxisSection
                    {
                        //Label = "Bad",
                        Value = 0,
                        SectionWidth = 10,
                        Fill = new SolidColorBrush
                        {
                            Color = System.Windows.Media.Color.FromRgb(234,168,101),
                            Opacity = .4
                        }
                    }
                }
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                FontWeight = FontWeights.Bold,
                Labels = new[] { "9시", "10시", "11시", "12시", "13시","14시","15시","16시" } //마우스 가까이댔을때 뜨는 라벨
               
            });
            Panel.SetZIndex(barSeries, 0);
            //Panel.SetZIndex(lineSeries, 1);
        }

        public void updateBlinkBarValue(double aHour, double bHour, double cHour, double dHour, double eHour,
            double fHour, double gHour)
        {
            barSeries.Values = new ChartValues<double> { aHour, bHour, cHour, dHour, eHour,
            fHour, gHour};
        }

    }



}