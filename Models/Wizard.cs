using System;
namespace WizNinSam.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{Name} casted a magical spell on {target.Name} for {dmg} health!");
            Console.ResetColor();
            return target.Health;
        }
        public void Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{Name} casted a magical spell on {target.Name} for {heal} health!");
            Console.ResetColor();

        }
    }
}