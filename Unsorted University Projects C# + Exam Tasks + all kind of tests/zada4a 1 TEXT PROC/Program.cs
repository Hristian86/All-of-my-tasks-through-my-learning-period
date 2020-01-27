using System;
using System.Linq;

namespace zada4a_1_TEXT_PROC
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(key);
            while (true)
            {
                text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
                if (index < 0)
                {
                    break;
                }
            }
            Console.WriteLine(text);
        }
    }
}