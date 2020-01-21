using System;

namespace Zada4a_6_IF_STATE_EXERSICE
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string placeForStayng = "";


            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget = budget * 0.30;
                }
                else
                {
                    budget = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget = budget * 0.40;
                }
                else
                {
                    budget = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                budget = budget * 0.90;
            }
            if (season == "summer")
            {
                if (budget > 1000)
                {
                    placeForStayng = "Hotel";
                }
                else
                {
                    placeForStayng = "Camp";
                }
            }
            else if (season == "winter")
            {
                placeForStayng = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeForStayng} - {budget:f2}");
        }
    }
}