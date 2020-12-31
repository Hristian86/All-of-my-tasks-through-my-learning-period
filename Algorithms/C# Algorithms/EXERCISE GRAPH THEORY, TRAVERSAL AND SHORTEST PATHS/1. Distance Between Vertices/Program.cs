using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Distance_Between_Vertices
{
    class Program
    {
        //        We are given adirected graph.We are given also a set ofpairs of vertices.Find theshortest distance between each
        //pair of vertices or -1 if there is no path connecting them.
        //On the first line, you will get N, the number of vertices in the graph. On the second line, you will get P, the number
        //of pairs between which to find the shortest distance.
        //On the next N lines will be the edges of the graph and on the next P lines, the pairs.

        //9
        //8
        //11:4
        //4:12 1
        //1:12 21 7
        //7:21
        //12:4 19
        //19:1 21
        //21:14 31
        //14:14
        //31:
        //11-7
        //11-21
        //21-4
        //19-14
        //1-4
        //1-11
        //31-21
        //11-14

        private static int node;
        private static int pairs;
        private static Dictionary<int, List<int>> graph;
        private static List<int[]> parametars;
        private static HashSet<int> visited;
        private static int finalCount = 0;

        static void Main(string[] args)
        {
            node = int.Parse(Console.ReadLine());
            pairs = int.Parse(Console.ReadLine());

            graph = new Dictionary<int, List<int>>();
            parametars = new List<int[]>();
            visited = new HashSet<int>();

            FillGraph();

            FillParametars();

            FindDistance();
        }

        private static void FindDistance()
        {
            foreach (var param in parametars)
            {
                //int count = DFS(param[0], param[1], param[0]);
                int count = BFS(param[0], param[1]);

                Console.WriteLine("{" + param[0] + ", " + param[1] + "} -> " + count);
            }
        }

        private static int DFS(int start, int destination, int first)
        {
            int counter = 0;

            foreach (var chield in graph[start])
            {
                if (chield == destination)
                {
                    Console.WriteLine("{" + first + ", " + destination + "} -> " + finalCount);
                    return counter;
                }

                if (!visited.Contains(chield))
                {
                    visited.Add(chield);
                    finalCount += 1;
                    DFS(chield, destination, first);
                    visited.Remove(chield);
                }
            }

            return finalCount;
        }

        private static int BFS(int start, int destination)
        {
            int counter = 0;
            var queue = new Queue<int>();
            visited = new HashSet<int>();
            queue.Enqueue(start);

            while (queue.Any())
            {
                counter += 1;
                var keyChield = queue.Dequeue();
                visited.Add(keyChield);
                var listOfChields = new List<int>();
                foreach (int chield in graph[keyChield])
                {
                    if (chield == destination)
                    {
                        return counter;
                    }

                    if (!visited.Contains(chield))
                    {
                        visited.Add(chield);
                        listOfChields.Add(chield);
                        queue.Enqueue(chield);
                    }
                }

                //queue = new Stack<int>(listOfChields);
            }

            return -1;
        }

        private static void FillParametars()
        {
            for (int i = 0; i < pairs; i++)
            {
                int[] pair = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray();
                parametars.Add(pair);
            }
        }

        private static void FillGraph()
        {
            for (int i = 0; i < node; i++)
            {
                string[] nodes = Console.ReadLine()
                       .Split(":");

                int keyNode = int.Parse(nodes[0]);
                if (!graph.ContainsKey(keyNode))
                {
                    graph[keyNode] = new List<int>();

                    if (nodes.Length > 1)
                    {
                        graph[keyNode].AddRange(nodes[1].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToList());
                    }
                }
                else
                {
                    graph[keyNode].AddRange(nodes[1].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToList());
                }
            }
        }
    }
}
