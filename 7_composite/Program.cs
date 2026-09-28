﻿using System;
using System.Collections.Generic;

interface IFileSystemItems
{
    void Show();
}

class File : IFileSystemItems
{
    private string name;
    public File(string name)
    {
        this.name = name;
    }
    public void Show()
    {
        Console.WriteLine("Файл:" + name);
    }
}

class Folder : IFileSystemItems
{
    private string name;
    private List<IFileSystemItems> items = new List<IFileSystemItems>();

    public Folder(string name)
    {
        this.name = name;
    }

    public void Add(IFileSystemItems item)
    {
        items.Add(item);
    }

    public void Show()
    {
        Console.WriteLine("Папка: " + name);
        foreach (IFileSystemItems item in items)
        {
            item.Show();
        }
    }
}

class Program
{
    static void Main()
    {
        File file1 = new File("Документы.dox");
        File file2 = new File("Фото.png");
        File file3 = new File("Program.cs");

        Folder documents = new Folder("Документы");
        documents.Add(file1);
        documents.Add(file2);
        file3.Show();
        documents.Show();
    }
}
