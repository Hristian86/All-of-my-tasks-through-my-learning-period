using System;

namespace Task1
{
    class Program
    {
        private static char[,] matrix;
        private static bool[,] visited;
        private static int count;

        static void Main(string[] args)
        {
            ReadFromConsole();

            GetSol();

            Console.WriteLine(count);
        }

        private static void GetSol()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!visited[i, j] && matrix[i,j] == 't')
                    {
                        Solve(i, j, 't');
                        count += 1;
                    }
                }
            }
        }

        private static void Solve(int row, int col, char searchedAreaChar)
        {
            if (IsOutOfBounds(row,col) || visited[row,col] || matrix[row,col] != searchedAreaChar)
            {
                return;
            }

            visited[row, col] = true;

            Solve(row - 1, col, searchedAreaChar); // up
            Solve(row - 1, col + 1, searchedAreaChar); // up right

            Solve(row + 1, col, searchedAreaChar); // down
            Solve(row + 1, col - 1, searchedAreaChar); // down left

            Solve(row, col - 1, searchedAreaChar); // left
            Solve(row - 1, col - 1, searchedAreaChar); // left up

            Solve(row, col + 1, searchedAreaChar); // right
            Solve(row + 1, col + 1, searchedAreaChar); // right down,
        }

        private static bool IsOutOfBounds(int row, int col)
        {
            return row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1);
        }

        private static void ReadFromConsole()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            matrix = new char[row, col];
            visited = new bool[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var temp = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];
                }
            }
        }
    }
}
