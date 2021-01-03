using System;
using System.Collections.Generic;

namespace _1._Binomial_Coefficients
{
    class Program
    {
        //        1. Binomial Coefficients
        //Write a program that finds the binomial coefficient for given non-negative integers n and k.The coefficient can be
        //found recursively by adding the two numbers above using the formula:

        //However, this leads to calculating the same coefficient multiple times (a problem which also occurs when solving the
        //Fibonacci problem recursively). Use memoization to improve performance.
        //You can check your answers using the picture below(row and column indices start from 0):

        private static Dictionary<string, long> cache;

        static void Main(string[] args)
        {

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            cache = new Dictionary<string, long>();
            long num = GetBinon(row, col);
            Console.WriteLine(num);
        }

        private static long GetBinon(int row, int col)
        {
            string id = $"{row} {col}";
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }

            if (row == 0 || col == 0)
            {
                return 1;
            }

            var result = GetBinon(row - 1, col) + GetBinon(row - 1, col - 1);
            cache[id] = result;
            return result;
        }
    }
}
