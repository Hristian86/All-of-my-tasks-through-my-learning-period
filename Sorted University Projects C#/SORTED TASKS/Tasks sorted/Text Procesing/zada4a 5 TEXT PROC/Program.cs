using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace zada4a_5_TEXT_PROC
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digit = "";
            string leter = "";
            string difrent = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    leter += text[i];
                }
                else if (!(char.IsLetterOrDigit(text[i])))
                {
                    difrent += text[i];
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(leter);
            Console.WriteLine(difrent);
        }
    }
}
