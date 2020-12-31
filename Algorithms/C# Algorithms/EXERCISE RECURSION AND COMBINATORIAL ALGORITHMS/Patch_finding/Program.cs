using System;
using System.Collections.Generic;
using System.Linq;

namespace Patch_finding
{
    public class Stats
    {
        public int Size { get; set; }

        public int[] StartPosition { get; set; }
    }

    class Program
    {
        private static int rows = 4;
        private static int cols = 9;

        private static char[,] matrix = new char[,]
        {
            { '-','-','-','*','-','-','-','*','-' },
            { '-','-','-','*','-','-','-','*','-' },
            { '-','-','-','*','-','-','-','*','-' },
            { '-','-','-','-','*','-','*','-','-' },
        };

        private static bool[,] visited;
        private static List<Stats> statistics;
        private static int size;
        private static Queue<int[]> next;
        private static bool wallEncountered = false;
        private static int[] positionFound;

        static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            statistics = new List<Stats>();
            next = new Queue<int[]>();

            visited = new bool[rows, cols];
            matrix = new char[rows, cols];

            FillTheMatrix();

            int[] startParams = findStartIndex();
            next.Enqueue(new int[] { startParams[0], startParams[1] });

            size = 0;
            //while (next.Any())
            //{

            for (int f = startParams[0]; f < matrix.GetLength(0); f++)
            {
                for (int g = startParams[1]; g < matrix.GetLength(1); g++)
                {
                    if (visited[f, g] == false)
                    {
                        int[] parametars = new int[] { f, g };
                        FindAreas(parametars[0], parametars[1], '*');

                        wallEncountered = false;
                        statistics.Add(new Stats
                        {
                            Size = size,
                            StartPosition = new int[] { parametars[0], parametars[1] },
                        });

                        size = 0;
                    }
                }
            }

            //int[] parametars = next.Dequeue();
            //FindAreas(parametars[0], parametars[1], '*');

            // To Do: Add to list of Stats object and restart size prop.
            //wallEncountered = false;
            //statistics.Add(new Stats
            //{
            //    Size = size,
            //    StartPosition = new int[] { parametars[0], parametars[1] },
            //});

            size = 0;


            //PrintVisited();
            Print();
        }

        private static void FillTheMatrix()
        {
            for (int s = 0; s < matrix.GetLength(0); s++)
            {
                string currentRow = Console.ReadLine();
                for (int a = 0; a < currentRow.Length; a++)
                {
                    matrix[s, a] = currentRow[a];
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine($"Total areas found: {statistics.Count}");
            var count = 1;
            foreach (var stat in statistics.OrderByDescending(x => x.Size).ThenBy(a => a.StartPosition[1]))
            {
                Console.WriteLine($"Area #{count} at ({stat.StartPosition[0]}, {stat.StartPosition[1]}), size: {stat.Size}");
                count += 1;
            }
        }

        private static int[] findStartIndex()
        {
            for (int s = 0; s < matrix.GetLength(0); s++)
            {
                for (int e = 0; e < matrix.GetLength(1); e++)
                {
                    if (matrix[s, e] != '*')
                    {
                        return new int[] { s, e };
                    }
                }
            }

            return new int[] { 0, 0 };
        }

        private static void PrintVisited()
        {
            for (int i = 0; i < visited.GetLength(0); i++)
            {
                for (int j = 0; j < visited.GetLength(1); j++)
                {
                    Console.Write(visited[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void FindAreas(int row, int col, char wall)
        {
            if (IsOutOfBounds(row, col) || visited[row, col])
            {
                return;
            }

            if (matrix[row, col] == wall)
            {
                visited[row, col] = true;
                return;
            }

            visited[row, col] = true;
            size += 1;

            // right.
            FindAreas(row, col + 1, wall);

            // down.
            FindAreas(row + 1, col, wall);

            // left.
            FindAreas(row, col - 1, wall);

            // up.
            FindAreas(row - 1, col, wall);
        }

        private static void CheckForWall(int row, int col, char wall)
        {
            if (!IsOutOfBounds(row, col + 1) && matrix[row, col + 1] != wall)
            {
                next.Enqueue(new int[] { row, col + 1 });
                wallEncountered = true;
                positionFound = new int[] { row, col + 1 };
            }
            else
            {
                CheckForWall(row, col + 1, wall);
            }
        }

        private static bool IsOutOfBounds(int row, int col)
        {
            return row >= rows || row < 0 || col >= cols || col < 0;
        }
    }
}
