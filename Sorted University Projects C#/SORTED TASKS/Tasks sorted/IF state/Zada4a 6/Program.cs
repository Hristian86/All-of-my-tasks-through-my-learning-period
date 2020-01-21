using System;

namespace Zada4a_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;

            if (product == "banana" || product == "apple" || product == "orange" || product == "grapefruit" || product == "kiwi" || product == "pineapple" || product == "grapes")
            {



                if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    if (product == "banana")
                    {
                        price = count * 2.70;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "apple")
                    {
                        price = count * 1.25;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "orange")
                    {
                        price = count * 0.90;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "grapefruit")
                    {
                        price = count * 1.60;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "kiwi")
                    {
                        price = count * 3.00;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "pineapple")
                    {
                        price = count * 5.60;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "grapes")
                    {
                        price = count * 4.20;
                        Console.WriteLine($"{price:f2}");
                    }
                }
                else if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "thursday" || dayOfWeek == "Friday")
                {
                    if (product == "banana")
                    {
                        price = count * 2.50;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "apple")
                    {
                        price = count * 1.20;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "orange")
                    {
                        price = count * 0.85;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "grapefruit")
                    {
                        price = count * 1.45;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "kiwi")
                    {
                        price = count * 2.70;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "pineapple")
                    {
                        price = count * 5.50;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (product == "grapes")
                    {
                        price = count * 3.85;
                        Console.WriteLine($"{price:f2}");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
