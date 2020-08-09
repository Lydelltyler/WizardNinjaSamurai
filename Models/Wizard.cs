using System;

namespace FourthOOP.Models
{
    class Wizard : Human
{

    public Wizard(string name): base(name)
    {   
        Name = name;
        Strength = 3;
        Intelligence = 25;
        Dexterity = 3;
        health = 50;
    }
     
    public int Attack(Wizard target)
    {
        int dmg = Intelligence * 5;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        target.health += dmg;
        Console.WriteLine($"{Name} healed {dmg} points!");
        return target.health;
    }

    public int Heal(Wizard target){
        int hp = Intelligence * 10;
        target.health += hp;
        Console.WriteLine($"{Name} healed {target.Name} with {dmg} more hp!");
        return target.health;
    }

}

}