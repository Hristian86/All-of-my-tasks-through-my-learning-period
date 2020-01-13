using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace zada4a_6_EXTRACT_EMAILS
{
    class Program
    {
        static void Main(string[] args)
        {
            string patrn = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";

            string text = Console.ReadLine();

            MatchCollection pencho = Regex.Matches(text, patrn);

            foreach (var item in pencho)
            {
                Console.WriteLine(item);
            }
        }
    }
}
