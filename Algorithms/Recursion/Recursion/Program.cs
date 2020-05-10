
using System;
using System.Linq;

namespace Recursion
{
    class Program
    {
        //        Part I - Recursive Array Sum
        //Write a program that finds the sum of all elements in an integer array.Use recursion.
        //Write a FindSum method.It will take as arguments the input array and the current index.
        // The method should return the current element + the sum of all next elements (obtained by recursively
        //calling FindSum).
        // The recursion should stop when there are no more elements in the array.
        static void Main(string[] args)
        {
            //    Console.Write("N = ");

            //    int number = int.Parse(Console.ReadLine());

            //    decimal factorial = Factorial(number);
            //    Console.WriteLine("{0}! = {1}",number,factorial);


            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            var sum = FindSumOfArr(arr,0);
            Console.WriteLine(sum);
            PrintFigure(5);
        }

        private static int FindSumOfArr(int[] arr, int index)
        {
            if (arr.Length == index)
            {
                return 0;
            }

            return arr[index] + FindSumOfArr(arr,index + 1);
        }

        private static void PrintFigure(int n)
        {
            if (n <= 0)
            {
                return;
            }

            //pevios
            Console.WriteLine(new string('*',n));

            PrintFigure(n - 1);

            // after
            Console.WriteLine(new string('#', n));

        }

        static decimal Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            Console.WriteLine(num);
            return num * Factorial(num - 1);
        }

    }
}