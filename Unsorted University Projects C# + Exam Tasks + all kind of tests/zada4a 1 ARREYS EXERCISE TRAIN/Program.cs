using System;
using System.Linq;

namespace zada4a_1_ARREYS_EXERCISE_TRAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numberses = new int[number];
            int count = 0;
            int summary = 0;

            for (int i = 0; i < number; i++)
            {
                summary = int.Parse(Console.ReadLine());
                numberses[i] = summary;
                count += numberses[i];

            }
            for (int i = 0; i < numberses.Length; i++)
            {
                Console.Write(numberses[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
