using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_DICTIONERY_ODD_OCURENCE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            
            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (dict.ContainsKey(wordToLower))
                {
                    dict[wordToLower]++;
                }
                else
                {
                    dict[wordToLower] = 1;
                }
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
