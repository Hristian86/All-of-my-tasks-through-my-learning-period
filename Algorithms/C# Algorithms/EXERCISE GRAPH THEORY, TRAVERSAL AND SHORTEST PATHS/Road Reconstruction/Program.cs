using System;
using System.Linq;
using System.Collections.Generic;

namespace Road_Reconstruction
{
    class Program
    {
        private static int[,] graph;
        private static Dictionary<int, int> path;

        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            graph = new int[row, row];
            path = new Dictionary<int, int>();

            int readFromConsole = int.Parse(Console.ReadLine());

            FillGraph(readFromConsole);

            PrintGraph();

            for (int i = 0; i < readFromConsole; i++)
            {

            }
        }

        private static void PrintGraph()
        {
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    Console.Write(graph[i,j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void FillGraph(int readFromConsole)
        {
            for (int i = 0; i < readFromConsole; i++)
            {
                List<int> read = Console.ReadLine()
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => int.Parse(a))
                    .ToList();

                graph[read[0], read[1]] = 1;
            }
        }
    }
}
