using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_3_DICT_EX_LEGENDARY_FARMING
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            var ordDict = new SortedDictionary<string, int>();
            dict["shards"] = 0;
            dict["fragments"] = 0;
            dict["motes"] = 0;

            // to arrenge breakpoints
            bool tipicalChek = false;
            
            while (true)
            {
                string[] materials = Console.ReadLine().Split(" ").ToArray();
                int quantity = 0;

                for (int i = 0; i < materials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(materials[i]);
                    }
                    else
                    {
                        string keys = materials[i].ToLower();

                        if (keys == "shards" || keys == "motes" || keys == "fragments")
                        {
                            dict[keys] += quantity;
                            if (TryChek(dict))
                            {
                                tipicalChek = true;
                                break;
                            }
                        }
                        else
                        {

                            if (!ordDict.ContainsKey(keys))
                            {
                                ordDict[keys] = quantity;
                            }
                            else
                            {
                                ordDict[keys] += quantity;
                            }
                        }
                    }

                }
                if (tipicalChek)
                {
                    break;
                }
            }

            dict = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var items in dict)
            {
                    Console.WriteLine($"{items.Key}: {items.Value}");
            }
            foreach (var item in ordDict)
            {
                    Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        static bool TryChek(Dictionary<string,int> dict)
        {
            bool itCheks = false;
            if (dict["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                dict["shards"] -= 250;
                itCheks = true;
            }
            //if (dict.ContainsKey("shards"))
            //{
            //    int num = dict.GetValueOrDefault("shards");
            //    if (num >= 250)
            //    {
            //            Console.WriteLine("Shadowmourne obtained!");
            //        dict["shards"] -= 250;
            //        itCheks = true;
            //    }
            //}
            else if (dict["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                dict["fragments"] -= 250;
                itCheks = true;
            }
            //if (dict.ContainsKey("fragments"))
            //{
            //    int num = dict.GetValueOrDefault("fragments");
            //    if (num >= 250)
            //    {
            //            Console.WriteLine("Valanyr obtained!");
            //        dict["fragments"] -= 250;
            //        itCheks = true;
            //    }
            //}
            else if (dict["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                dict["motes"] -= 250;
                itCheks = true;
            }
            //if (dict.ContainsKey("motes"))
            //{
            //    int num = dict.GetValueOrDefault("motes");
            //    if (num >= 250)
            //    {
            //            Console.WriteLine("Dragonwrath obtained!");
            //        dict["motes"] -= 250;
            //        itCheks = true;
            //    }
            //}
            return itCheks;
        }
    }
}