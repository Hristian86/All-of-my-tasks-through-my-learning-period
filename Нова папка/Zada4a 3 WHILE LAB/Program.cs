using System;

namespace Zada4a_3_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string connection = Console.ReadLine();

            while (!(connection == password))
            {
                connection = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");

        }
    }
}
