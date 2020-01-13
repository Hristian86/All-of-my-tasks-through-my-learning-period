using System;

namespace DancingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double sum1 = count * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double sum2 = count * (lenght / 2) * (lenght / 2);

            double sum3 = sum1 * 7 + sum2 * 9;
            double sum4 = sum3 * 1.85;
            Console.WriteLine($"{sum3:f2}" + " USD");
            Console.WriteLine($"{sum4:f2}" + " BGN");
        }
    }
}
