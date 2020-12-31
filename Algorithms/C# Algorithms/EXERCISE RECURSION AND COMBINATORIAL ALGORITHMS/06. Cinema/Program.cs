using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cinema
{
    class Program
    {
        //        6. Cinema
        //Write a program that prints all of the possible distributions of a group of friends in a cinema hall.On the first line
        //you will be given all of the friend&#39;s names separated by comma and space. Until you receive the command
        //&quot;generate&quot; you will be given some of those friend&#39;s names and a number of the place that they want to have.
        //(format: &quot;{name
        //    } - {place
        //}&quot;) So here comes the tricky part.Those friend&#39;s want only to sit on the place that
        //they have chosen.They cannot sit on other places. For more clarification see the examples below.
        //Output
        //Print all the possible ways to distribute the friends having in mind that some of them want a particular place and
        //they will sit there only.The order of the output does not matter.
        //Constrains
        // The friends names and the number of the place will always be valid

        //Garry, Liam, Teddy, Anna, Buddy, Simon
        //Buddy - 3
        //Liam - 5
        //Simon - 1
        //generate

        private static string[] restrictedNames;
        private static string[] displayNames;
        private static bool[] visited;
        private static string[] swapingNames;
        private static List<int> indexes;
        private static HashSet<int> visitedIndexes;

        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            restrictedNames = new string[names.Count + 1];
            displayNames = new string[names.Count];
            visited = new bool[names.Count + 1];
            indexes = new List<int>();
            visitedIndexes = new HashSet<int>();

            string stop = "generate";
            string namesFromConsole = Console.ReadLine();
            int counter = 0;

            while (stop != namesFromConsole)
            {
                counter += 1;
                string[] allParams = namesFromConsole.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string curName = allParams[0];
                int nameIndex = int.Parse(allParams[1]);

                restrictedNames[nameIndex - 1] = curName.Trim();

                namesFromConsole = Console.ReadLine();
            }

            swapingNames = new string[names.Count - counter];

            ArrangeArray(names);

            Fill(names);

            Combination(0, 0, names);
        }

        private static void Fill(List<string> names)
        {
            int count = 0;
            for (int i = 0; i < names.Count; i++)
            {
                if (restrictedNames[i] == null)
                {
                    swapingNames[count] = names[i];
                    indexes.Add(i);
                    count += 1;
                }
            }
        }

        private static void ArrangeArray(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (restrictedNames[i] != null)
                {
                    int removeIndex = FindIndex(restrictedNames[i], names, i);

                    string prevSwap = names[removeIndex];
                    names.RemoveAt(removeIndex);
                    names.Insert(i, prevSwap);

                    //names[removeIndex] = swap;
                    //names[i] = prevSwap;

                    displayNames[i] = restrictedNames[i];
                }
            }
        }

        private static int FindIndex(string name, List<string> names, int i)
        {
            for (int j = 0; j < names.Count; j++)
            {
                string curName = names[j];
                if (name.Trim() == curName.Trim())
                {
                    return j;
                }
            }

            return i;
        }

        private static int FindIndexes(int i)
        {
            foreach (var indx in indexes)
            {

                if (!visitedIndexes.Contains(indx))
                {
                    displayNames[indx] = swapingNames[i];
                    visitedIndexes.Add(indx);
                    return indx;
                }

            }

            return i;
        }

        private static void Combination(int start, int index, List<string> names)
        {
            if (index == swapingNames.Length)
            {
                Console.WriteLine(string.Join(" ", displayNames));
            }
            else
            {
                for (int i = 0; i < swapingNames.Length; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;

                        int visitedIndex = FindIndexes(i);

                        Combination(i, index + 1, names);

                        visitedIndexes.Remove(visitedIndex);
                        visited[i] = false;
                    }
                }
            }
        }
    }
}
