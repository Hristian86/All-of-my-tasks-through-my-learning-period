using System;

namespace zada4a_7_METHODS_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Drawing(num);
        }
        static void Drawing(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num-1; j++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine(num);
            }
        }
    }
}
