using Lab_12_flyweight.Factories;
using Lab_12_flyweight.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_flyweight.Services
{
    public class MapService
    {
        private readonly MarkerStyleFactory _factory;
        private readonly List<MapMarker> mapMarkers = new List<MapMarker>();

        public MapService(MarkerStyleFactory factory)
        {
            _factory = factory;
        }
        public void AddPharmacy(string address, string latitude, string longitude)
        {
            MarkerStyle style = _factory.GetMarkerStyle("аптека", "pharmacy.png", "green");
            MapMarker mapMarker = new MapMarker(style, address, latitude, longitude);
            mapMarkers.Add(mapMarker);
        }
        public void AddCafe(string address, string latitude, string longitude)
        {
            MarkerStyle style = _factory.GetMarkerStyle("кафе", "cafe.png", "brown");
            MapMarker mapMarker = new MapMarker(style, address, latitude, longitude);
            mapMarkers.Add(mapMarker);
        }
        public void AddShop(string address, string latitude, string longitude)
        {
            MarkerStyle style = _factory.GetMarkerStyle("магазин", "shop.png", "blue");
            MapMarker mapMarker = new MapMarker(style, address, latitude, longitude);
            mapMarkers.Add(mapMarker);
        }
        public void AddHospital(string address, string latitude, string longitude)
        {
            MarkerStyle style = _factory.GetMarkerStyle("больница", "hospital.png", "red");
            MapMarker mapMarker = new MapMarker(style, address, latitude, longitude);
            mapMarkers.Add(mapMarker);
        }
        public void AddGasStation(string address, string latitude, string longitude)
        {
            MarkerStyle style = _factory.GetMarkerStyle("АЗС", "gas_station.png", "black");
            MapMarker mapMarker = new MapMarker(style, address, latitude, longitude);
            mapMarkers.Add(mapMarker);
        }
        
        public void DisplayMap()
        {
            foreach (MapMarker mapMarker in mapMarkers)
            {
                mapMarker.Render();
            }
        }

        public int CountMarkers()
        {
            return mapMarkers.Count;
        }
    }
}
