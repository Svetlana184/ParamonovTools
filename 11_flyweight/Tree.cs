using System;
using System.Collections.Generic;
using System.Text;

namespace _11_flyweight
{
    public class Tree
    {
        private readonly TreeType _tree;
        public float x { get; }
        public float y { get; }
        public float scale { get; }

        public Tree(TreeType tree, float x, float y, float scale)
        {
            _tree = tree;
            this.x = x;
            this.y = y;
            this.scale = scale;
        }

        public void Render()
        {
            Console.WriteLine($"Дерево : {_tree.Name}, позиция : {x}, {y}, размер : {scale}");
        }
    }
}
