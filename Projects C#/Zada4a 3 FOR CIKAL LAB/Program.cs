using System;

namespace Zada4a_3_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double oddSum = 0.00;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.00;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;


            for (int i = 1; i <= num; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                
                if (i % 2 == 1)
                {
                    oddSum += numbers;
                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }
                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }
                    
                }
                if (i % 2 == 0)
                {
                    evenSum += numbers;
                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }
                    if (numbers > evenMax)
                    {
                        evenMax = numbers;
                    }
                }
            }
            
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin ==double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
