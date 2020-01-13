using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_6_TEXT_EXERS
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] textAsChars = Console.ReadLine().ToCharArray();
            var filter = new StringBuilder();
            for (int i = 0; i < textAsChars.Length-1; i++)
            {
                if (textAsChars[i] != textAsChars[i+1])
                {
                    filter.Append(textAsChars[i]);
                }
            }
            filter.Append(textAsChars[textAsChars.Length-1]);
            Console.WriteLine(string.Join(",",filter));
        }
    }
}