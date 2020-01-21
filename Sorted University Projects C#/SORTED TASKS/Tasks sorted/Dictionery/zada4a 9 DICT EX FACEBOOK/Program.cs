using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_9_DICT_EX_FACEBOOK
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            //string nameToAd = "";
            string separator = "";
            string comand = "";

            while ((comand = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] comands = new string[comand.Length - 1];
                if (comand.Contains(" -> "))
                {
                    comands = comand.Split(" -> ");
                    if (comands.Length == 2)
                    {
                        separator = "->";
                    }
                }
                else if (comand.Contains(" | "))
                {
                    comands = comand.Split(" | ");
                    if (comands.Length == 2)
                    {
                        separator = "|";
                    }
                }

                string sideName = comands[0];

                string nameSide = comands[1];

                bool containsUser = false;
                if (separator == "|")
                {
                    containsUser = ContainsUser(dict, nameSide);
                    if (!dict.ContainsKey(sideName))
                    {
                        dict[sideName] = new List<string>();
                        if (!containsUser)
                        {
                            dict[sideName].Add(nameSide);
                        }
                    }
                    else if (dict.ContainsKey(sideName))
                    {
                        if (!containsUser)
                        {
                            dict[sideName].Add(nameSide);
                        }
                    }
                    containsUser = false;
                }
                else if (separator == "->")
                {
                    containsUser = ContainsUser(dict, sideName);
                    if (containsUser)
                    {
                        dict.Values.First(x => x.Remove(sideName));
                    }
                    
                    if (!dict.ContainsKey(nameSide))
                    {
                        dict[nameSide] = new List<string>();
                    }
                        dict[nameSide].Add(sideName);
                        Console.WriteLine($"{sideName} joins the {nameSide} side!");
                }
                separator = "";
                containsUser = false;
            }
            dict.TrimExcess();
            foreach (var item in dict.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var items in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {items}");
                }
            }
        }
        static bool ContainsUser(Dictionary<string, List<string>> dict, string nameSide)
        {
            bool user = false;
            foreach (var item in dict.Values)
            {
                if (item.Contains(nameSide))
                {
                    user = true;
                }
            }
            return user;
        }
    }
}