using System;

namespace zada4a_1_KOLEDNA_UKRASA_6TA_CHAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            while (true)
            {
                string item = Console.ReadLine();
                if (item == "Stop")
                {
                    break;
                }
                
                for (int i = 0; i < item.Length; i++)
                {
                    char tempsum = item[i];
                    sumOfChars += tempsum;       
                }

                if (sumOfChars < budget)
                {
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    break;
                }
            }
            int result = budget - sumOfChars;
            if (sumOfChars < budget)
            {
                Console.WriteLine("Money left: " + result);
            }
            else
            {
                Console.WriteLine("Not enough money!");
            }
        }
    }
}