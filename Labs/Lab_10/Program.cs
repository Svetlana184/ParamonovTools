interface ICharacter
{
    string GetType();
}

class Warrior : ICharacter
{
    public string GetType()
    {
        return "Warrior";
    }
}

class Mage : ICharacter
{
    public string GetType()
    {
        return "Mage";
    }
}

class Archer : ICharacter
{
    public string GetType()
    {
        return "Archer";
    }
}

interface CharacterFactory
{
    ICharacter CreateCharacter();
}

class WarriorFactory : CharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Warrior();
    }
}

class MageFactory : CharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Mage();
    }
}

class ArcherFactory : CharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Archer();
    }
}

interface IEquipmentFactory
{
    IWeapon CreateWeapon();
    IArmor CreateArmor();
}

interface IWeapon
{

    string GetName();
    int GetDamage();
}

interface IArmor
{
    string GetName();
    int GetDefence();
}

class Sword : IWeapon
{
    public string GetName()
    {
        return "Sword";
    }
    public int GetDamage()
    {
        return 30;
    }
}

class MagicStaff : IWeapon
{
    public string GetName()
    {
        return "Magic staff";
    }
    public int GetDamage()
    {
        return 15;
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
        return 20;
    }
}

class HeavyArmor : IArmor
{
    public string GetName()
    {
        return "Heavy armor";
    }
    public int GetDefence()
    {
        return 30;
    }
}

class Robe : IArmor
{
    public string GetName()
    {
        return "Robe";
    }
    public int GetDefence()
    {
        return 20;
    }
}

class LightArmor : IArmor
{
    public string GetName()
    {
        return "Light armor";
    }
    public int GetDefence()
    {
        return 10;
    }
}

class WarriorEquipmentFactory : IEquipmentFactory
{
    public IWeapon CreateWeapon()
    {
        return new Sword();
    }
    public IArmor CreateArmor()
    {
        return new HeavyArmor();
    }
}

class MageEquipmentFactory : IEquipmentFactory
{
    public IWeapon CreateWeapon()
    {
        return new MagicStaff();
    }
    public IArmor CreateArmor()
    {
        return new Robe();
    }
}

class ArcherEquipmentFactory : IEquipmentFactory
{
    public IWeapon CreateWeapon()
    {
        return new Bow();
    }
    public IArmor CreateArmor()
    {
        return new LightArmor();
    }
}

class Character
{
    public string Name;
    public int Level;
    public int Health;
    public IWeapon Weapon;
    public IArmor Armor;
    public int Attack;
    public void ShowInfo()
    {
        Console.WriteLine("Персонаж: ");
        Console.WriteLine($"Имя {Name}");
        Console.WriteLine($"Здоровье {Health}");
        Console.WriteLine($"Оружие {Weapon.GetName()}");
        Console.WriteLine($"Броня {Armor.GetName()}");
        Console.WriteLine($"Уровень {Level}");
        Console.WriteLine($"Урон {Attack}");
    }
}
class CharacterBuild
{
    private Character character = new Character();

    public CharacterBuild setName(string name)
    {
        character.Name = name;
        return this;
    }
    public CharacterBuild setLevel(int level)
    {
        character.Level = level;
        return this;
    }
    public CharacterBuild setHealth(int health)
    {
        character.Health = health;
        return this;
    }
    public CharacterBuild setAttack(int attack)
    {
        character.Attack = attack;
        return this;
    }
    public CharacterBuild setWeapon(IWeapon weapon)
    {
        character.Weapon = weapon;
        return this;
    }
    public CharacterBuild setArmor(IArmor armor)
    {
        character.Armor = armor;
        return this;
    }
    public Character Build()
    {
        return character;
    }
}
