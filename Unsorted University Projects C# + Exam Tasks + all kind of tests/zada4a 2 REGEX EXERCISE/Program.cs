using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace zada4a_2_REGEX_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = Console.ReadLine().Split(", ").ToArray();

            var dict = new Dictionary<string, double>();
            foreach (var item in names)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }
            }

            while (true)
            {
                string patrn = @"(?<names>[A-za-z]+)";
                string paterDigits = @"(?<digits>\d)";

                string text1 = Console.ReadLine();
                if (text1 == "end of race")
                {
                    break;
                }

                MatchCollection colect = Regex.Matches(text1, patrn);

                string name = "";
                //string counted = "";
                double total = 0;

                foreach (Match items in colect)
                {
                    name += items.Groups["names"].Value.Trim('^');
                    // counted = (items.Groups["count"].Value);
                    // total += double.Parse(counted);
                }
                MatchCollection colext2 = Regex.Matches(text1, paterDigits);

                foreach (Match iteme in colext2)
                {
                    total += double.Parse(iteme.Groups["digits"].Value);
                }

                if (dict.ContainsKey(name))
                {
                    dict[name] += total;
                }
                total = 0;
                name = "";
            }
            int num = 0;
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                num++;
                if (num == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (num == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (num == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
            }
        }
    }
}
