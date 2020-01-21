using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_MULTY_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[numbers[0], numbers[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentNum[j];
                }
            }
            int count = 0;
            int counter = 0;
            int sum = 0;
            int differ = int.MinValue;
            int[,] display = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {

                    count = j;
                    int sum1 = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2];
                    int sum2 = matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2];
                    int sum3 = matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    sum = sum1 + sum2 + sum3;
                    if (sum > differ)
                    {
                        differ = sum;
                        for (int z = 0; z < display.GetLength(0); z++)
                        {
                            for (int f = 0; f < display.GetLength(1); f++)
                            {
                                display[z, f] = matrix[i + z, j + f];
                            }
                        }
                        //display[0, 0] = matrix[i, j];
                        //display[0, 1] = matrix[i, j + 1];
                        //display[0, 2] = matrix[i, j + 2];
                        //display[1, 0] = matrix[i + 1, j];
                        //display[1, 1] = matrix[i + 1, j + 1];
                        //display[1, 2] = matrix[i + 1, j + 2];
                        //display[2, 0] = matrix[i + 2, j];
                        //display[2, 1] = matrix[i + 2, j + 1];
                        //display[2, 2] = matrix[i + 2, j + 2];
                    }
                    counter++;
                    sum = 0;
                }
            }
            Console.WriteLine($"Sum = {differ}");
            for (int g = 0; g < display.GetLength(0); g++)
            {
                for (int v = 0; v < display.GetLength(1); v++)
                {
                    Console.Write(display[g, v] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}