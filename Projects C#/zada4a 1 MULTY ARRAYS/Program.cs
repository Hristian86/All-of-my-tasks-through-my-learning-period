using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_MULTY_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[,] numbersOfMatrix = new int[number, number];

            int[,] matrix = new int[number, number];

            double sum = 0;

            for (int i = 0; i < numbersOfMatrix.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < numbersOfMatrix.GetLength(1); j++)
                {
                    matrix[i, j] = nums[j];
               // Console.Write(matrix[i,j]+" ");
                }
                
            }

            double secondSum = 0;
            int count = 0;
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }             
                }
                for (int j = matrix.GetLength(1); j > 0; j--)
                {
                    if (counter == 0)
                    {
                        secondSum += matrix[i, j - count - 1];
                        count++;
                        counter++;
                        //Console.WriteLine(matrix[i,j-count]);
                        //Console.WriteLine(secondSum);
                    }
                }
                counter = 0;
            }
            double totals = Math.Abs(sum - secondSum);
            Console.WriteLine(totals);
        }
    }
}