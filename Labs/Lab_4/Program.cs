Character originalCharacter = new Character();
originalCharacter.Name = "Артур";
originalCharacter.Class = "Рыцарь";
originalCharacter.Level = 10;
originalCharacter.Health = 500;
originalCharacter.Damage = 80;
originalCharacter.Speed = 5;
originalCharacter.Weapon = "Меч";
Console.WriteLine("\nOriginal character:");
originalCharacter.ShowInfo();

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



class Character
{
    public string? Name;
    public string? Class;
    public int Level;
    public int Health;
    public int Damage;

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
        Console.WriteLine($"Speed: {this.Speed}");
        Console.WriteLine($"Weapon: {this.Weapon}\n");
    }

    public Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Name = this.Name;
        copyChar.Class = this.Class;
        copyChar.Health = this.Health;
        copyChar.Level = this.Level;
        copyChar.Damage = this.Damage;
        copyChar.Speed = this.Speed;
        copyChar.Weapon = this.Weapon;
        return copyChar;
    }
}
