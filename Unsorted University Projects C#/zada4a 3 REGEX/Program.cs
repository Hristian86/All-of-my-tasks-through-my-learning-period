using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace zada4a_3_REGEX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

          string text = Console.ReadLine();

            MatchCollection dates = Regex.Matches(text, path);

            foreach (Match item in dates)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}