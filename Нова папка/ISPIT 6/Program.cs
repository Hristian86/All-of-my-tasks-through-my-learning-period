using System;

namespace ISPIT_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <= 8; i++)
            {
                for (int j = 9; j >= b; j--)
                {
                    for (int y = c; y <= 8; y++)
                    {
                        for (int z = 9; z >= d; z--)
                        {
                            if ((i % 2 == 0 && j % 2 == 1) && (y % 2 == 0 && z % 2 == 1))
                            {
                                
                                //if (!(i == j && y == z))
                                //{
                                    count++;
                                    if (count == 9)
                                    {
                                        return;
                                    }
                                    if ((i == y) && (j == z))
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.Write($" {i}{j} - {y}{z} ");

                                        Console.WriteLine();
                                    }
                                //}
                            }
                        }
                    }
                }
            }



            // 4eteri for cikala s 4eteri ifa za 4etno i ne4etno
        }
    }
}
