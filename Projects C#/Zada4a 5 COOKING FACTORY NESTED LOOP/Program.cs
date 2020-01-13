using System;

namespace Zada4a_5_COOKING_FACTORY_NESTED_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (count > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(count + " ");
                    count++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
