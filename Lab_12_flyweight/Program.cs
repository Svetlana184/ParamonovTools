using Lab_12_flyweight.Factories;
using Lab_12_flyweight.Services;
using Lab_12_flyweight.Models;

MarkerStyleFactory factory = new MarkerStyleFactory();
MapService map = new MapService(factory);

map.AddPharmacy("улица 1", "222", "333");
map.AddPharmacy("улица 2", "222", "333");
map.AddPharmacy("улица 3", "222", "333");
map.AddPharmacy("улица 4", "222", "333");
map.AddPharmacy("улица 5", "222", "333");

map.AddCafe("улица 1", "222", "333");
map.AddCafe("улица 2", "222", "333");
map.AddCafe("улица 3", "222", "333");
map.AddCafe("улица 4", "222", "333");
map.AddCafe("улица 5", "222", "333");

map.AddHospital("улица 1", "222", "333");
map.AddHospital("улица 2", "222", "333");
map.AddHospital("улица 3", "222", "333");

map.AddGasStation("улица 1", "222", "333");
map.AddGasStation("улица 1", "222", "333");
map.AddGasStation("улица 1", "222", "333");

map.DisplayMap();

MarkerStyle style1 = factory.GetMarkerStyle("офис", "office.png", "green");
MarkerStyle style2 = factory.GetMarkerStyle("офис", "office.png", "green");
Console.WriteLine(ReferenceEquals(style1, style2));