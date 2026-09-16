Console.WriteLine("=== СБОРКА КОМПЬЮТЕРА === \n1 — Игровой компьютер \n2 — Офисный компьютер \n3 — Бюджетный компьютер \n4 — Собрать самостоятельно");

try
{
    int comp_var = int.Parse(Console.ReadLine()!);
    ComputerDirector computerDirector = new ComputerDirector();
    Computer new_comp = new Computer();
    switch (comp_var)
    {
        case 1:
            new_comp = computerDirector.CreateGamingComputer();
            break;
        case 2:
            new_comp = computerDirector.CreateOfficeComputer();
            break;
        case 3:
            new_comp = computerDirector.CreateBudgetComputer();
            break;
        default:
            Console.WriteLine("введите процессор");
            string processor = Console.ReadLine()!;
            Console.WriteLine("введите видеокарту");
            string videocard = Console.ReadLine()!;
            Console.WriteLine("введите память");
            int ram = int.Parse(Console.ReadLine()!);
            Console.WriteLine("введите накопитель");
            string storage = Console.ReadLine()!;
            Console.WriteLine("введите материнскую плату");
            string motherboard = Console.ReadLine()!;
            Console.WriteLine("введите корпус");
            string casecomp = Console.ReadLine()!;
            Console.WriteLine("введите блок питания");
            string power = Console.ReadLine()!;
            Console.WriteLine("введите операционную систему");
            string os = Console.ReadLine()!;
            
            ComputerBuilder builder = new ComputerBuilder();

            new_comp = builder.SetProcessor(processor).
            SetVideoCard(videocard).
            SetRam(ram).
            SetStorage(storage).
            SetMotherBoard(motherboard).
            SetCase(casecomp).
            SetPowerSupply(power).SetOperatingSystem(os).Build();

            new_comp.ShowInfo();

            break;
    }
}
catch
{
    Console.WriteLine("введите число");
}


class Computer
{
    public string? Processor;
    public string? VideoCard;
    public int Ram;
    public string? Storage;
    public string? MotherBoard;
    public string? Case;
    public string? PowerSupply;
    public string? OperatingSystem;

    public void ShowInfo()
    {
        Console.WriteLine("Компьютер: ");
        Console.WriteLine($"Процессор {Processor}");
        Console.WriteLine($"Видеокарта {VideoCard}");
        Console.WriteLine($"Оперативка {Ram}");
        Console.WriteLine($"Диск {Storage}");
        Console.WriteLine($"Материнская плата {MotherBoard}");
        Console.WriteLine($"Корпус {Case}");
        Console.WriteLine($"Блок питания {PowerSupply}");
        Console.WriteLine($"ОС {OperatingSystem}");
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
    public ComputerBuilder SetStorage(string Storage)
    {
        computer.Storage = Storage;
        return this;
    }
    public ComputerBuilder SetProcessor(string Processor)
    {
        computer.Processor = Processor;
        return this;
    }

    public ComputerBuilder SetMotherBoard(string MotherBoard)
    {
        computer.MotherBoard = MotherBoard;
        return this;
    }

    public ComputerBuilder SetCase(string Case)
    {
        computer.Case = Case;
        return this;
    }

    public ComputerBuilder SetPowerSupply(string PowerSupply)
    {
        computer.PowerSupply = PowerSupply;
        return this;
    }

    public ComputerBuilder SetOperatingSystem(string OperatingSystem)
    {
        computer.OperatingSystem = OperatingSystem;
        return this;
    }

    public Computer Build()
    {
        Console.WriteLine("комп собран!");
        return computer;
    }
}

class ComputerDirector
{
    ComputerBuilder builder = new ComputerBuilder();
    public Computer CreateGamingComputer()
    {
        Computer computer = builder
            .SetProcessor("Intel Core I7")
            .SetVideoCard("RTX 2060 TI")
            .SetRam(32)
            .SetStorage("SSD")
            .SetMotherBoard("NVIDIA RTX")
            .SetCase("игровой корпус")
            .SetOperatingSystem("Windows")
            .Build();
        computer.ShowInfo();
        return computer;
    }
    public Computer CreateOfficeComputer()
    {
        Computer computer = builder
            .SetProcessor("обычный процессор")
            .SetVideoCard("RTX 2060 TI")
            .SetRam(32)
            .SetStorage("SSD")
            .SetMotherBoard("NvIDIA RTX")
            .SetCase("встроенная")
            .SetOperatingSystem("Windows")
            .Build();
        computer.ShowInfo();
        return computer;
    }
    public Computer CreateBudgetComputer()
    {
        Computer computer = builder
            .SetProcessor("дешевый процессор")
            .SetVideoCard("RTX 2060 TI")
            .SetRam(32)
            .SetStorage("SSD")
            .SetMotherBoard("встроенная")
            .SetCase("дешевый корпус")
            .SetOperatingSystem("Linux")
            .Build();
        computer.ShowInfo();
        return computer;
    }
}