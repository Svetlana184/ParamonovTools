using System;
using System.Collections.Generic;
using System.Text;

namespace _11_flyweight
{
    public class TreeType
    {
        public string Name { get; }
        public string Texture { get; }
        public string Model { get; }

        public TreeType(string name, string texture, string model)
        {
            this.Name = name;
            this.Texture = texture;
            this.Model = model;
        }
    }
}
