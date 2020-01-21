using System;

namespace test12345
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            

            int countProd = 0;
            int productBouth = 0;
            double totalProductCost = 0;

            while (input == "Stop")
            {

                double price = double.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                countProd++;
                if (countProd == 3)
                {
                    price *= 0.5;
                }
                if (budget < price)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine("You need {0:f2}",price-budget);
                }
                productBouth++;
                totalProductCost += price;
                budget -= price;
                input = Console.ReadLine();

            }
            if (budget >= )
            {

            }
            Console.WriteLine($"You bought {countProd} products for {totalProductCost:f2} leva.");




        }
    }
}
