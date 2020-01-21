using System;

namespace DIVADE_WHITOUT_REMAINER_FOR_CIKAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            double second = 0;
            double triple = 0;
            double quadriple = 0;


            for (int i = 0; i < number; i++)
            {

                    double numbers = double.Parse(Console.ReadLine());
                    count++;
                    if (numbers % 2 == 0)
                    {
                        second++;
                    }
                    if (numbers % 3 == 0)
                    {
                        triple++;
                    }
                    if (numbers % 4 == 0)
                    {
                        quadriple++;
                    }
                
            }


            double sum1 = (triple / number) * 100;
            double sum = (second / number) * 100;
            double sum2 = (quadriple / number) * 100;
            Console.WriteLine($"{sum:f2}%");
            Console.WriteLine($"{sum1:f2}%");
            Console.WriteLine($"{sum2:f2}%");
        }
    }
}
