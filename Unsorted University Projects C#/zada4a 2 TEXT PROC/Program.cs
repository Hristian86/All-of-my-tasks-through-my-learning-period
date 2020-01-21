using System;
using System.Text;

namespace zada4a_2_TEXT_PROC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comand = Console.ReadLine().Split();
            StringBuilder text = new StringBuilder();
            foreach (var item in comand)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    text.Append(item);
                }
            }
            Console.WriteLine(text);
        }
    }
}
