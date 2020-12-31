using System;

namespace _5._Break_Cycles
{
    class Program
    {
        //        5. Break Cycles
        //You are given undirected multi-graph.Remove a minimal number of edges to make the graph acyclic(to break all
        // cycles). As a result, print the number of edges removed and the removed edges.If several edges can be removed to
        //break a certain cycle, remove the smallest of them in alphabetical order (smallest start vertex in alphabetical order
        // and smallest end vertex in alphabetical order).

        private static Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        static OrderedBag<Tuple<string, string>> edges = new OrderedBag<Tuple<string, string>>();
        static HashSet<string> visited = new HashSet<string>();
        private static bool stopRecursion = false;

        public static void Main()
        {
            string line = Console.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                var vertex =
                    line.Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                graph.Add(vertex[0], new List<string>(vertex.Skip(1)));
                for (int i = 1; i < vertex.Length; i++)
                {
                    edges.Add(new Tuple<string, string>(vertex[0], vertex[i]));
                }

                line = Console.ReadLine();
            }

            var result = new List<Tuple<string, string>>();
            foreach (var edge in edges)
            {
                visited.Clear();
                stopRecursion = false;
                var parent = edge.Item1;
                var child = edge.Item2;

                graph[parent].Remove(child);
                graph[child].Remove(parent);

                bool needToRemove = CheckForCycle(parent, child, null);

                if (needToRemove)
                {
                    if (!result.Contains(new Tuple<string, string>(child, parent)))
                    {
                        result.Add(edge);
                    }
                }
                else
                {
                    graph[parent].Add(child);
                    graph[child].Add(parent);
                }
            }

            Console.WriteLine("Edges to remove: " + result.Count);
            foreach (var tuple in result)
            {
                Console.WriteLine($"{tuple.Item1} - {tuple.Item2}");
            }
        }

        private static bool CheckForCycle(string from, string to, string parent)
        {
            if (visited.Contains(from))
            {
                return false;
            }

            if (from == to)
            {
                stopRecursion = true;
                return stopRecursion;
            }

            visited.Add(from);
            foreach (string child in graph[from])
            {
                if (child == parent)
                {
                    continue;
                }

                CheckForCycle(child, to, from);
                if (stopRecursion)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
