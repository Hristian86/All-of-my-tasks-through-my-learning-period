using System;
using System.Collections.Generic;

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

        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            restrictedNames = new string[names.Length + 1];
            displayNames = new string[names.Length];
            visited = new bool[names.Length + 1];

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

            swapingNames = new string[names.Length - counter];

            ArrangeArray(names);
            ;
            Combination(0, 0, names);
        }

        private static void ArrangeArray(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (restrictedNames[i] != null)
                {
                    int swapIndex = FindIndex(restrictedNames[i], names, i);

                    string prevSwap = names[swapIndex];
                    string swap = names[i];
                    names[swapIndex] = swap;
                    names[i] = prevSwap;
                    displayNames[i] = restrictedNames[i];
                }
                else
                {
                    swapingNames[count] = names[i];
                }

            }
        }

        private static int FindIndex(string name, string[] names, int i)
        {
            for (int j = 0; j < names.Length;  j ++)
            {
                string curName = names[j].Trim();
                if (name == curName)
                {
                    return j;
                }
            }

            return i;
        }

        private static void Combination(int start, int index, string[] names)
        {
            if (index == names.Length)
            {
                Console.WriteLine(string.Join(" ", displayNames));
            }
            else
            {
                for (int i = start; i < names.Length; i++)
                {
                    if (restrictedNames[i] == null && !visited[i] && restrictedNames[index] == null)
                    {
                        visited[i] = true;
                        displayNames[index] = names[i];
                        Combination(i, index + 1, names);
                        visited[i] = false;
                    }
                    else if (!visited[i])
                    {
                        visited[i] = true;
                        Combination(i, index + 1, names);
                        visited[i] = false;
                    }
                }

                //if (index == names.Length)
                //{
                //    Console.WriteLine(string.Join(" ", displayNames));
                //}
            }
        }

        //private static void Combination(int start, int index, string[] names)
        //{
        //    if (index == names.Length)
        //    {
        //        Console.WriteLine(string.Join(" ", displayNames));
        //    }
        //    else
        //    {
        //        for (int i = start; i < names.Length; i++)
        //        {
        //            if (restrictedNames[i] == null && !visited[i])
        //            {
        //                visited[i] = true;
        //                displayNames[index] = names[i];
        //                Combination(i, index + 1, names);
        //                visited[i] = false;
        //            }
        //            else if (!visited[i])
        //            {
        //                index += 1;
        //                //Combination(i, index + 1, names);
        //            }
        //        }

        //        //if (index == names.Length)
        //        //{
        //        //    Console.WriteLine(string.Join(" ", displayNames));
        //        //}
        //    }
        //}
    }
}
