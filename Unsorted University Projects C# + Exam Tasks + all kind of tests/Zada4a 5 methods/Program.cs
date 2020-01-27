using System;

namespace Zada4a_5_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            Product(order);
        }
        static void Product(string order)
        {
           double countProducts = double.Parse(Console.ReadLine());
            if (order == "coffee")
            {
                double price = 1.50;
                Bill(price, countProducts);
            }
            else if (order == "water")
            {
                double price = 1.00;
                Bill(price, countProducts);
            }
            else if (order == "coke")
            {
                double price = 1.40;
                Bill(price, countProducts);
            }
            else if (order == "snacks")
            {
                double price = 2.00;
                Bill(price, countProducts);
            }
        }
        static void Bill(double price, double countProducts)
        {
            double sum = price * countProducts;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
