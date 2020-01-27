using System;

namespace Zada4a_3_TRAVELING_NESTED_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string text = Console.ReadLine();

                if (text == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());

                double counter = 0;

                while (counter < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    counter += money;
                }
                Console.WriteLine($"Going to " + text + "!");

            }
        }
    }
}
