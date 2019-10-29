using System;

namespace WizNinSam.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
            Strength = 3;
            Intelligence = 3;
            health = 100;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Dexterity;
            target.Health -= dmg;
            Console.WriteLine($"{Name} tornado kicked {target.Name} for {dmg} damage");
            Random extraDmg = new Random();
            if(extraDmg.Next(1,101) <= 20)
            {
                target.Health -= 20;
                Console.WriteLine($"{target.Name} got an extra something something in damage from {Name}");
            }
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} snuck in like a bag mammajamma and took 5 heatlh from {target.Name}");
        }
    }
}