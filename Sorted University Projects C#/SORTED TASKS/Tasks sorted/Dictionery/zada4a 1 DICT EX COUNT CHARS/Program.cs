using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_DICT_EX_COUNT_CHARS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ").ToArray();
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                for (int j = 0; j < word.Length; j++)
                {
                    char symb = word[j];
                        if (!dict.ContainsKey(symb))
                        {
                           dict[symb] = 1;
                        }
                        else
                        {
                            dict[symb]++;
                        }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
