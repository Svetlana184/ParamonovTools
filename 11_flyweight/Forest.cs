using System;
using System.Collections.Generic;
using System.Text;

namespace _11_flyweight
{
    public class Forest
    {
        private readonly TreeTypeFactory _factory;
        private readonly List<Tree> trees= new List<Tree>();

        public Forest(TreeTypeFactory factory)
        {
            _factory = factory;
        }
        public void Add0ak(float x, float y, float scale)
        {
            TreeType oak = _factory.GetTreeType("0ak", "base", "0ak.png");
            Tree tree = new Tree(oak, x, y, scale);
            trees.Add(tree);
        }
        public void Render()
        {
            foreach (Tree t in trees)
            {
                t.Render();
            }
        }
    }
}
