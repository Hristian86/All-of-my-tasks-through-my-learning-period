using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace zada4a_8_STACK_AND_QUEUES_TRAFFIC_JAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Queue<string> que = new Queue<string>();

            int count = 0;
            int summary = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                if (command == "green")
                {
                    while (que.Count > 0)
                    {
                        if (summary == number)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{que.Dequeue()} passed!");
                        }
                        count++;
                        summary++;
                    }
                    summary = 0;
                }
                else
                {
                    que.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
