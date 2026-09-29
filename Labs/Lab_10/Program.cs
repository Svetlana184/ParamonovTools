//настройки
Console.WriteLine("============= Настройка игры =============");
GameSettings settings = GameSettings.GetInstance();
settings.MaxLevel = 100;
settings.Difficulty = "Normal";
settings.GameName = "RPG GAME";
settings.GetInfo();

//создание персонажа
Console.WriteLine("\n\n============= Создание воина =============");
WarriorFactory warriorFactory = new WarriorFactory();
ICharacter warrior = warriorFactory.CreateCharacter();
Console.WriteLine("Создан персонаж: " + warrior.GetType());

//создание комплекта
Console.WriteLine("\n\n============= Создание комплекта =============");
WarriorEquipmentFactory warriorEquipmentFactory = new WarriorEquipmentFactory();
IWeapon warriorWeapon = warriorEquipmentFactory.CreateWeapon();
IArmor warriorArmor = warriorEquipmentFactory.CreateArmor();
Console.WriteLine("Оружие: " + warriorWeapon.GetName());
Console.WriteLine("Броня: " + warriorArmor.GetName());

//builder
Console.WriteLine("\n\n============= Создание персонажа =============");
CharacterBuilder builder = new CharacterBuilder();
Character character = new CharacterBuilder()
            .setName("Andrei")
            .setLevel(10)
            .setHealth(150)
            .setWeapon(warriorWeapon)
            .setArmor(warriorArmor)
            .setAttack(new PhysicalAttack())
            .setType(warrior)
            .Build();
character.ShowInfo();

//decorator
Console.WriteLine("\n\n============= Бафф оружия =============");
warriorWeapon = new FireDecorator(warriorWeapon);
Console.WriteLine(warriorWeapon.GetName()); 
warriorWeapon = new PoisonDecorator(warriorWeapon);
Console.WriteLine(warriorWeapon.GetName());
warriorWeapon = new CriticalDecorator(warriorWeapon);
Console.WriteLine(warriorWeapon.GetName());
Console.WriteLine("Итоговый урон: " + warriorWeapon.GetDamage());

// Bridge
Console.WriteLine("\n\n============= Разный тип атак =============");
character.Attack.Attack(character.Name);
character.Attack = new MagicAttack();
character.Attack.Attack(character.Name);

//Adapter
Console.WriteLine("\n\n============= Атака через старую систему =============");
OldCombatSystem oldSystem = new OldCombatSystem();
IAttack adapter = new OldCombatAdapter(oldSystem);
adapter.Attack(character.Name);

//Prototype
Console.WriteLine("\n\n============= Клонирование Толика =============");
Character original = new CharacterBuilder()
            .setName("Толик")
            .setLevel(10)
            .setHealth(150)
            .setWeapon(warriorEquipmentFactory.CreateWeapon())
            .setArmor(warriorEquipmentFactory.CreateArmor())
            .setAttack(new PhysicalAttack())
            .Build();
Console.WriteLine("Оригинал:");
original.ShowInfo();

Character clone = original.Clone();
clone.Name = "Толик Clone";
clone.Level = 20;
Console.WriteLine("\nКлон:");
clone.ShowInfo();
Console.WriteLine("\nОригинал после изменения клона:");
original.ShowInfo();

//Composite
Console.WriteLine("\n\n============= Создание армии =============");
ArcherFactory archerFactory = new ArcherFactory();
MageFactory mageFactory = new MageFactory();

Squad army = new Squad("Army");

ICharacter w1 = warriorFactory.CreateCharacter();
ICharacter m1 = archerFactory.CreateCharacter();

Squad squad1 = new Squad("Squad 1");
squad1.Add(warriorFactory.CreateCharacter());
squad1.Add(warriorFactory.CreateCharacter());

Squad squad2 = new Squad("Squad 2");
squad2.Add(mageFactory.CreateCharacter());

army.Add(w1);  
army.Add(m1);
army.Add(squad1);
army.Add(squad2);

army.Attack();


interface ICharacter : IUnit
{
    string GetType();
}

class Warrior : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Воин атакует");
    }
    public string GetType()
    {
        return "Warrior";
    }
}

class Mage : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Маг атакует");
    }
    public string GetType()
    {
        return "Mage";
    }
}

class Archer : ICharacter
{
    public void Attack()
    {
        Console.WriteLine("Лучник атакует");
    }
    public string GetType()
    {
        return "Archer";
    }
}

// ============= CHARACTER FACTORY =============
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

// ============= EQUIPMENT FACTORY =============
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

// ============= PROTOTYPE =============
class Character
{
    public string Name;
    public int Level;
    public int Health;
    public IWeapon Weapon;
    public IArmor Armor;
    public IAttack Attack;
    public ICharacter Type;
    public void ShowInfo()
    {
        Console.WriteLine("Персонаж: ");
        Console.WriteLine($"Имя {Name}");
        Console.WriteLine($"Здоровье {Health}");
        Console.WriteLine($"Оружие {Weapon.GetName()}");
        Console.WriteLine($"Броня {Armor.GetName()}");
        Console.WriteLine($"Уровень {Level}");
        Console.WriteLine($"Урон {Attack}");
        Console.WriteLine($"Класс {Type}");
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
        copyChar.Type = this.Type;
        return copyChar;
    }
}
// ============= BUILDER =============
class CharacterBuilder
{
    private Character character = new Character();

    public CharacterBuilder setName(string name)
    {
        character.Name = name;
        return this;
    }
    public CharacterBuilder setLevel(int level)
    {
        character.Level = level;
        return this;
    }
    public CharacterBuilder setHealth(int health)
    {
        character.Health = health;
        return this;
    }
    public CharacterBuilder setAttack(IAttack attack)
    {
        character.Attack = attack;
        return this;
    }
    public CharacterBuilder setWeapon(IWeapon weapon)
    {
        character.Weapon = weapon;
        return this;
    }
    public CharacterBuilder setArmor(IArmor armor)
    {
        character.Armor = armor;
        return this;
    }
    public CharacterBuilder setType(ICharacter type)
    {
        character.Type = type;
        return this;
    }
    public Character Build()
    {
        return character;
    }
}

// ============= SINGLETON =============
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

// ============= BRIDGE =============
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
        Console.WriteLine(characterName + " наносит урон дистанционно");
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

// ============= COMPOSITE  =============
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
        Console.WriteLine("Группа: " + name);
        foreach (IUnit item in items)
        {
            item.Attack();
        }
    }
}

// ============= АДАПТЕР =============
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

// ============= ДЕКОРАТОРЫ =============
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