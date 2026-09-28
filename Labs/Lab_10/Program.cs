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

//BUILDER
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
    public Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Name = this.Name;
        copyChar.Health = this.Health;
        copyChar.Attack = this.Attack;
        copyChar.Level = this.Level;
        copyChar.Weapon = this.Weapon;
        copyChar.Armor = this.Armor;
        return copyChar;
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

//SINGLETON
class GameSettings
{
    private static GameSettings instance;
    private GameSettings()
    {

    }

    public static GameSettings GetInstance()
    {
        if (instance == null)
        {
            instance = new GameSettings();
        }
        return instance;
    }

    public void GetInfo()
    {
        Console.WriteLine("MaxLevel " + MaxLevel);
        Console.WriteLine("SoundVolume " + SoundVolume);
        Console.WriteLine("GameName " + GameName);
        Console.WriteLine("Difficulty " + Difficulty);
    }

    public int MaxLevel;
    public int SoundVolume;
    public string GameName;
    public string Difficulty;
}

//BRIDGE
interface IAttack
{
    void Attack(string characterName);
}

class PhysicalAttack : IAttack
{
    public void Attack(string characterName)
    {
        Console.WriteLine(characterName + " наносит физический урон");
    }
}
class MagicAttack : IAttack
{
    public void Attack(string characterName)
    {
        Console.WriteLine(characterName + " наносит магический урон");
    }
}
class RangedAttack : IAttack
{
    public void Attack(string characterName)
    {
        Console.WriteLine(characterName + " наносит урон");
    }
}
class AttackControl
{
    protected IAttack attack;
    public AttackControl(IAttack attack)
    {
        this.attack = attack;
    }
    public void Attack(string characterName)
    {
        attack.Attack(characterName);
    }
}

//COMPOSITE
interface IUnit
{
    void Attack();
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
        Console.WriteLine("Папка: " + name);
        foreach (IUnit item in items)
        {
            item.Attack();
        }
    }
}

//АДАПТЕР
class OldCombatSystem
{
    public void MakeHit(
        string name,
        int power)
    {
        Console.WriteLine(
            name + " наносит удар силой " + power
        );
    }
}
class OldCombatAdapter : IAttack
{
    private OldCombatSystem combatSystem;
    public OldCombatAdapter(OldCombatSystem combatSystem)
    {
        this.combatSystem = combatSystem;
    }

    public void Attack(string characterName)
    {
        combatSystem.MakeHit(characterName, 1);
    }
}

//ДЕКОРАТОРЫ
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