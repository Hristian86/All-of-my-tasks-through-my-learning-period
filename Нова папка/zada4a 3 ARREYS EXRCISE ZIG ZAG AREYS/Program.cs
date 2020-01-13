using System;
using System.Linq;

namespace zada4a_3_ARREYS_EXRCISE_ZIG_ZAG_AREYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstLineOutput = new string[n];
            string[] secondLineOutput = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (i % 2 == 0)
                {
                    firstLineOutput[i] = input[0];
                    secondLineOutput[i] = input[1];
                }
                else
                {
                    firstLineOutput[i] = input[1];
                    secondLineOutput[i] = input[0];
                }
            }
            Console.WriteLine(String.Join(" ", firstLineOutput));
            Console.WriteLine(String.Join(" ", secondLineOutput));
        }
    }
}
