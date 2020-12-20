using System;
using System.Collections.Generic;

namespace MatrixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<List<int>>();
            list.Add(new List<int>
            {
                11, 2, 4
            });

            list.Add(new List<int>
            {
                4, 5, 6
            });

            list.Add(new List<int>
            {
                10, 8, -12
            });

            diagonalDifference(list);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i < arr[i].Count)
                {
                    leftSum += arr[i][i];
                    rightSum += arr[i][arr.Count - i - 1];
                }
            }

            return (int)Math.Abs(leftSum - rightSum);
        }
    }
}
