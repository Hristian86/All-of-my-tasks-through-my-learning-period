using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static Dictionary<int, List<int>> graph;
        private static List<List<int[]>> checkGraph;

        static void Main(string[] args)
        {
            FillGraph();

            ConnectionsToCheck();

            CheckTheGraphConnections();
        }

        private static void CheckTheGraphConnections()
        {
            for (int i = 0; i < checkGraph.Count; i++)
            {
                bool result = Sol(checkGraph[i]);
                Print(result);
            }
        }

        private static void Print(bool result)
        {
            Console.WriteLine(result ? "yes" : "no");
        }

        private static bool Sol(List<int[]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int[] pair = list[i];
                int perant = pair[0];
                int chield = pair[1];
                bool contains = false;

                foreach (int node in graph[perant])
                {
                    if (node == chield)
                    {
                        contains = true;
                    }
                }

                if (!contains)
                {
                    return false;
                }

                // Easy variant.
                //if (!graph[perant].Contains(chield))
                //{
                //    return false;
                //}
            }

            return true;
        }

        private static void ConnectionsToCheck()
        {
            int count = int.Parse(Console.ReadLine());
            checkGraph = new List<List<int[]>>();

            for (int i = 0; i < count; i++)
            {
                List<int> reads = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                if (reads.Count > 1)
                {
                    List<int[]> path = new List<int[]>();
                    for (int j = 0; j < reads.Count - 1; j++)
                    {
                        path.Add(new int[] { reads[j], reads[j + 1] });
                    }

                    checkGraph.Add(path);
                }
            }
        }

        // Not used.
        private static void Connections()
        {
            string read = Console.ReadLine();
            int counter = 0;
            while (read != " ")
            {

                int[] connections = read.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => int.Parse(a))
                    .ToArray();

                if (connections.Length > 1)
                {
                    for (int i = 0; i < connections.Length; i++)
                    {
                        graph[counter].Add(connections[i]);
                    }
                    counter += 1;
                }

                read = Console.ReadLine();
            }

        }

        private static void FillGraph()
        {
            int keys = int.Parse(Console.ReadLine());
            graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < keys; i++)
            {
                if (!graph.ContainsKey(i))
                {
                    graph[i] = new List<int>();
                }

                string read = Console.ReadLine();
                if (read != null && read != " " && read.Length > 0)
                {
                    List<int> connections = read
                        .Split(" ")
                        .Select(int.Parse)
                        .ToList();

                    if (connections.Count > 0)
                    {
                        graph[i].AddRange(connections);
                    }
                }
            }
        }
    }
}