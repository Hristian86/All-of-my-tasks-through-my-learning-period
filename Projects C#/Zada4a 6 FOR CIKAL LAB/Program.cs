using System;

namespace Zada4a_6_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int summary1 = int.MinValue;
            int summary2 = int.MaxValue;
            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < summary2)
                {
                    summary2 = numbers;
                }
                if (numbers > summary1)
                {
                    summary1 = numbers;
                }
            }
            Console.WriteLine($"Max number: {summary1}");
            Console.WriteLine($"Min number: {summary2}");
        }
    }
}
