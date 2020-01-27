using System;

namespace FilmovrejisiorIFSTATE
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double countStatics = double.Parse(Console.ReadLine());
            double clothersStatists = double.Parse(Console.ReadLine());

            double fon = budget * 0.1;
            double wearStatists = countStatics * clothersStatists;
            double waerStratis = 0;
            


            if (countStatics >=150)
            {
                waerStratis = wearStatists * 0.9;
            }
            else
            {
                waerStratis = wearStatists * 1;
            }
            double price = fon + waerStratis;
            double total = Math.Abs(budget - price);
            if (price <= budget)
            {       
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {total:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total:f2} leva more.");
            }
        }
    }
}

