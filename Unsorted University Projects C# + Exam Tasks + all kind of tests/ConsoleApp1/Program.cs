using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write($"{count} ");
                    if (count == num)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (count == num)
                {
                    break;
                }
            }
            



        }
    }
}
