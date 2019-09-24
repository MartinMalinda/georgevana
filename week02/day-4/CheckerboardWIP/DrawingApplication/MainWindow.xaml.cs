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

            foxDraw.SetBackgroundColor(Colors.White);

            int size = 40;
            int offsetY = 0;
            for (int i = 0; i < Height; i += size)
            {
                for (int j = 40; j < Width; j += size * 2)
                {
                    foxDraw.SetStrokeColor(Colors.Transparent);
                    foxDraw.SetFillColor(Colors.Black);
                    foxDraw.DrawRectangle(j, offsetY, size, size);
                }
                offsetY += size;
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