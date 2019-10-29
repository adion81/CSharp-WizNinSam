using System;

namespace WizNinSam.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Dexterity = 3;
            Intelligence = 3;
            Strength = 3;
            health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50)
            {
                target.Health = 0;
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{Name} the Samurai just obliterated {target.Name}, taking all the health!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return target.Health;
        }
        public void Meditate()
        {
            health = 200;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("If two pennies are for normal thoughts, then I am a millionaire.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}