using System;

namespace _03._Combinations_with_Repetition
{
    class Program
    {
        private static int[] numbers;
        private static bool[] visited;
        private static int[] display;

        static void Main(string[] args)
        {
            int setOfEl = int.Parse(Console.ReadLine());
            int combinations = int.Parse(Console.ReadLine());
            visited = new bool[setOfEl + 1];
            display = new int[combinations];

            FillArray(setOfEl);
            Combinations(1, combinations, 0);
        }

        private static void Combinations(int start, int combinations, int index)
        {
            if (index == display.Length)
            {
                Console.WriteLine(string.Join(" ", display));
            }
            else
            {
                for (int i = start; i <= numbers.Length; i++)
                {
                    //if (!visited[i])
                    //{
                    //    visited[i] = true;
                    display[index] = i;
                    Combinations(i, combinations, index + 1);
                    //    visited[i] = false;
                    //}
                }
            }
        }

        private static void FillArray(int setOfEl)
        {
            numbers = new int[setOfEl];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
        }
    }
}
