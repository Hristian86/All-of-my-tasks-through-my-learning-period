using System;

namespace Zada4a_2_BUILDING_NESTED_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int colm = int.Parse(Console.ReadLine());
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 0; j < colm; j++)
                    if (i == rows)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                Console.WriteLine();
            }
        }
    }
}
