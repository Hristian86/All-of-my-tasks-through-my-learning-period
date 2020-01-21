using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_STACK_AND_QUEUE_EXERSICE
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>(input);
            //int sum = 0;
            //int orderLeft = -1;
            int bigestOrder = que.Max();

            while (que.Count > 0)
            {
                int temp = que.Peek();
                if (budget >= temp)
                {
                    budget -= que.Dequeue();
                }
                else if (budget < temp)
                {
                    //orderLeft = que.Dequeue();
                    break;
                }
            }
            Console.WriteLine(bigestOrder);
            if (que.Count != 0)
            {
                Console.Write($"Orders left:");
                while (que.Count != 0)
                {
                    Console.Write($" {que.Dequeue()}");
                }
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}