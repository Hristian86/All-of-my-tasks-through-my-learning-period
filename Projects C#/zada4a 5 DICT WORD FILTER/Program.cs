using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_5_DICT_WORD_FILTER
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            var dict = new Dictionary<string,int>();
            int count = 0;
            foreach (var word in words)
            {
                string temp = word;
                if (temp.Length % 2 == 0)
                {
                    count++;
                    dict[temp] = count;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
