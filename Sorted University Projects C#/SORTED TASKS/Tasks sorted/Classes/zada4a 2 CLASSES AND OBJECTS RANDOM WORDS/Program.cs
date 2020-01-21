using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace zada4a_2_CLASSES_AND_OBJECTS_RANDOM_WORDS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            var rng = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randInt = rng.Next(0,words.Length-1);
                Console.WriteLine(words[randInt]);
                    
            }

        }
    }
}
