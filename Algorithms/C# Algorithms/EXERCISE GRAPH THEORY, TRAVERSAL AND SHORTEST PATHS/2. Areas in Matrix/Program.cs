using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Areas_in_Matrix
{
    class Program
    {
        //        2. Areas in Matrix
        //We are given a matrix of lettersof size N* M.Two cells areneighborif they share a common wall.Write a program
        // to find theconnected areasof neighbor cells holding the same letter.Display thetotal number of areasand
        // thenumber of areas for each alphabetical letter (ordered by alphabetical order).
        //On the first line is given the number of rows.
        //Examples
        //Input Picture Output
        //6
        //8
        //aacccaac
        //baaaaccc
        //baabaccc
        //bbdaaccc
        //ccdccccc

        //Areas: 8
        //Letter &#39;a&#39; -&gt; 2
        //Letter &#39;b&#39; -&gt; 2
        //Letter &#39;c&#39; -&gt; 3
        //Letter &#39;d&#39; -&gt; 1

        //© SoftUni – about.softuni.bg.Copyrighted document.Unauthorized copy, reproduction or use is not permitted.
        //Follow us: Page 1 of 10

        //ccdccccc
        //3
        //3
        //aaa
        //aaa
        //aaa

        //Areas: 1
        //Letter &#39;a&#39; -&gt; 1

        //5
        //9
        //asssaadas
        //adsdasdad
        //sdsdadsas
        //sdasdsdsa
        //ssssasddd

        //Areas: 21
        //Letter &#39;a&#39; -&gt; 6
        //Letter &#39;d&#39; -&gt; 7
        //Letter &#39;s&#39; -&gt; 8

        //Hint
        //Initially mark all cells as unvisited.Start arecursive DFS traversal(or BFS) from each unvisited cell and mark all
        //reached cells as visited.Each DFS traversal will find one of the connected areas.
        private static char[,] matrix;
        private static bool[,] visited;
        private static SortedDictionary<char, int> occurrence;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            matrix = new char[rows, cols];
            visited = new bool[rows, cols];
            occurrence = new SortedDictionary<char, int>();

            FillMatrix();

            SearchAreas(rows, cols);

            PrintAreas();
        }

        private static void PrintAreas()
        {
            int areas = occurrence.Sum(x => x.Value);
            Console.WriteLine($"Areas: {areas}");
            foreach (var kvp in occurrence)
            {
                Console.WriteLine($"Letter '{kvp.Key}' -> {kvp.Value}");
            }
        }

        private static void SearchAreas(int rows, int cols)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!visited[i, j])
                    {
                        DFS(i, j, matrix[i, j]);
                        if (!occurrence.ContainsKey(matrix[i, j]))
                        {
                            occurrence[matrix[i, j]] = 1;
                        }
                        else
                        {
                            occurrence[matrix[i, j]] += 1;
                        }
                    }
                }
            }
        }

        private static void DFS(int row, int col, char searchedAreaChar)
        {
            bool Out = IsOutOfBounds(row, col);
            if (Out || searchedAreaChar != matrix[row, col] || visited[row,col])
            {
                return;
            }

            visited[row, col] = true;

            DFS(row - 1, col, searchedAreaChar); // up
            DFS(row + 1, col, searchedAreaChar); // down
            DFS(row, col - 1, searchedAreaChar); // left
            DFS(row, col + 1, searchedAreaChar); // right
        }

        private static bool IsOutOfBounds(int row, int col)
        {
            return row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1);
        }

        private static void FillMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var currCol = Console.ReadLine();
                for (int j = 0; j < currCol.Length; j++)
                {
                    matrix[i, j] = currCol[j];
                }
            }
        }
    }
}
