using System;

namespace Zada4a_7_FOR_CIKAL_LAB
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
                sum1 += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
