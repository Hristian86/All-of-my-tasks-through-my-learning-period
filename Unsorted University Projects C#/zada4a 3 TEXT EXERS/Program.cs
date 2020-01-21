using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_3_TEXT_EXERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(':');
            var finalStr = "";
            string[] filter = text[1].Split(@"\",StringSplitOptions.RemoveEmptyEntries);
            var stres = new StringBuilder();
            foreach (var item in filter)
            {
                string word = item;
                if (Abstract(text, word) || word.Contains("."))
                {
                    string[] str = word.Split(".");
                    string str1 = str[0];
                    string str2 = str[1];
                    string compile = $"File name: {str[0]}" + Environment.NewLine + $"File extension: {str[1]}";

                    stres.Append(compile);

                    finalStr += word;
                }
            }
            var finalStr1 = finalStr.Split(".");
            Console.WriteLine(stres);
            //Console.WriteLine($"File name: {finalStr1[0]}");
           // Console.WriteLine($"File extension: {finalStr1[1]}");
        }
        static bool Abstract(string[] text, string finalStr)
        {
            for (int i = 0; i < finalStr.Length-1; i++)
            {
                if (!((char.IsLetterOrDigit(finalStr[i])) && (finalStr[i] == '.')))
                {
                    return false;
                }
            }
            return true;
        }
    }
}