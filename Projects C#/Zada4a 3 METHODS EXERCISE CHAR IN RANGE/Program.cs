using System;

namespace Zada4a_3_METHODS_EXERCISE_CHAR_IN_RANGE
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            CharInRangeOf(start, end);
        }
        static void CharInRangeOf(char start,char end)
        {
            int firstChar = Math.Min(start, end);
            int secondChar = Math.Max(start, end);
            for (int i = firstChar+1; i < secondChar ; i++)
            { 
                Console.Write((char)i+" ");
            }
        }
    }
}
