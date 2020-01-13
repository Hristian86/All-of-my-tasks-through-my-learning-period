using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4aa_1_DICTIONERY_COUNT_REAL_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var dict = new SortedDictionary<double, int>();


            foreach (var number in numbers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item);
                //Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
