using System;

namespace Zada4a_4_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfincomes = int.Parse(Console.ReadLine());
            int count = 0;
            double zoro = 0;

            while (count < numberOfincomes)
            {
                count++;
                double income = double.Parse(Console.ReadLine());
                if (income <=0)
                {
                    Console.WriteLine("Invalid operation!");
                    //Console.WriteLine($"Total: {zoro:f2}");
                    break;
                }
                zoro = zoro + income;
                Console.WriteLine($"Increase: {income:f2}" );
            }
            Console.WriteLine($"Total: {zoro:f2}");

        }
    }
}
