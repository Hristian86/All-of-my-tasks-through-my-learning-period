using System;

namespace zada4a_4_METHODS_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            FirstPiramid(num);
        }
        static void FirstPiramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                InnerLoop(i);
            }
            SecondPiramid(num);
        }
        static void SecondPiramid(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                InnerLoop(i);
            }
        }
        static void InnerLoop(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
