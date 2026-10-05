Computer computer = new Computer();
computer.Start();

class Power
{
    public void TurnOn()
    {
        Console.WriteLine("Power is on");
    }  
}

class CPU
{
    public void Start()
    {
        Console.WriteLine("CPU started");
    }
}

class Memory()
{
    public void Load()
    {
        Console.WriteLine("Memory loading");
    }
}

class Computer
{
    private Power power;
    private CPU cpu;
    private Memory memory;

    public Computer()
    {
        power = new Power();
        cpu = new CPU();
        memory = new Memory();
    }

    public void Start()
    {
        power.TurnOn();
        cpu.Start();
        memory.Load();
        Console.WriteLine("Done.");
    }
}