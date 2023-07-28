
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassignment18
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Google Pixel6A");
            Laptop laptop = new Laptop("Acer Swift 3");

            smartphone.Connect();
            smartphone.Charge(92);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            laptop.Connect();
            laptop.Charge(84);
            Console.WriteLine(laptop.Display());

            Console.ReadKey();
        }
    }
}