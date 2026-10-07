using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_flyweight.Models
{
    public class MapMarker
    {
        private readonly MarkerStyle _style;
        public string address { get; }
        public string latitude { get; }
        public string longitude { get; }

        public MapMarker(MarkerStyle style, string address,  string latitude, string longitude)
        {
            _style = style;
            this.address = address;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public void Render()
        {
            Console.WriteLine($"\nКатегория: {_style.category}, иконка: {_style.icon}, цвет: {_style.color}");
            Console.WriteLine($"Маркер: адрес - {address}, широта: - {latitude}, долгота - {longitude}\n");
        }
    }
}
