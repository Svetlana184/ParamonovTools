Character character = new Character();
character.Attack = 3;
character.Name = "bob";
character.Health = 10;

Character new_char = character.Clone();
new_char.Health = 15;
new_char.Name = "t";

Console.WriteLine($"Персонаж - имя {character.Name}, здоровье {character.Health}, сила {character.Attack}");

Console.WriteLine($"Враг - имя {new_char.Name}, здоровье {new_char.Health}, сила {new_char.Attack}");

class Character
{
    public string? Name;
    public int Health;
    public int Attack;

    public Character Clone()
    {
        Character copyChar = new Character();
        copyChar.Name = this.Name;
        copyChar.Health = this.Health;
        copyChar.Attack = this.Attack;
        return copyChar;
    }
}
