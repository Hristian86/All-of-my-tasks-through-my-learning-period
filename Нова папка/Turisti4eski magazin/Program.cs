using System;

namespace Turisti4eski_magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int count = 0;
            double pricePerEachItem = 0;
            double totalPricePerEachItem = 0;



            while (true)
            {
                
                string name = Console.ReadLine();
                if (name == "Stop")
                {
                    Console.WriteLine($"You bought {count}          products for {Math.Abs                          (totalPricePerEachItem):f2} leva.");
                    break;
                }
                else
                {
                    pricePerEachItem = double.Parse                 (Console.ReadLine());
                    count++;
                    if (count % 3 == 0)
                    {
                        pricePerEachItem = pricePerEachItem / 2;
                    }
                    else if (pricePerEachItem > budget)
                    {
                        Console.WriteLine("You don't have enough        money!");
                        Console.WriteLine($"You need                    {pricePerEachItem - budget:f2} leva!");
                        break;
                    }
                    
                    totalPricePerEachItem += pricePerEachItem;
                    budget -= pricePerEachItem;

                }
            }
        }
    }
}
