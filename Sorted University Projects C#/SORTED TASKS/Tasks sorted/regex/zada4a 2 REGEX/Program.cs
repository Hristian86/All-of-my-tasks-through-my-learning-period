using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace zada4a_2_REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"( ?\+359 2 \d{3} \d{4}\b)|( ?\+359-2-\d{3}-\d{4}\b)";
            //string text = Console.ReadLine();

            var colection = Regex.Matches(Console.ReadLine(), pattern);
            int num = 0;
            string filterPhones = "";

            foreach (var item in colection)
            {
                filterPhones += item;
                num++;
                Console.Write(item);
                if (num == 15)
                {
                    filterPhones += ", ";
                }
            }
            //Console.WriteLine(filterPhones);
            //var phones = colection.Value.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            //Console.WriteLine(string.Join(", ",phones));
            

            //var pattern = @"( ?\+359 2 \d{3} \d{4})|(\+ ?359-2-\d{3}-\d{4})";
            //var matches = Regex.Matches(Console.ReadLine(), pattern);
            //var listofnumbers = new List<string>();
            //foreach (Match match in matches)
            //{
            //    listofnumbers.Add(match.Value.Trim());
            //}
            //Console.WriteLine(string.Join(", ", listofnumbers));
        }
    }
}