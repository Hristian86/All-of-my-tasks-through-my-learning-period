using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace zada4a_5_TEXT_EXERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAsNumbers = Console.ReadLine().TrimStart('0');
            int numToPulty = int.Parse(Console.ReadLine());
            if (numToPulty == 0)
            {
                Console.WriteLine("0");
                return;
            }
            var listOfNUmbers = new List<string>();
            int parsed = 0;

            for (int i = textAsNumbers.Length - 1; i >= 0; i--)
            {
                string susu = textAsNumbers[i].ToString();
                int calculate = int.Parse(susu);
                parsed = (calculate * numToPulty) + parsed;
                listOfNUmbers.Add((parsed % 10).ToString());
                parsed /= 10;
            }
            listOfNUmbers.Reverse();
            if (parsed > 0)
            {
                //    Console.WriteLine($"{parsed}{string.Join("", listOfNUmbers)}");
                listOfNUmbers.Insert(0, parsed.ToString());
            }
            Console.WriteLine($"{string.Join("", listOfNUmbers)}");

        }
    }
}
