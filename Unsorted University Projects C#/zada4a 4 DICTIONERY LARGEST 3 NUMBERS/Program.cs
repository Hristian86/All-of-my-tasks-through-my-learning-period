using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_DICTIONERY_LARGEST_3_NUMBERS
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numberses = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = numberses.OrderByDescending(x => x).ToArray();
            var dict = new Dictionary<int, int>();
            int count = 0;

            Adding(numbers, count, dict);
        }
        static void Adding(int[] numbers, int count, Dictionary<int, int> dict)
        {
            int counter = 0;
            foreach (var item in numbers)
            {
                count++;
                dict[count] = item;
            }
            if (numbers.Length <= 2)
            {
                foreach (var item in dict)
                {
                    Console.Write($"{item.Value} ");
                }
            }
            else
            {
                foreach (var item in dict)
                {
                    Console.Write($"{item.Value} ");
                    counter++;
                    if (counter == 3)
                    {
                        break;
                    }
                }
            }
        }
    }
}