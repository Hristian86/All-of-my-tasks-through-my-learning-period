using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static void Main()
        {
            int[] s1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            //"AGGTAB";
            int[] s2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            char[] X = new char[s1.Length];
            char[] Y = new char[s2.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                X[i] = (char)s1[i];
            }

            for (int i = 0; i < s2.Length; i++)
            {
                Y[i] = (char)s2[i];
            }

            var lcs = CalcLongestCommonSeq(X, Y);

            ReconstructSeq(X, Y, lcs); // not required by Judge
        }

        private static void ReconstructSeq(char[] firstSeq, char[] secondSeq, int[][] lcs)
        {
            var longestSeq = new Stack<char>();
            var row = firstSeq.Length;
            var col = secondSeq.Length;

            while (row != 0 && col != 0)
            {
                if (firstSeq[row - 1] == secondSeq[col - 1]         // equal elements &&
                    && lcs[row][col] == 1 + lcs[row - 1][col - 1])  // current = 1 + diagonal
                {
                    longestSeq.Push(firstSeq[row - 1]);
                    row--; // move diagonally
                    col--;
                }
                else if (lcs[row - 1][col] >= lcs[row][col - 1]) // top >= left => move up
                {
                    row--;
                }
                else // left > top => move left
                {
                    col--;
                }
            }

            //  Console.WriteLine(string.Join(string.Empty, longestSeq));
        }

        private static int[][] CalcLongestCommonSeq(char[] firstSeq, char[] secondSeq)
        {
            // Initialize matrix
            var rows = firstSeq.Length + 1;
            var cols = secondSeq.Length + 1;

            var lcs = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                lcs[row] = new int[cols];
            }

            // Calc LCS
            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    var top = lcs[row - 1][col];
                    var left = lcs[row][col - 1];
                    var bestResult = Math.Max(top, left);

                    if (firstSeq[row - 1] == secondSeq[col - 1]) // equal elements
                    {
                        var diagonalTopLeft = lcs[row - 1][col - 1];
                        bestResult = Math.Max(bestResult, 1 + diagonalTopLeft);
                    }

                    lcs[row][col] = bestResult;
                }
            }

            Console.WriteLine(lcs[rows - 1][cols - 1]);
            return lcs;
        }
    }
}