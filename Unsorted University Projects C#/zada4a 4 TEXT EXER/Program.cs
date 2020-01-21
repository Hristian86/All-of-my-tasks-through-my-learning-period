using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_TEXT_EXER
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           // var encrypt = new StringBuilder();
            string filtered = "";
            for (int i = 0; i < text.Length; i++)
            {
                int ch = text[i]+3;          
                filtered += (char)ch;
                //encrypt.Append((char)ch);
            }
            Console.WriteLine(filtered);
        }
    }
}
