using System;

namespace zada4a4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowminstay = int.MaxValue;
            string bestTiketNum = "";
            double bestTiketNoStay = double.MaxValue;

            string tiketnum = Console.ReadLine();
            while (tiketnum != "End")
            {
                double tiketPrice = double.Parse(Console.ReadLine());
                int minutesStay = int.Parse(Console.ReadLine());

                tiketPrice = tiketPrice * 1.96;
                if (minutesStay < lowminstay)
                {
                    bestTiketNoStay = tiketPrice;
                    bestTiketNum = tiketnum;
                    lowminstay = minutesStay;
                }

                tiketnum = Console.ReadLine();

            }
            Console.WriteLine($"Ticket found for flight {bestTiketNum} " +
                $"costs {bestTiketNoStay:F2} leva with {lowminstay / 60}h" +
                $" {lowminstay % 60}m stay");



        }
    }
}
