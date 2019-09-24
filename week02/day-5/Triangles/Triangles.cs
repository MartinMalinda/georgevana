using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            Width = Height;
            double numberOfTriangles = 21;
            double sideOfTriangle = Width / numberOfTriangles;
            double heightOfTriangle = (sideOfTriangle * System.Math.Sqrt(3)) / 2;
            for (int i = 0; i <= numberOfTriangles; i++)
            {
            // == lines
            foxDraw.DrawLine(0 + i * sideOfTriangle / 2, Height - i * heightOfTriangle, Width - i * sideOfTriangle / 2, Height - i * heightOfTriangle);
                            
            // // lines
            foxDraw.DrawLine(Width - i * sideOfTriangle, Height, Width - i *sideOfTriangle / 2 , Height - i * heightOfTriangle);

            // \\ lines
            foxDraw.DrawLine(0 + i * sideOfTriangle, Height, 0 + i * sideOfTriangle / 2, Height - i * heightOfTriangle);
            }

        }

        public void DrawEnvelopeStar(FoxDraw foxDraw, double x)
        {
            double lines = x;
            double halfWindow = Height / 2;
            double distance = halfWindow / lines;
            foxDraw.SetStrokeColor(Colors.Lime);
            foxDraw.SetStrokeThicknes(2);
            for (int i = 0; i < lines; i++)
            {
                foxDraw.DrawLine(halfWindow, distance * i, halfWindow + distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, distance * i, halfWindow - distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, Height - distance * i, halfWindow - distance * i, halfWindow);
                foxDraw.DrawLine(halfWindow, Height - distance * i, halfWindow + distance * i, halfWindow);
            }
        }

    public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(10, 10));
            points.Add(new Point(40, 210));
            points.Add(new Point(170, 190));
            points.Add(new Point(130, 40));
            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
        public void MasterSquare(FoxDraw foxDraw, double x, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(Width / 2 - x / 2, Height / 2 - x / 2, x, x);
        }
        public void FiftyFiftySquare(FoxDraw foxDraw, double x1, double y1)
        {
            foxDraw.DrawRectangle(x1, y1, 50, 50);
        }
        public void DrawHorizontalLine(FoxDraw foxDraw, double x1, double y1)
        {
            
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(x1, y1, x1 + 50, y1);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}