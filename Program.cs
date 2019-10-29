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
            Samurai me = new Samurai("Benny Bob");
            me.Attack(Adrien);
            me.Meditate();
            Ninja Nibbles = new Ninja("Mr. Nibbles");
            Nibbles.Attack(me);
        }
    }
}
