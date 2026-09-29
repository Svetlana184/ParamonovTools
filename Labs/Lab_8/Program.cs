using System.Threading.Channels;

IUnit warrior = new Warrior();
IUnit warrior2 = new Warrior();
IUnit warrior3 = new Warrior();
Squad squad = new Squad("warrior squad");
squad.Add(warrior);
squad.Add(warrior2);
squad.Add(warrior3);

IUnit mage = new Mage();

Squad squad1 = new Squad("mage squad");
squad1.Add(mage);

Squad squadBig = new Squad("big squad");
squadBig.Add(squad);
squadBig.Add(squad1);
Archer archer = new Archer();
squadBig.Add(archer);

squadBig.Attack();

interface IUnit 
{ 
    void Attack(); 
}
class Warrior : IUnit
{
    public void Attack()
    {
        Console.WriteLine("warrior attacks");
    }
}
class Mage : IUnit
{
    public void Attack()
    {
        Console.WriteLine("mage attacks");
    }
}
class Archer : IUnit
{
    public void Attack()
    {
        Console.WriteLine("archer attacks");
    }
}
class Squad : IUnit
{
    private string name;
    private List<IUnit> items = new List<IUnit>();

    public Squad(string name)
    {
        this.name = name;
    }

    public void Add(IUnit item)
    {
        items.Add(item);
    }

    public void Attack()
    {
        Console.WriteLine("Группа: " + name);
        foreach (IUnit item in items)
        {
            item.Attack();
        }
    }
}