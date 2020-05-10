using System;
using System.Collections;
using System.Collections.Generic;

namespace Labyrint
{

    //    Problem 8. * Distance in Labyrinth
    //We are given a labyrinth of size N x N.Some of its cells are empty(0) and some are full(x). We can move from an
    //empty cell to another empty cell if they share common wall.Given a starting position (*) calculate and fill in the
    //array the minimal distance from this position to any other cell in the array. Use &quot; u&quot; for all unreachable cells.
    //Example:

    class Program
    {
        private static readonly string[,] Matrix =
        {
            {"0", "0", "0", "x", "0", "x"},
            {"0", "x", "0", "x", "0", "x"},
            {"0", "*", "x", "0", "x", "0"},
            {"0", "x", "0", "0", "0", "0"},
            {"0", "0", "0", "x", "x", "0"},
            {"0", "0", "0", "x", "0", "x"}
        };

        static void Main(string[] args)
        {
            var row = 2;
            var col = 1;

            var que = new Queue<Cell>();
            que.Enqueue(new Cell(row, col, 0));

            while (que.Count > 0)
            {
                var currentCell = que.Dequeue();

                //cheking collomn up
                if (currentCell.Row > 0 && Matrix[currentCell.Row - 1, currentCell.Col] == "0")
                {
                    que.Enqueue(new Cell(currentCell.Row - 1, currentCell.Col, currentCell.Step + 1));

                    Matrix[currentCell.Row - 1, currentCell.Col] = (currentCell.Step + 1).ToString();
                }

                //cheking row right
                if (currentCell.Col < Matrix.GetLength(1) - 1 && Matrix[currentCell.Row, currentCell.Col + 1] == "0")
                {
                    que.Enqueue(new Cell(currentCell.Row, currentCell.Col + 1, currentCell.Step + 1));

                    Matrix[currentCell.Row, currentCell.Col + 1] = (currentCell.Step + 1).ToString();
                }

                //cheking collumn down
                if (currentCell.Row < Matrix.GetLength(0) - 1 && Matrix[currentCell.Row + 1, currentCell.Col] == "0")
                {
                    que.Enqueue(new Cell(currentCell.Row + 1, currentCell.Col, currentCell.Step + 1));

                    Matrix[currentCell.Row + 1, currentCell.Col] = (currentCell.Step + 1).ToString();
                }

                //cheking row left
                if (currentCell.Col > 0 && Matrix[currentCell.Row, currentCell.Col - 1] == "0")
                {
                    que.Enqueue(new Cell(currentCell.Row, currentCell.Col - 1, currentCell.Step + 1));

                    Matrix[currentCell.Row, currentCell.Col - 1] = (currentCell.Step + 1).ToString();
                }
            }

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", Matrix[i, j] == "0"
                        ? "u"
                        : Matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}