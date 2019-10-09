using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie_set
{
    public class Sharpie
    {
        public string Color { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; }

        public Sharpie(string color, double width)
        {
            this.Color = color;
            this.Width = width;
            this.InkAmount = 100;
            
        }

        public void Use()
        {
            InkAmount -= 100;
        }
    }
}
