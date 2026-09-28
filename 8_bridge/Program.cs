﻿using System;

interface IDevise
{
    void TurnOn();

    void TurnOff();
}

class TV : IDevise
{
    public void TurnOn()
    {
        Console.WriteLine("Телек включен");
    }

    public void TurnOff()
    {
        Console.WriteLine("Телек выключен");
    }
}

class Condicioner : IDevise
{
    public void TurnOn()
    {
        Console.WriteLine("Кондей включен");
    }

    public void TurnOff()
    {
        Console.WriteLine("Кондей выключен");
    }
}

class Colonki : IDevise
{
    public void TurnOn()
    {
        Console.WriteLine("Колонки включен");
    }

    public void TurnOff()
    {
        Console.WriteLine("Колонки выключен");
    }
}

class RemoteControl
{
    protected IDevise devise;

    public RemoteControl(IDevise devise)
    {
        this.devise = devise;
    }

    public void TurnOn()
    {
        devise.TurnOn();
    }

    public void TurnOff()
    {
        devise.TurnOff();
    }
}

class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevise devise)
        :base(devise)
    {

    }

    public void VolumeUp()
    {
        Console.WriteLine("Громкость увеличена");
    }

    public void VolumeDown()
    {
        Console.WriteLine("Громкость уменьшена");
    }
}

class Program
{
    static void Main()
    {
        IDevise tv = new TV();
        RemoteControl tvRemote = 
            new RemoteControl(tv);
        Console.WriteLine("\nТелик");
        tvRemote.TurnOn();
        tvRemote.TurnOff();

        IDevise condei = new Condicioner();
        RemoteControl condeiRemote =
            new RemoteControl(condei);
        Console.WriteLine("\nКондиционер");
        condeiRemote.TurnOn();
        condeiRemote.TurnOff();

        IDevise colonki = new Colonki();
        RemoteControl colonkiRemote =
            new RemoteControl(colonki);
        Console.WriteLine("\nКолонки");
        colonkiRemote.TurnOn();
        colonkiRemote.TurnOff();

        AdvancedRemote advancedRemote = new AdvancedRemote(tv);

        Console.WriteLine("\n Продвинутый пульт для телика");
        advancedRemote.TurnOn();
        advancedRemote.TurnOff();
        advancedRemote.VolumeUp();
        advancedRemote.VolumeDown();

    }
}
