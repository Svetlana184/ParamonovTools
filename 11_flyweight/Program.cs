using _11_flyweight;

TreeTypeFactory _treeTypeFactory = new TreeTypeFactory();
Forest forest = new Forest(_treeTypeFactory);
forest.Add0ak(10, 20, 1.0f);
forest.Add0ak(50, 80, 1.2f);
forest.Add0ak(100, 40, 2.0f);
forest.Render();
