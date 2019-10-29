using System;
using WizNinSam.Models;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WizNinSam");
            Human Adrien = new Human("Adrien");
            Samurai Benny = new Samurai("Benny Bob");
            Benny.Attack(Adrien);
            Benny.Meditate();
            Ninja Nibbles = new Ninja("Mr. Nibbles");
            Nibbles.Attack(Benny);
            Wizard Walter = new Wizard("Walter Morgan");
            Walter.Attack(Benny);
            Walter.Heal(Adrien);
        }
    }
}
