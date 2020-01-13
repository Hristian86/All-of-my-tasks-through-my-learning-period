using System;

namespace Zada4a_7_VLOJEN_IF_STATE
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double price = 0;
            if (number >= 0)
            {
                if (name == "Sofia")
                {
                    if (number >= 0 && number <= 500)
                    {
                        price = number * 0.05;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        price = number * 0.07;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        price = number * 0.08;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 10000)
                    {
                        price = number * 0.12;
                        Console.WriteLine($"{price:f2}");
                    }
                }
                else if (name == "Varna")
                {
                    if (number >= 0 && number <= 500)
                    {
                        price = number * 0.045;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        price = number * 0.075;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        price = number * 0.1;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 10000)
                    {
                        price = number * 0.13;
                        Console.WriteLine($"{price:f2}");
                    }
                }
                else if (name == "Plovdiv")
                {
                    if (number >= 0 && number <= 500)
                    {
                        price = number * 0.055;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 500 && number <= 1000)
                    {
                        price = number * 0.08;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 1000 && number <= 10000)
                    {
                        price = number * 0.12;
                        Console.WriteLine($"{price:f2}");
                    }
                    else if (number > 10000)
                    {
                        price = number * 0.145;
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
