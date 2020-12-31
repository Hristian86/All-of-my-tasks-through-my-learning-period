using System;

namespace Nested_Loops
{
    class Program
    {
        private static int[] numbers;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            Permut(n, 0);
        }

        private static void Permut(int n, int index)
        {
            if (index == n)
            {
                // Print.
                Console.WriteLine(string.Join(" ",numbers));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                numbers[index] = i + 1;
                Permut(n, index + 1);
            }
        }
    }
}
