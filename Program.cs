using System;
using FourthOOP.Models;

namespace FourthOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai sam1 = new Samurai("Lydel-Samurai");
            Samurai sam2 = new Samurai("Tyree-Samurai");
            Wizard wiz1 = new Wizard("Lydell-Wizard");
            sam1.Attack(wiz1);
            Console.WriteLine(wiz1.Health);
            Console.WriteLine("Starting");
        }
    }
}
