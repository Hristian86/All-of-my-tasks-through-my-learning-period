using System;

namespace Zada4a_5_IF_STATE_EXERSICE
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            byte fishman = byte.Parse(Console.ReadLine());

            double discountSeason = 0;

            if (season == "Spring")
            {
                discountSeason = 3000;
            }
            else if (season == "Winter")
            {
                discountSeason = 2600;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                discountSeason = 4200;
            }
            if (fishman <= 6)
            {
                discountSeason = discountSeason * 0.90;
            }
            else if (fishman >= 7 && fishman <= 11)
            {
                discountSeason = discountSeason * 0.85;
            }
            else if (fishman >= 12)
            {
                discountSeason = discountSeason * 0.75;
            }
            bool chek = fishman % 2 == 0;

            if (chek)
            {
                if (season == "Autumn")
                {
                    discountSeason = discountSeason * 1;
                }
                else //if (season == "Summer" || season == "Winter" || season == "Spring")
                {
                    discountSeason = discountSeason * 0.95;
                }
            }
            if (budget >= discountSeason)
            {
                Console.WriteLine($"Yes! You have {budget - discountSeason:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {discountSeason - budget:f2} leva.");
            }

        }
    }
}
