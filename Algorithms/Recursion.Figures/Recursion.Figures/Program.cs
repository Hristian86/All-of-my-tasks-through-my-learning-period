using System;

namespace Recursion.Figures
{
    class Program
    {
        //        3. Recursive Drawing
        //Write a program that draws the figure below depending on n.Use recursion.
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            PrintFigure(number);

        }

        private static void PrintFigure(int number)
        {
            if (number == 0)
            {
                return ;
            }

            Console.WriteLine(new string('*',number));

            PrintFigure(number-1);

            Console.WriteLine(new string('#',number));
        }
    }
}
