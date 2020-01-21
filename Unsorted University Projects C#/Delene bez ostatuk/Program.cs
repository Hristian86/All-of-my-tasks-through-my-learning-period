using System;

namespace Delene_bez_ostatuk
{
    class Program
    {
        static void Main()
        {

            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (city == "Sofia")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.50;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "water")
                {
                    price = quantity * 0.80;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.20;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.45;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.60;
                    Console.WriteLine($"{price:F4}");
                }
            }
            else if (city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.40;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.15;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.30;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.50;
                    Console.WriteLine($"{price:F4}");
                }
            }
            else 
            {
                if (productName == "coffee")
                {
                    price = quantity * 0.45;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "water")
                {
                    price = quantity * 0.70;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "beer")
                {
                    price = quantity * 1.10;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "sweets")
                {
                    price = quantity * 1.35;
                    Console.WriteLine($"{price:F4}");
                }
                else if (productName == "peanuts")
                {
                    price = quantity * 1.55;
                    Console.WriteLine($"{price:F4}");
                }
            }
            






        }


    }
}

