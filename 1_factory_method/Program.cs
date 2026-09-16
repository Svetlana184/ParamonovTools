using System;

interface ITransport
{
    void Move();
}

class Car : ITransport
{
    public void Move()
    {
        Console.WriteLine("Машинка катится по дороге");
    }
}

class Plane : ITransport
{
    public void Move()
    {
        Console.WriteLine("Самолет летит !");
    }
}

class TransportFactory
{
    public ITransport CreateTransport(string type)
    {
        switch (type)
        {
            case "car":
                return new Car();

            case "plane":
                return new Plane();

            default:
                throw new ArgumentException("Не знаю такого транспорта");
        }
    }
}

class Program
{
    static void Main()
    {
        TransportFactory factory = new TransportFactory();

        ITransport transport1 = factory.CreateTransport("car");
        transport1.Move();
    }
}
