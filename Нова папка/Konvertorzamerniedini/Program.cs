using System;
using System.Collections.Generic;

namespace Konvertorzamerniedini
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var inmetr = Console.ReadLine();
            var outmetr = Console.ReadLine();

            var currencies = new Dictionary<string, double>()
            {
                {"mm", 1000 },
                {"cm", 100 },
                {"m", 1}
            };
            double result = num / currencies[inmetr] * currencies[outmetr];
            Console.WriteLine($"{result:f3}");
        }
    }
}
