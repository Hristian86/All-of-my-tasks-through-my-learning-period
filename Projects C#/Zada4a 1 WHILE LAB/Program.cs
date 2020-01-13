using System;

namespace Zada4a_1_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool chek = number < 1 || number > 100;
            while (chek)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
                chek = number < 1 || number > 100;
            }
            Console.WriteLine("The number is: {0}",number);
        }
    }
}
