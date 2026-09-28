OldPaymentSystem oldSystem = new OldPaymentSystem();

IPayment payment = new OldPaymentAdapter(oldSystem);

payment.Pay(1500);


interface IPayment 
{ 
    void Pay(double amount); 
}

class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Оплата налом: " + amount + " рублей");
    }
}

class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Оплата картой: " + amount + " рублей");
    }
}

class OldPaymentSystem 
{ 
    public void MakeTransaction(double money) 
    { 
        Console.WriteLine("Старая система обработала платёж: " + money); 
    } 
}

class OldPaymentAdapter : IPayment
{
    private OldPaymentSystem oldPaymentSystem;
    public OldPaymentAdapter(OldPaymentSystem oldPaymentSystem)
    {
        this.oldPaymentSystem = oldPaymentSystem;
    }

    public void Pay(double amount)
    {
        oldPaymentSystem.MakeTransaction(amount);
    }
}