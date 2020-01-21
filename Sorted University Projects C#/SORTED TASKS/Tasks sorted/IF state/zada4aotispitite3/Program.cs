using System;

namespace zada4aotispitite3
{
    class Program
    {
        static void Main(string[] args)
        {
            string kruiz = Console.ReadLine();
            string kabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;

            switch (kruiz)
            {
                case "Mediterranean":
                    if (kabin == "standard cabin")
                    {
                        price = nights * 4 * 27.50; // 4 peaple
                    }
                    else if (kabin == "cabin with balcony")
                    {
                        price = nights * 4 * 30.20;
                    }
                    else if (kabin == "apartment")
                    {
                        price = nights * 4 * 40.50;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                case "Adriatic":
                    if (kabin == "standard cabin")
                    {
                        price = nights * 4 * 22.99;
                    }
                    else if (kabin == "cabin with balcony")
                    {
                        price = nights * 4 * 25.00;
                    }
                    else if (kabin == "apartment")
                    {
                        price = nights * 4 * 34.99;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                case "Aegean":
                    if (kabin == "standard cabin")
                    {
                        price = nights * 4 * 23.00;
                    }
                    else if (kabin == "cabin with balcony")
                    {
                        price = nights * 4 * 26.60;
                    }
                    else if (kabin == "apartment")
                    {
                        price = nights * 4 * 39.90;
                    }
                    else
                    {
                        Console.WriteLine("Invalid cabin type!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid cruise!");
                    break;
            }
                    if (nights > 7)
                    {
                        price = 0.75 * price;
                    }
                    Console.WriteLine($"Annie's holiday in the {kruiz} sea costs {price:f2} lv.");

        }
    }
}
