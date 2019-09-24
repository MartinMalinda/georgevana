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

            foxDraw.SetBackgroundColor(Colors.Wheat);

            var colors = new List<Color>
            {
                Colors.Red,
                Colors.Blue,
                Colors.Yellow,
                Colors.Pink,
                Colors.Black
            };

            var colorindex = 0;

            for (int i = 10; i < 180; i += 30)
            {
                foxDraw.SetFillColor(colors[colorindex]);
                foxDraw.DrawRectangle(i, 0, 20, 20);
                colorindex++;
                if (colorindex == colors.Count)
                {
                    colorindex = 0;
                }
            }
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