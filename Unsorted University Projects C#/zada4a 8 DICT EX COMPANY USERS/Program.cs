using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_8_DICT_EX_COMPANY_USERS
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comands = Console.ReadLine().Split(" -> ").ToArray();
                string companyName = comands[0];
                if (companyName == "End")
                {
                    break;
                }
                string companyId = comands[1];
                if (!dict.ContainsKey(companyName))
                {
                    dict[companyName] = new List<string>();
                }

                if (!dict[companyName].Contains(companyId))
                {
                    dict[companyName].Add(companyId);
                }
            }
            dict = dict.OrderBy(x => x.Key).ToDictionary(a => a.Key, y => y.Value);
            if (dict.Count > 0)
            {
                foreach (var item in dict)
                {
                    Console.WriteLine(item.Key);
                    foreach (var items in item.Value)
                    {
                        Console.WriteLine($"-- {items}");
                    }
                }
            }
        }
    }
}