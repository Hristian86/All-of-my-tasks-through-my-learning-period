using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_LIST_GUESS_TRIK
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            for (int i = 0; i < list1.Count / 2; i++)
            {
                list1[i] += list1[list1.Count - 1];
                list1.RemoveAt(list1.Count - 1);
            }
            Console.WriteLine(string.Join(" ",list1));
        }
    }
}
