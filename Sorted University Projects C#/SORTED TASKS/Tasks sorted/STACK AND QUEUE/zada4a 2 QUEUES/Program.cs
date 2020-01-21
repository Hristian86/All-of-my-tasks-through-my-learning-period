using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_QUEUES
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();

            int num = int.Parse(Console.ReadLine());
            
            Queue<string> que = new Queue<string>(text);
            while (que.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    que.Enqueue(que.Dequeue());
                }
                Console.WriteLine($"Removed {que.Dequeue()}");
            }
            Console.WriteLine($"Last is {que.Dequeue()}");
        }
    }
}