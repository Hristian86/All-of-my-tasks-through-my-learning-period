using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_ARREYS_EXERCISE_COMMN_ELEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split(' ');
            string[] secondRow = Console.ReadLine().Split(' ');
            string sum = "";
            string sum1 = "";
            for (int i = 0; i < firstRow.Length; i++)
            {
                for (int j = 0; j < secondRow.Length; j++)
                {
                    if (secondRow[j] == firstRow[i])
                    {
                        sum += secondRow[j]+(" ");
                        //Console.Write("{0} ", secondRow[j]);
                    }
                }
            }
            Console.WriteLine(sum + " ");
        }
    }
}
