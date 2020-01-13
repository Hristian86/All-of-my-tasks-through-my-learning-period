using System;

namespace Exelentresult
{
    class Program
    {
        static void Main(string[] args)
        {
            string tip = Console.ReadLine();

            if (tip == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double sum = lenght * lenght;
                Console.WriteLine($"{sum:f3}");
            }
            else if (tip == "rectangle")
            {
                double len = double.Parse(Console.ReadLine());
                double lengh = double.Parse(Console.ReadLine());
                double sum = len * lengh;
                Console.WriteLine($"{sum:f3}");
            }
            else if (tip == "circle")
            {
                double len = double.Parse(Console.ReadLine());
                double sum = Math.PI * (len * len);
                Console.WriteLine($"{sum:f3}");
            }
            else if (tip == "triangle")
            {
                double len = double.Parse(Console.ReadLine());
                double high = double.Parse(Console.ReadLine());
                double sum = (len * high) / 2.0;
                Console.WriteLine($"{sum:f3}");
            }


        }
    }
}
