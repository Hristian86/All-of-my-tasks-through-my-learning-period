using System;

namespace Zada4a_4_IF_STATE_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            string flovers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            //double sum = 0;
            double price = 0;

            


            if (flovers == "Roses")
            {
                if (count > 80)
                {
                    price = (count * 5) * 0.90;
                }
                else
                {
                    price = count * 5;
                }
            }
            else if (flovers == "Dahlias")
            {
                if (count > 90)
                {
                    price = (count * 3.80) * 0.85;
                }
                else
                {
                    price = count * 3.80;
                }
            }
            else if (flovers == "Tulips")
            {
                if (count > 80)
                {
                    price = (count * 2.80) * 0.85;
                }
                else
                {
                    price = count * 2.80;
                }
            }
            else if (flovers == "Narcissus")
            {
                if (count < 120)
                {
                    price = (count * 3) * 1.15;
                }
                else
                {
                    price = count * 3;
                }
            }
            else if (flovers == "Gladiolus")
            {
                if (count < 80)
                {
                    price = (count * 2.50) * 1.20;
                }
                else
                {
                    price = count * 2.50;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flovers} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }

        }
    }
}