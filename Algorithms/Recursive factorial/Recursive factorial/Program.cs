using System;

namespace Recursive_factorial
{
    class Program
    {
        //        2. Recursive Factorial
        //Write a program that finds the factorial of a given number.Use recursion.
        //Note: In practice recursion should not be used here (instead use an iterative solution), this is just an exercise.
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int factorial = PrintFactorial(number);
            Console.WriteLine(factorial);
        }

        private static int PrintFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * PrintFactorial(number - 1);
        }
    }
}