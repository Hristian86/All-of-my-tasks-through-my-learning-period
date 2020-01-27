using System;

namespace Zada4a_1_MATRIX_LOOP_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int y = c; y <= d; y++)
                    {
                        for (int z = c; z <= d; z++)
                        {
                            if (((i+z) == (j+y) && (i != j) && (y != z)))
                            {
                                Console.WriteLine($"{i}{j}");
                                Console.WriteLine($"{y}{z}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
