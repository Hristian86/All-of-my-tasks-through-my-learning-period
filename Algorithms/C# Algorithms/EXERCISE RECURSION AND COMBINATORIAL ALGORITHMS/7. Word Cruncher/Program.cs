using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Word_Cruncher
{
    class Program
    {
        private static List<string> consoleWords = new List<string> { "Word", "cruncher", "cr", "h", "unch", "c", "r", "un", "ch", "er", "a" };
        private static string word = "Wordcruncher";
        private static bool[] visited;
        private static Stack<string> result;
        private static string temp = "";
        private static Dictionary<int, List<string>> wordsByLen = new Dictionary<int, List<string>>();

        static void Main(string[] args)
        {
            result = new Stack<string>();
            visited = new bool[consoleWords.Count];

            foreach (var wordIn in consoleWords)
            {
                if (!word.Contains(wordIn))
                {
                    continue;
                }

                var length = wordIn.Length;

                if (!wordsByLen.ContainsKey(length))
                {
                    wordsByLen.Add(length, new List<string>());
                }

                wordsByLen[length].Add(wordIn);

            }

            GenSolution(word.Length);
        }

        private static void GenSolution(int length)
        {
            if (length == 0)
            {
                return;
            }

            foreach (var kvp in wordsByLen)
            {
                if (kvp.Key > length)
                {
                    continue;
                }

                foreach (var curWord in kvp.Value)
                {
                    temp += curWord;
                    if (IsMatching(word, curWord))
                    {
                        GenSolution(length - curWord.Length);
                    }

                    temp = temp.Remove(temp.Length - curWord.Length);
                }
            }
        }

        private static bool IsMatching(string expected, string actual)
        {
            for (int i = 0; i < actual.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void SumResult(int index, string tempWord)
        {
            if (index >= consoleWords.Count || temp.Length >= word.Length)
            {
                return;
            }

            for (int i = index; i < consoleWords.Count; i++)
            {
                if (!visited[i])
                {
                    SumResult(i + 1, tempWord);
                    visited[i] = false;
                }
            }
        }

        private static void StructResult(int index)
        {
            if (index >= consoleWords.Count || temp.Length >= word.Length)
            {
                return;
            }

            for (int i = index; i < consoleWords.Count; i++)
            {
                if (!visited[i])
                {
                    temp += consoleWords[i];
                    CompareStrings(i);
                    StructResult(i + 1);
                    visited[i] = false;
                }
            }
        }

        private static void CompareStrings(int index)
        {
            if (temp.Length == word.Length)
            {
                if (temp == word)
                {
                    visited[index] = true;
                    result.Push(temp);
                }
                else
                {

                }
            }
        }
    }
}
