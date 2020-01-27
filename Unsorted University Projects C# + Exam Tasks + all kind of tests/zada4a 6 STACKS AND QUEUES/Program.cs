using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_6_STACKS_AND_QUEUES
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> que = new Queue<int>(numbers);
            Queue<int> que2 = new Queue<int>();

            while (que.Count != 0)
            {
                var temp = que.Dequeue();
                if (temp % 2 == 0)
                {
                    que2.Enqueue(temp);
                }
            }
            Console.WriteLine(string.Join(", ",que2));
        }
    }
}
