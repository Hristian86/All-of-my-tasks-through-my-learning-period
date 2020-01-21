using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_MULTY_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[numbers[0], numbers[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currentText = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentText[j];
                }
            }
            while (true)
            {
                string[] text = Console.ReadLine().Split();
                if (text[0] == "END")
                {
                    break;
                }
                if (text[0] == "swap")
                {
                    int row = int.Parse(text[1]);
                    int col = int.Parse(text[2]);
                    int rowToBeSwaped = int.Parse(text[3]);
                    int colToBeSwaped = int.Parse(text[4]);
                    if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1) || rowToBeSwaped >= matrix.GetLength(0) || colToBeSwaped >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[row,col];
                        matrix[row, col] = matrix[rowToBeSwaped, colToBeSwaped];
                        matrix[rowToBeSwaped, colToBeSwaped] = temp;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int s = 0; s < matrix.GetLength(1); s++)
                            {
                                Console.Write(matrix[i,s]+" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else if (text[0] != "swap" || text[0] != "END")
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
