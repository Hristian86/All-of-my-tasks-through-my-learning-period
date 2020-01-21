using System;

namespace Zada4a_5_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int summary = int.MinValue;

            while (count < number)
            {
                int numbers = int.Parse(Console.ReadLine());
                count++;
                if (numbers > summary)
                {
                    summary = numbers;
                }
                //Console.WriteLine(numbers);
            }
            Console.WriteLine(summary);

        }
    }
}
