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

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            foxDraw.SetBackgroundColor(Colors.Wheat);

            int squaresize = 150;
            for (int i = 0; i < 3; i++)
            {
                MasterSquare(foxDraw, squaresize);
                squaresize -= 50;
            }
        }

        public void MasterSquare(FoxDraw foxDraw, double x)
        {
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