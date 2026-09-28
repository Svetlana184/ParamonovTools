ICoffee coffee1 = new Coffee();
coffee1 = new MilkDecorator(coffee1);
coffee1 = new SugarDecorator(coffee1);
Console.WriteLine(coffee1.GetDescription());
Console.WriteLine(coffee1.GetCost());


interface ICoffee
{
    string GetDescription();
    double GetCost();
}

class Coffee : ICoffee
{
    public string GetDescription()
    {
        return "Espresso";
    }

    public double GetCost()
    {
        return 120;
    }
}

class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return coffee.GetCost();
    }
}

class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", sugar";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 30;
    }
}

class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", milk";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 100;
    }
}

class SyrupDecorator : CoffeeDecorator
{
    public SyrupDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return coffee.GetDescription() + ", syrup";
    }

    public override double GetCost()
    {
        return coffee.GetCost() + 50;
    }
}