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
            canvas.Width = 400;
            canvas.Height = 400;

            foxDraw.SetBackgroundColor(Colors.Wheat);

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 0, canvas.Width, 0);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width, 0, canvas.Height, canvas.Height);

            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(0, canvas.Height, canvas.Height, canvas.Height);

            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawLine(0, 0, 0, canvas.Height);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}