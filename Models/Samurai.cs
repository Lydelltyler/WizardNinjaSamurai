using System;

namespace FourthOOP.Models {
    class Samurai : Human {

        public Samurai (string name): base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 200;
            health = 100;
        }

        public int Attack (Samurai target) {
            int dmg = Strength * 5;
            if (target.health <= 50) {
                target.health = 0;
            } else {
                target.health -= dmg;
            }
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public void Meditate() {
            int hp = health;
            health = hp;
        }
    }

}