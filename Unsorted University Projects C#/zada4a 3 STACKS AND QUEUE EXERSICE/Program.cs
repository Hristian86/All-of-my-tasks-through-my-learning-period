using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_3_STACKS_AND_QUEUE_EXERSICE
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (number < 1 || number > 105)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            Stack<long> stak = new Stack<long>();
            for (int i = 0; i < number; i++)
            {
                long[] command = Console.ReadLine().Split().Select(long.Parse).ToArray();

                if (command[0] == 1)
                {
                    if (command[1] > 0 && command[1] <= 109)
                    {
                        stak.Push(command[1]);
                    }
                }
                else if (command[0] == 2)
                {
                    if (stak.Count > 0)
                    {
                        stak.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    Console.WriteLine(stak.Max());
                }
                else if (command[0] == 4)
                {
                    Console.WriteLine(stak.Min());
                }
            }
            if (stak.Count > 0)
            {
            Console.WriteLine(string.Join(", ", stak));
            }
        }
    }
}
