using System;

namespace SafariZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string weekdays = Console.ReadLine();

            double sumFuel = fuel * 2.10;
            double sumAndExcourse = sumFuel + 100;
            
            if (weekdays == "Saturday")
            {
                sumAndExcourse = sumAndExcourse * 0.9;
            }
            else if (weekdays == "Sunday")
            {
                sumAndExcourse = sumAndExcourse * 0.8;
            }

            double price = budget - sumAndExcourse;
            double price2 = sumAndExcourse - budget;

            if (budget >= sumAndExcourse)
            {
                Console.WriteLine("Safari time! Money left: {0:f2} lv.",price);
                //if (weekdays == "Saturday")
                //{
                //    sumAndExcourse = sumAndExcourse * 0.8;
                //    Console.WriteLine($"Safari time! Money left: {price:f2} lv.");
                //}
                //else if (weekdays == "Sunday")
                //{
                //    sumAndExcourse = sumAndExcourse * 0.9;
                //    Console.WriteLine($"Safari time! Money left: {price:f2} lv.");
                //}
                //else
                //{
                //    sumAndExcourse = sumAndExcourse * 1;
                //    Console.WriteLine($"Safari time! Money left: {price:f2} lv.");
                //}
            }
            else
            {
                Console.WriteLine("Not enough money! Money needed: {0:f2} lv.",price2);
            }
            



        }
    }
}
