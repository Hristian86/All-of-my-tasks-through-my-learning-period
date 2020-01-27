using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace zada4a_4_TEXT_PRC_FILTER
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWord = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var item in banWord)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}