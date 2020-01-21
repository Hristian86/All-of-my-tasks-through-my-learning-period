using System;

namespace Zada4a_1_COMBINATIONS_NESTED_LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int c = 0; c <= number; c++)
                    {
                        for (int e = 0; e <= number; e++)
                        {
                            for (int s = 0; s <= number; s++)
                            {
                                 
                                if (number == i + j + c + e + s)
                                {
                                    counter++;
                                }
                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
