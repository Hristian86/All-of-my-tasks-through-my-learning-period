using System;

namespace laguedgetax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string priority = Console.ReadLine();
            int volume = width * hight * lenght;
            double price = 0;

            
            if (volume >= 50 && volume <= 100)
            {
                if ("false" == priority)
                {
                    price = 25;
                }
            }
            else if (volume <= 200 && volume >= 100)
            {
                if ("true" == priority)
                {
                    price = 10;
                }
                else
                {
                    price = 50;
                }
            }
            else if (volume <= 300 && volume >= 200)
            {
                if ("true" == priority)
                {
                    price = 20;
                }
                else
                {
                    price = 100;
                }
            }
            Console.WriteLine($"Luggage tax: {price:f2}");


        }
    }
}
