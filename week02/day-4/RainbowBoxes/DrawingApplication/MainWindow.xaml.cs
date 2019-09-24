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

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            foxDraw.SetBackgroundColor(Colors.Wheat);

            var colors = new List<Color>
            {
                Colors.Red,
                Colors.Orange,
                Colors.Yellow,
                Colors.Green,
                Colors.Blue,
                Colors.Indigo,
                Colors.Violet
            };

            var colorindex = 0;

            double squaresize = Height;
            for (int i = 0; i < colors.Count; i++)
            {
                MasterSquare(foxDraw, squaresize, colors[colorindex]);
                squaresize -= Height / colors.Count;
                colorindex++;
                if (colorindex == colors.Count)
                {
                    colorindex = 0;
                }
            }
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