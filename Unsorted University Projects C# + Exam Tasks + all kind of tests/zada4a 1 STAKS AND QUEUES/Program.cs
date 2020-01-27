using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zada4a_1_STAKS_AND_QUEUES
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stak = new Stack<int>(numbers);
            //Console.WriteLine(string.Join(",",stak));

            //int count = 0;
            //string tt = " => ";
            while (true)
            {
                string[] comand = Console.ReadLine().ToLower().Split().ToArray();
                if (comand[0] == "end")
                {
                    break;
                }
                else if (comand[0] == "add")
                {
                    int first = int.Parse(comand[1]);
                    int second = int.Parse(comand[2]);

                    stak.Push(first);
                    stak.Push(second);
                }
                else if (comand[0] == "remove")
                {
                    int removedNums = int.Parse(comand[1]);

                    if (stak.Count < removedNums)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < removedNums; i++)
                        {
                            stak.Pop();
                        }
                    }
                }
            }
            var temp = new StringBuilder();
            int sum = 0;
            while (stak.Count != 0)
            {
                sum += stak.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
