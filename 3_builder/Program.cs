using System;
class Computer
{
    public string Processor;
    public string VideoCard;
    public int Ram;
    public int Storage;

    public void ShowInfo()
    {
        Console.WriteLine("Компьютер: ");
        Console.WriteLine($"Процессор {Processor}");
        Console.WriteLine($"Видеокарта {VideoCard}");
        Console.WriteLine($"Оперативка {Ram}");
        Console.WriteLine($"Диск {Storage}");
    }
}

class ComputerBuilder
{
    private Computer computer = new Computer();

    public ComputerBuilder SetVideoCard(string VideoCard)
    {
        computer.VideoCard = VideoCard;
        return this;
    }
    public ComputerBuilder SetRam(int Ram)
    {
        computer.Ram = Ram;
        return this;
    }
    public ComputerBuilder SetStorage(int Storage)
    {
        computer.Storage = Storage;
        return this;
    }
    public ComputerBuilder SetProcessor(string Processor)
    {
        computer.Processor = Processor;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder
            .SetProcessor("Intel Core I7")
            .SetVideoCard("RTX 2060 TI")
            .SetRam(32)
            .SetStorage(1)
            .Build();
        computer.ShowInfo();
    }
}
