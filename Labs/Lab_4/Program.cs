Character originalCharacter = new Character();
originalCharacter.Name = "Артур";
originalCharacter.Class = "Рыцарь";
originalCharacter.Level = 10;
originalCharacter.Health = 500;
originalCharacter.Armor = 100;
originalCharacter.Damage = 80;
originalCharacter.Speed = 5;
originalCharacter.Weapon = "Меч";
Console.WriteLine("\n============================= Original character =============================\n");
originalCharacter.ShowInfo();


Console.WriteLine("\n============================= Copies =============================\n");
Character newChar1 = originalCharacter.Clone();
newChar1.Level = 10;
newChar1.ShowInfo();

Character newChar2 = originalCharacter.Clone();
newChar2.Level = 15;
newChar2.Health = 500;
newChar2.ShowInfo();

Character newChar3 = originalCharacter.Clone();
newChar3.Level = 20;
newChar3.ShowInfo();

WarriorPrototype warriorPrototype = new WarriorPrototype();
Character warriorChar = warriorPrototype.Clone();
warriorChar.ShowInfo();

Console.WriteLine("============================= СОЗДАНИЕ ПЕРСОНАЖА ============================= \n1 — Создать Воина \n2 — Создать Мага \n3 — Создать Лучника \n4 — Показать прототипы \n0 — Выход ");
int charVar = int.Parse(Console.ReadLine()!);
Character newChar = new Character();
switch (charVar)
{
    case 1:
        WarriorPrototype warriorPrototype1 = new WarriorPrototype();
        newChar = warriorPrototype1.Clone();
        newChar.ShowInfo();
        break;
    case 2:
        WizardPrototype wizardPrototype = new WizardPrototype();
        newChar = wizardPrototype.Clone();
        newChar.ShowInfo();
        break;
    case 3:
        ArcherPrototype archerPrototype = new ArcherPrototype();
        newChar = archerPrototype.Clone();
        newChar.ShowInfo();
        break;
    case 4:
        WarriorPrototype warriorPrototype2 = new WarriorPrototype();
        WizardPrototype wizardPrototype2 = new WizardPrototype();
        ArcherPrototype archerPrototype2 = new ArcherPrototype();
        Character w = warriorPrototype2.Clone();
        w.ShowInfo();
        Character wi = wizardPrototype2.Clone();
        wi.ShowInfo();
        Character ar = archerPrototype2.Clone();
        ar.ShowInfo();
        break;
    default:
        break;
}

class WarriorPrototype : Character
{
    public override Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Class = "warrior";
        copyChar.Health = 500;
        copyChar.Damage = 80;
        copyChar.Speed = 5;
        copyChar.Weapon = "Меч";
        copyChar.Armor = 100;
        return copyChar;
    }
}

class WizardPrototype : Character
{
    public override Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Class = "wizard";
        copyChar.Health = 250;
        copyChar.Damage = 150;
        copyChar.Speed = 7;
        copyChar.Weapon = "Посох";
        copyChar.Armor = 30;
        return copyChar;
    }
}

class ArcherPrototype : Character
{
    public override Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Class = "archer";
        copyChar.Health = 300;
        copyChar.Damage = 100;
        copyChar.Speed = 10;
        copyChar.Weapon = "Лук";
        copyChar.Armor = 50;
        return copyChar;
    }
}

class Character
{
    public string? Name;
    public string? Class;
    public int Level;
    public int Health;
    public int Damage;
    public int Armor;

    public int Speed;

    public string? Weapon;

    public void ShowInfo()
    {
        Console.WriteLine("Character:");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Class: {this.Class}");
        Console.WriteLine($"Level: {this.Level}");
        Console.WriteLine($"Health: {this.Health}");
        Console.WriteLine($"Damage: {this.Damage}");
        Console.WriteLine($"Armor: {this.Armor}");
        Console.WriteLine($"Speed: {this.Speed}");
        Console.WriteLine($"Weapon: {this.Weapon}\n");
    }

    public virtual Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Name = this.Name;
        copyChar.Class = this.Class;
        copyChar.Health = this.Health;
        copyChar.Level = this.Level;
        copyChar.Damage = this.Damage;
        copyChar.Speed = this.Speed;
        copyChar.Weapon = this.Weapon;
        copyChar.Armor = this.Armor;
        return copyChar;
    }
}
