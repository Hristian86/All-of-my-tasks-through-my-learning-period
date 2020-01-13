using System;

namespace Zada4a_2_FOR_CIKAL_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            int summary = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                counter += numbers;
                if (summary < numbers)
                {
                    summary = numbers;
                }
            }
            int total = counter - summary;
            if (total == summary)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {summary}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(total-summary)}");
            }
        }
    }
}
