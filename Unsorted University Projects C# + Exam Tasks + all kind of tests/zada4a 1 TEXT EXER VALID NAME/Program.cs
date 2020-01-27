using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace zada4a_1_TEXT_EXER_VALID_NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            var filtNames = new StringBuilder();

            for (int i = 0; i < names.Length; i++)
            {
                string word = names[i];
                if ((word.Length >= 3 && word.Length <= 16) && (Chek(word)))
                {
                        filtNames.AppendLine(word);
                }
            }
            Console.Write(filtNames);
        }
        static bool Chek(string word)
        {
            foreach (var item in word)
            {
                if (!(char.IsLetterOrDigit(item) || item == '-' || item == '_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}