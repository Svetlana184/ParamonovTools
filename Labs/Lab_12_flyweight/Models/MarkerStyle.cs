using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_flyweight.Models
{
    public class MarkerStyle
    {
        public string category { get; }
        public string icon { get; }
        public string color { get; }

        public MarkerStyle(string category, string icon, string color)
        {
            this.category = category;
            this.icon = icon;
            this.color = color;
        }
    }
}
