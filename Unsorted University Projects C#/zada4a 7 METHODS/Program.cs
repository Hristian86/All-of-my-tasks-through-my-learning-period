using System;

namespace zada4a_7_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRepeat = Console.ReadLine();
            string trueResult = RepetedStr(toRepeat);
            Console.WriteLine(trueResult);
        }
        static string RepetedStr(string toRepeat)
        {
            int numRepeater = int.Parse(Console.ReadLine());
            int count = 0;
            string result = "";
            while (count < numRepeater)
            {
                count++;
                result += toRepeat;
            }
            return result;
        }
    }
}
