using System;

namespace Zada4a_6_MAGICAL_NUMBERS_FOR_LOOP_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int y = 1; y <= 9; y++)
                    {
                        for (int s = 1; s <= 9; s++)
                        {
                            for (int a = 1; a <= 9; a++)
                            {
                                for (int x = 1; x <= 9; x++)
                                {
                                    int product = a*j*y*s*a*x;
                                    if (product == number)
                                    {
                                        Console.Write($" {i}{j}{y}{s}{a}{x} ");
                                        
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
            

        }
    }
}
