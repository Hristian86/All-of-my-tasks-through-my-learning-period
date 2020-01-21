using System;

namespace Zadacha_3_WHILE_LABB
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            
            while (count <= number)
            {
                
                Console.WriteLine(count);
                count = count * 2 + 1;
            }
            //Console.WriteLine(count);

        }
    }
}
