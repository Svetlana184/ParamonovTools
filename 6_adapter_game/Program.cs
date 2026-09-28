﻿using System;

interface IWeapon //Интерфейс для игрока и ему не нужно знать какой класс
{
    void Attack();
}

class Sword : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Игрок атакует мечом !!!");
    }
}

class Gun : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Игрок атакует пистолетом !!!");
    }
}

class MagicStaff // Представим что оружие из другой библиотеки и она уже не имеет Attack а имеет CastSpell
{
    public void CastSpell()
    {
        Console.WriteLine("Выпускаю заклинание");
    }
}

class MagicStaffAdapter : IWeapon
{
    private MagicStaff magicStaff;

    public MagicStaffAdapter(MagicStaff magicStaff)
    {
        this.magicStaff = magicStaff;
    }

    public void Attack() 
    {
        magicStaff.CastSpell();
    }
}

class Player
{
    private string name;
    public Player(string name)
    {
        this.name = name;
    }

    public void UseWeapon(IWeapon weapon)
    {
        Console.WriteLine("\n" + name + "Использовал оружие");
        weapon.Attack();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Игра началась");
        Player player = new Player("Дубинин");

        Sword sword = new Sword();
        player.UseWeapon(sword);

        Gun gun = new Gun();
        player.UseWeapon(gun);

        MagicStaff magicStaff = new MagicStaff();
        IWeapon adaptedMagicStaff = new MagicStaffAdapter(magicStaff);
        player.UseWeapon(adaptedMagicStaff);

        Console.WriteLine("\nИгра завершена !");
    }

}
