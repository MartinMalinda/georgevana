using System;
using System.Collections.Generic;
using System.Text;

namespace Post_It
{
    public class PostIt
    {
        public string BackgroundColor { get; set; }
        public string Text { get; set; }
        public string TextColor { get; set; }

        public PostIt(string background, string text, string textColor)
        {
            this.BackgroundColor = background;
            this.Text = text;
            this.TextColor = textColor;
        }
    }
}
