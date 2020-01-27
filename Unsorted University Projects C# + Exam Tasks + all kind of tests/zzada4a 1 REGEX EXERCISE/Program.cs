using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace zzada4a_1_REGEX_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            var listOfNames = new List<string>();

            while (true)
            {

                string patr = @"(?<name>>>\w+<<)(?<price>[?0-9]*\.[0-9]+|[0-9]+)!(?<quantity>\d+)\b";

                string words = Console.ReadLine();

                if (words == "Purchase")
                {
                    break;
                }

                var characters = Regex.Matches(words, patr);

                foreach (Match item in characters)
                {
                    var name = item.Groups["name"].Value.Trim('>', '<');
                    var price = double.Parse(item.Groups["price"].Value);
                    var quantity = int.Parse(item.Groups["quantity"].Value);
                    total += price * quantity;
                    listOfNames.Add(name);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in listOfNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}