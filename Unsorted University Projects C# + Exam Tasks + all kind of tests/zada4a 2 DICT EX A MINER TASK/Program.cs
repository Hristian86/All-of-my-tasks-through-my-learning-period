using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_DICT_EX_A_MINER_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                string preciousMetal = Console.ReadLine();
                if (preciousMetal == "stop")
                {
                    break;
                }
                if (!dict.ContainsKey(preciousMetal))
                {
                    dict[preciousMetal] = 0;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(preciousMetal))
                {
                    dict[preciousMetal] += quantity;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}