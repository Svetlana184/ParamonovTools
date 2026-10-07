using System;
using System.Collections.Generic;
using System.Text;

namespace _11_flyweight
{
    public class TreeTypeFactory
    {
        private readonly Dictionary<string, TreeType> _types = new();
        public TreeType GetTreeType(string name, string model, string texture)
        {
            if (_types.TryGetValue(name, out TreeType? existingType))
            {
                return existingType;
            }
            TreeType treeType = new TreeType(name, model, texture);
            _types.Add(name, treeType);
            return treeType;
        }
    }
}
