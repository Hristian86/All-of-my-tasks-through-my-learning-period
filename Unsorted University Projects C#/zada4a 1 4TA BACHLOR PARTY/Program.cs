using System;

namespace zada4a_1_4TA_BACHLOR_PARTY
{
    class Program
    {
        static void Main(string[] args)
        {
            int singer = int.Parse(Console.ReadLine());
            int summary = 0;
            int count = 0;
            

            while (true)
            {
                string peopleCount = Console.ReadLine();
                if (peopleCount == "The restaurant is full")
                {
                    break;
                }
                int sumOfPeople = int.Parse(peopleCount);
                count += sumOfPeople;
                if (sumOfPeople < 5)
                {
                    summary += sumOfPeople * 100;
                }
                else 
                {
                    summary += sumOfPeople * 70;
                }
                
            }
            
            if (summary >= singer)
            {
                int result = summary - singer;
                Console.WriteLine($"You have {count} guests and {result} leva left.");
            }
            else if (summary < singer)
            {
                
                Console.WriteLine($"You have {count} guests and {summary} leva income, but no singer.");
            }
        }
    }
}
