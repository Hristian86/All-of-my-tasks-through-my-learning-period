using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_STACKS_AND_QUEUE_EXERSICE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] options = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int poped = options[1];
            int contains = options[2];
            var stak = new Queue<int>();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < options[0]; i++)
            {
                stak.Enqueue(elements[i]);
            }
            for (int i = 0; i < poped; i++)
            {
                stak.Dequeue();
            }
            if (stak.Contains(contains))
            {
                Console.WriteLine("true");
            }
            else if (stak.Count > 0)
            {
                Console.WriteLine(stak.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
