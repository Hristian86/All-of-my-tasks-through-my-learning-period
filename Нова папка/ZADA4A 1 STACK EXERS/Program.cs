using System;
using System.Linq;
using System.Collections.Generic;

namespace ZADA4A_1_STACK_EXERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] options = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int poped = options[1];
            int contains = options[2];
            Stack<int> stak = new Stack<int>();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < options[0]; i++)
            {
                stak.Push(elements[i]);
            }
            for (int i = 0; i < poped; i++)
            {
                stak.Pop();
            }
            if (stak.Contains(contains))
            {
                Console.WriteLine("true");
            }
            else if(stak.Count > 0)
            {
                Console.WriteLine(stak.Pop());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
