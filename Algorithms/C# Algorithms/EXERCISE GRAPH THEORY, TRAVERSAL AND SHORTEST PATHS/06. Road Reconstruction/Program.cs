using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Road_Reconstruction
{
    class Program
    {
        //        6. Road Reconstruction
        //Write a program that finds all the roads without which buildings in the city will become unreachable.
        //You will receive how many buildings the town has on the first line, then you will receive the number of streets and
        //finally for each street you will receive which buildings it connects.Find all the streets that are important and cannot
        //be removed and print them in ascending order(e.g. 3 0 should be printed as 0 3).
        //Input
        // On the first line you will receive the number of the buildings.
        // On the second line you will receive the amount of the streets (n).
        // On the next &quot; n&quot; lines you will receive which buildings each street connects.
        // Output
        // On the first line print: &quot;Important streets:&quot;.
        // On the next lines(if any) print the street in the format: &quot;{firstBuilding
        //    } {secondBuilding
        //}&quot;.
        // The order of the output does not matter if you print all the important streets.

        //5
        //5
        //1 - 0
        //0 - 2
        //2 - 1
        //0 - 3
        //3 - 4
        private static List<int[]> graph;
        private static Dictionary<int, List<int>> graphToRemove;

        static void Main(string[] args)
        {
            int highestNode = int.Parse(Console.ReadLine());
            int readCount = int.Parse(Console.ReadLine());
            graph = new List<int[]>();
            graphToRemove = new Dictionary<int, List<int>>();

            ReadFromConsole(readCount, highestNode);

            Check(highestNode);
        }

        private static void Check(int highestNode)
        {
            for (int i = 0; i < highestNode; i++)
            {
                int perant = graph[i][0];
                int distance = CalculateDistance(i, perant, perant);
            }
        }

        private static int CalculateDistance(int source, int destination, int perantToCheck)
        {
            var que = new Queue<int>();
            que.Enqueue(source);

            List<int> children;
            int distance = 1;

            while (que.Any())
            {
                int perant = que.Dequeue();
                if (perant == destination)
                {
                    return distance;
                }

                if (graph[perant] != null)
                {

                    foreach (var child in graph)
                    {
                        if (child[1] == perant)
                        {

                        }
                    }

                    int chield = graph[perant][0];

                    que.Enqueue(chield);
                    distance += 1;
                }
                else
                {
                    return -1;
                }
            }

            return -1;
        }

        private static void ReadFromConsole(int readCount, int highestNode)
        {
            for (int i = 0; i < readCount; i++)
            {
                string[] nodes = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                int key = int.Parse(nodes[0]);
                int value = int.Parse(nodes[1]);
                graph.Add(new int[] { key, value });
                if (!graphToRemove.ContainsKey(key))
                {
                    graphToRemove[key] = (new List<int> { key, value });
                }
                else
                {
                    graphToRemove[key].Add(value);
                }
            }
        }
    }
}
