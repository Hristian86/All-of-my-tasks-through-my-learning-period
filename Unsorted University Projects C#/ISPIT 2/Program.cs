using System;
using System.Collections.Generic;
using System.Linq;

namespace ISPIT_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;


            if (city == "Cairo")
            {
                price = (nights * (250 * 2)) + 600;
            }
            if (city == "Paris")
            {
                price = (nights * (150 * 2)) + 350;
            }
            if (city == "Lima")
            {
                price = (nights * (400 * 2)) + 850;
            }
            if (city == "New York")
            {
                price = (nights * (300 * 2)) + 650;
            }
            if (city == "Tokyo")
            {
                price = (nights * (350 * 2)) + 700;
            }
            if (nights <= 4)
            {
                if (city == "New York" || city == "Cairo")
                {
                    price *= 0.97;
                }
            }
            else if (nights >= 5 && nights <= 9)
            {
                if (city == "New York" || city == "Cairo")
                {
                    price *= 0.95;
                }
                if (city == "Paris")
                {
                    price *= 0.93;
                }
            }
            else if(nights >= 10 && nights <= 24)
            {
                if (city == "Cairo")
                {
                    price *= 0.90;
                }
                if (city == "Paris" || city == "New York" || city == "Tokyo")
                {
                    price *= 0.88;
                }
            }
            else if (nights >= 25 && nights <= 49)
            {
                if (city == "Cairo" || city == "Tokyo")
                {
                    price *= 0.83;
                }
                if (city == "New York" || city == "Lima")
                {
                    price *= 0.81;
                }
                if (city == "Paris")
                {
                    price *= 0.78;
                }
            }
            else if (nights >= 50)
            {
                price *= 0.70;
            }
            if (budget >= price)
            {
                double result = budget - price;
                Console.WriteLine($"Yes! You have {result:f2} leva left.");
            }
            else if (price > budget)
            {
                double result2 = Math.Abs(price - budget);
                Console.WriteLine($"Not enough money! You need {result2:f2} leva.");
            }
            Console.WriteLine(price);
        }
    }
}
