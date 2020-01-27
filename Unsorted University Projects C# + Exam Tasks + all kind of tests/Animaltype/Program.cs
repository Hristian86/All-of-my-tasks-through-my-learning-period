using System;

namespace Animaltype
{
    class Program
    {
        static void Main(string[] args)
        {
            double sofiq = 48;

            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double gamesInSofiq = sofiq - weekends;
            double saturday = (gamesInSofiq * 3) / 4;
            double inHolydays = (holidays * 2) / 3;
            double sumGames = saturday + weekends + inHolydays;

            if (yearType == "leap")
            {
                sumGames *= 1.15;
            }
            else
            {
                sumGames *= 1;
            }

            Console.WriteLine($"{Math.Floor(sumGames)}");


        }
    }
}
