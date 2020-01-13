using System;

namespace ISPIT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double price = 0;

            while (!(input == "closed"))
            {
                
                if (input == "haircut")
                {
                    string gender = Console.ReadLine();
                    if (gender == "mens")
                    {
                        price += 15;
                    }
                    else if (gender == "ladies")
                    {
                        price += 20;
                    }
                    else if (gender == "kids")
                    {
                        price += 10;
                    }
                }
                if (input == "color")
                {
                    string color = Console.ReadLine();
                    if (color == "touch up")
                    {
                        price += 20;
                    }
                    else if (color == "full color")
                    {
                        price += 30;
                    }
                }

                if (target <= price)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            if (price < target)
            {
                double result = Math.Abs(price - target);
                Console.WriteLine($"Target not reached! You need {result}lv. more.");
                Console.WriteLine($"Earned money: {price}lv.");
            }
            if (price >= target)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {price}lv.");
            }


        }
    }
}