using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a__7_STACK_AND_QUEUES_HOT_PATETO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split().ToArray();

            int number = int.Parse(Console.ReadLine());

            Queue<string> peps = new Queue<string>(people);

            while (peps.Count != 1)
            {
                    for (int s = 1; s < number; s++)
                    {
                        peps.Enqueue(peps.Dequeue());
                    }
                    Console.WriteLine($"Removed {peps.Dequeue()}");
            }
            Console.WriteLine($"Last is {peps.Dequeue()}");
        }
    }
}