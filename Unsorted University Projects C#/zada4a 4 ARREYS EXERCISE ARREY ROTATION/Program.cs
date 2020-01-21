using System;
using System.Linq;

namespace zada4a_4_ARREYS_EXERCISE_ARREY_ROTATION
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lettersAsNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int[] tests = new int[lettersAsNumbers.Length];
            int count = 0;

            for (int i = 0; i < number; i++)
            {
                count = lettersAsNumbers[0];
                for (int j = 0; j < tests.Length-1; j++)
                {
                    lettersAsNumbers[j] = lettersAsNumbers[j + 1];
                }
                lettersAsNumbers[lettersAsNumbers.Length - 1] = count;
            }
            Console.WriteLine(string.Join(" ",lettersAsNumbers));
            //for (int i = 0; i < lettersAsNumbers.Length; i++)
            //{
            //    Console.Write(lettersAsNumbers[i] + " ");
            //}
        }
    }
}