using System.Threading;

Console.WriteLine("=============== RPG GAME ===============");
Character warrior = new Warriror("Warrior Bob", new PhysicalAttack());
warrior.UseAbility();
warrior.ability = new FireAttack();
warrior.UseAbility();

Character mage = new Mage("Mage Rick", new FireAttack());
mage.UseAbility();
mage.ability = new IceAttack();
mage.UseAbility();

Character archer = new Archer("Archer Sam", new PhysicalAttack());
archer.UseAbility();
archer.ability = new IceAttack();
archer.UseAbility();

interface IAbility 
{ 
    void Use(string characterName); 
}
class PhysicalAttack : IAbility
{
    public void Use(string characterName)
    {
        Console.WriteLine(characterName + " uses physical attack!");
    }
}
class FireAttack : IAbility
{
    public void Use(string characterName)
    {
        Console.WriteLine(characterName + " uses fire attack!");
    }
}
class IceAttack : IAbility
{
    public void Use(string characterName)
    {
        Console.WriteLine(characterName + " uses ice attack!");
    }
}

abstract class Character
{
    public IAbility ability;
    public abstract void UseAbility();
}
class Warriror : Character
{
    public string Name;
    public Warriror(string characerName, IAbility ability)
    {
        this.Name = characerName;
        this.ability = ability;
    }
    public override void UseAbility()
    {
        this.ability.Use(Name);
    }
}
class Mage : Character
{
    public string Name;
    public Mage(string characerName, IAbility ability)
    {
        this.Name = characerName;
        this.ability = ability;
    }
    public override void UseAbility()
    {
        this.ability.Use(Name);
    }
}
class Archer : Character
{
    public string Name;
    public Archer(string characerName, IAbility ability)
    {
        this.Name = characerName;
        this.ability = ability;
    }
    public override void UseAbility()
    {
        this.ability.Use(Name);
    }
}