using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_5_LIST_REMOVE_NEGATIVE_AND_REVERSE
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersAsList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            numbersAsList.Reverse();
            numbersAsList.RemoveAll(x => x < 0);
            //for (int i = 0; i < numbersAsList.Count; i++)
            //{
            //    //if (numbersAsList[i] < 0)
            //    //{
            //    //    numbersAsList.RemoveAt(i);
            //    //}
                
            //}
            if (numbersAsList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbersAsList));
            }
        }
    }
}
