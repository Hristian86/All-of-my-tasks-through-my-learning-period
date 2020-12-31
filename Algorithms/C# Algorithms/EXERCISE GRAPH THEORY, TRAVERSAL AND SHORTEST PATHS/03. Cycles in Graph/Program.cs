using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Cycles_in_Graph
{
    class Program
    {
        //        3. Cycles in a Graph
        //Write a program to check whether a directed graph is acyclic or holds anycycles.The input ends with &quot;End&quot; line.
        private static Dictionary<string, List<string>> edges;
        private static bool acyclic = false;
        private static int count = 0;

        static void Main(string[] args)
        {
            edges = new Dictionary<string, List<string>>();

            String stop = "End";
            string nodes = Console.ReadLine();

            while (stop != nodes)
            {
                List<string> nodeAndChields = nodes.Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!edges.ContainsKey(nodeAndChields[0]))
                {
                    edges[nodeAndChields[0]] = new List<string>();
                    edges[nodeAndChields[0]].Add(nodeAndChields[1]);
                }

                nodes = Console.ReadLine();
            }

            foreach (var kvp in edges)
            {
                Acyclic(kvp.Key, kvp.Value, kvp.Key);
                count = 0;
            }

            string disp = !acyclic ? "Yes" : "No";
            Console.WriteLine($"Acyclic: {disp}");
        }

        private static void Acyclic(string perant, List<string> chields, string target)
        {
            if (perant == target && count != 0)
            {
                acyclic = true;
                return;
            }

            count += 1;
            foreach (var chield in chields)
            {
                if (edges.ContainsKey(chield))
                {
                    Acyclic(chield, edges[chield], target);
                }
            }
        }
    }
}