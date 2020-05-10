using System;
using System.Linq;

namespace More_Recursion
{
    class Program
    {
        //        1. Recursive Array Sum
        //Write a program that finds the sum of all elements in an integer array.Use recursion.
        //Note: In practice recursion should not be used here (instead use an iterative solution), this is just an exercise.
        static void Main(string[] args)
        {

            //string[] arr = Console.ReadLine().Split(' ').ToArray();

            //int[] numbers = arr.Select(x => int.Parse(x)).ToArray();

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            var sums = GetSum(numbers,0);
            Console.WriteLine(sums);

        }
        static int GetSum(int[] numbers, int index)
        {
            if (numbers.Length == index)
            {
                return 0;
            }

            return numbers[index] + GetSum(numbers, index + 1);
        }
    }
}