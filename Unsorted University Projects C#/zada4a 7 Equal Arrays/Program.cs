using System;
using System.Linq;

namespace MyNamespace
{
    class Program
    {
        static void main(string[] arg)
        {
            int[] numsFirst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numsSecond = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int first = 0;
            int second = 0;
            for (int i = 0; i < numsFirst.Length; i++)
            {
                first = numsFirst[i];
            }
            for (int j = 0; j < numsSecond.Length; j++)
            {
                second = numsSecond[j];
            }
            Console.WriteLine(first +" " + second);
        }
    }
}
