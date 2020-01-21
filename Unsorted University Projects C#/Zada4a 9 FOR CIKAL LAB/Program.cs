using System;

namespace Zada4a_9_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(count);
                count = count * 4;
            }



        }
    }
}
