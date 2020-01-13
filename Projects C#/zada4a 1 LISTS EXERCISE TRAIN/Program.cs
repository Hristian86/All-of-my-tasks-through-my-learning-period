using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_LISTS_EXERCISE_TRAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> listNum = Console.ReadLine().Split().Select(double.Parse).ToList();
            //for (int i = 0; i < listNum.Count - 1; i++)
            //{
            //    if (listNum[i] == listNum[i + 1])
            //    {
            //        listNum[i] += listNum[i + 1];
            //        listNum.RemoveAt(i + 1);
            //        i--;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", listNum));
            var list1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var result = Math.Max(list1.Count, list2.Count);
            var sumList = new List<int>();
            for (int i = 0; i < result; i++)
            {
                if (i < list1.Count)
                {
                    sumList.Add(list1[i]);
                }
                if (i < list2.Count)
                {
                    sumList.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ",sumList));
        }
    }
}