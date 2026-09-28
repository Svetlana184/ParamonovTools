IWeapon weapon1 = new Sword();
weapon1 = new FireDecorator(weapon1);
weapon1 = new PoisonDecorator(weapon1);
weapon1 = new CriticalDecorator(weapon1);
Console.WriteLine("Weapon name: " + weapon1.GetName());
Console.WriteLine("Damage: " + weapon1.GetDamage());

interface IWeapon
{
    string GetName();
    int GetDamage();
}

class Sword : IWeapon
{
    public string GetName()
    {
        return "Sword";
    }

    public int GetDamage()
    {
        return 50;
    }
}

class Bow : IWeapon
{
    public string GetName()
    {
        return "Bow";
    }

    public int GetDamage()
    {
        return 40;
    }
}

class Staff : IWeapon
{
    public string GetName()
    {
        return "Staff";
    }

    public int GetDamage()
    {
        return 35;
    }
}

class WeaponDecorator : IWeapon
{
    protected IWeapon weapon;
    public WeaponDecorator(IWeapon weapon)
    {
        this.weapon = weapon;
    }
    public virtual string GetName()
    {
        return weapon.GetName();
    }

    public virtual int GetDamage()
    {
        return weapon.GetDamage();
    }
}

class FireDecorator : WeaponDecorator
{
    public FireDecorator(IWeapon weapon) : base(weapon)
    {
        
    }
    public override string GetName()
    {
        return weapon.GetName() + " with fire";
    }

    public override int GetDamage()
    {
        return weapon.GetDamage() + 20;
    }
}

class PoisonDecorator : WeaponDecorator
{
    public PoisonDecorator(IWeapon weapon) : base(weapon)
    {
        
    }
    public override string GetName()
    {
        return weapon.GetName() + " with poison";
    }

    public override int GetDamage()
    {
        return weapon.GetDamage() + 10;
    }
}

class CriticalDecorator : WeaponDecorator
{
    public CriticalDecorator(IWeapon weapon) : base(weapon)
    {
        
    }
    public override string GetName()
    {
        return weapon.GetName() + " with critical damage";
    }

    public override int GetDamage()
    {
        return weapon.GetDamage() * 2;
    }
}

class VampireDecorator : WeaponDecorator
{
    public VampireDecorator(IWeapon weapon) : base(weapon)
    {
        
    }
    public override string GetName()
    {
        return weapon.GetName() + " with vampire effect";
    }

    public override int GetDamage()
    {
        return weapon.GetDamage() + 15;
    }
}

class DebaffDecorator : WeaponDecorator
{
    public DebaffDecorator(IWeapon weapon) : base(weapon)
    {
        
    }
    public override string GetName()
    {
        return weapon.GetName() + " with debaff";
    }

    public override int GetDamage()
    {
        return weapon.GetDamage() / 2;
    }
}