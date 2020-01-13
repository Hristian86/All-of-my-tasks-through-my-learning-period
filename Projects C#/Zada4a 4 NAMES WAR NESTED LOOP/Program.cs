using System;

namespace Zada4a_4_NAMES_WAR_NESTED_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxValue = int.MinValue;
            int sum = 0;
            string winner = "";

            while (name != "STOP")
            { 
                for (int i = 0; i < name.Length; i++)
                {
                    sum = sum + name[i];
                    if (sum >= maxValue)
                    {
                        maxValue = sum;
                        winner = name;
                        
                    }
                }
                sum = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine("Winner is {0} - {1}!",winner,maxValue);
        }
    }
}
