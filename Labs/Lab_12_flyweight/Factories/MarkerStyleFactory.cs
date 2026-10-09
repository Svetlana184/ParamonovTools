using Lab_12_flyweight.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_flyweight.Factories
{
    public class MarkerStyleFactory
    {
        private readonly Dictionary<string, MarkerStyle> _markers = new();
        public MarkerStyle GetMarkerStyle(string category, string icon, string color)
        {
            if(_markers.TryGetValue(category, out MarkerStyle? markerStyle))
            {
                return markerStyle;
            }
            MarkerStyle marker = new MarkerStyle(category, icon, color);
            _markers.Add(category, marker);
            return marker;
        }

        public string CountStyles()
        {
            return "Создано стилей: " + _markers.Count();
        }
    }
}
