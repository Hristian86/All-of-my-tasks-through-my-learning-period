using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_5_MULTY_ARRAYS_SNKE
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] snake = new char[numbers[0], numbers[1]];

            char[] text = Console.ReadLine().ToCharArray();

            


        }
    }
}
