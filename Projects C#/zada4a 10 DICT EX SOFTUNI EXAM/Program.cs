using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_10_DICT_EX_SOFTUNI_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();
            var contestCount = new Dictionary<string, int>();

            while (true)
            {
                string[] comands = Console.ReadLine().Split('-').ToArray();
                if (comands[0] == "exam finished")
                {
                    break;
                }
                string name = comands[0];
                
                if (comands[1] == "banned")
                {
                    if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                    }
                }
                else
                {
                    if (!contestCount.ContainsKey(comands[1]))
                    {
                        contestCount[comands[1]] = 1;
                    }
                    else
                    {
                        contestCount[comands[1]]++;
                    }
                    double point = double.Parse(comands[2]);
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = point;
                    }
                    if (dict[name] < point)
                    {
                        dict[name] = point;
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var items in contestCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{items.Key} - {items.Value}");
            }
        }
    }
}