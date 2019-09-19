using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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

            for (int i = 0; i < 100; i+=20)
            {
                DrawCenteredLine(foxDraw, i, 0);
            }
        }

        public void DrawCenteredLine(FoxDraw foxDraw, double x1, double y1)
        {
            
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(x1, y1, Width / 2, Height / 2);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}