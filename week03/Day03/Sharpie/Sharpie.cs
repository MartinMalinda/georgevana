using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    public class Sharpie
    {
        public string Color { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; } = 100;

        public Sharpie(string color, double width)
        {
            this.Color = color;
            this.Width = width;
        }

        public void Use()
        {
            InkAmount--;
        }
    }
}
