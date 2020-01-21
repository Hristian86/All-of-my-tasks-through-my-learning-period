using System;

namespace Zada4a_5_FOR_CIKAL_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {



            int numbers = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int numberses = int.Parse(Console.ReadLine());
                for (int j = 1; j <= 1000; j++)
                {
                    if (numberses < 200)
                    {
                        p1++; //+= numbers;
                    }
                    else if (numberses >= 200 && numberses < 400)
                    {
                        p2++; //+= numbers;
                    }
                    else if (numberses < 600 && numberses >= 400)
                    {
                        p3++; //+= numbers;
                    }
                    else if (numberses < 800 && numberses >= 600)
                    {
                        p4++; //+= numbers;
                    }
                    else if (numberses <= 1000 && numberses >= 800)
                    {
                        p5++; //+= numbers;
                    }

                }
            }
            double sum1 = (p1 * 0.1) / numbers;
            Console.WriteLine($"{sum1:f2}%");
            double sum2 = (p2 * 0.1) / numbers;
            Console.WriteLine($"{sum2:f2}%");
            double sum3 = (p3 * 0.1) / numbers;
            Console.WriteLine($"{sum3:f2}%");
            double sum4 = (p4 * 0.1) / numbers;
            Console.WriteLine($"{sum4:f2}%");
            double sum5 = (p5 *0.1) / numbers ;
            Console.WriteLine($"{sum5:f2}%");
        }
    }
}
