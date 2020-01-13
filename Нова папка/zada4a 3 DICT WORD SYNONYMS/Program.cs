using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_3_DICT_WORD_SYNONYMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //var synonyms = new Dictionary<string, List<string>>();
            //string key = "";
            //string values = "";

            //for (int i = 0; i < number; i++)
            //{
            //    key = Console.ReadLine();
            //    if (!synonyms.ContainsKey(key))
            //    {
            //        synonyms[key] = new List<string>();
            //    }
            //    values = Console.ReadLine();

            //    synonyms[key].Add(values);

            //}

            //foreach (var item in synonyms)
            //{
            //    Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            //}
            var numb = new List<int>() { 11, 12, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
            int count1 = int.MaxValue;
            int numOfIndex = -1;
            int numOfIndex1 = -1;
            for (int i = 0; i < numb.Count; i++)
            {
                if (numb[i] > count)
                {
                    numOfIndex = i; //numb.IndexOf(numb[i]);
                    count = numb[i];
                }
                if (numb[i] < count1)
                {
                    numOfIndex1 = i; //numb.IndexOf(numb[i]);
                    count1 = numb[i];
                }
            }
            Console.WriteLine($"{count} => {numOfIndex}");
            Console.WriteLine($"{count1} => {numOfIndex1}");
        }
    }
}
