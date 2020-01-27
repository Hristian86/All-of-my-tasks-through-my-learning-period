using System;
using System.Numerics;

namespace zada4a_3_CLASSES_AND_OBJECTS_BIG_FACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger x = 1;
            for (int i = 1; i <= number; i++)
            {
                x *= i;
            }
            Console.WriteLine(x);

        }
    }
}
