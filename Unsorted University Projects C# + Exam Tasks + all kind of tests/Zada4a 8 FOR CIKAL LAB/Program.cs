using System;

namespace Zada4a_8_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += numbers;
                }
                if (i % 2 == 1)
                {
                    sum2 += numbers;
                }
            }
            int sum = Math.Abs(sum1 - sum2);
            if (sum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+sum1);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+sum);
            }
        }
    }
}
