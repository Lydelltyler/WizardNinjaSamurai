using System;

namespace FourthOOP.Models
{
    class Ninja : Human
{

    public Ninja(string name): base(name)
    {   
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 175;
        health = 100;
    }

    public int Attack(Ninja target)
    {
        Random rand = new Random();
        int randNum = rand.Next(6);
        int dmg = Dexterity * 5;
        target.health -= dmg;
        if (randNum == 1)
        {
            target.Dexterity -= 10;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} attacked {target.Name} for and extra 10 damage!");
        } else {
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        }
        
        return target.health;
    }

    public void Steal(Ninja target){
        int dmg = 5;
        target.health -= dmg;
        health += dmg;
    }
}

}