using System;

namespace Zada4a_6_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int symmary = int.MaxValue;

            while (count < number)
            {
                int numbers = int.Parse(Console.ReadLine());
                count++;
                if (numbers < symmary)
                {
                    symmary = numbers;
                }
            }
            Console.WriteLine(symmary);

        }
    }
}
