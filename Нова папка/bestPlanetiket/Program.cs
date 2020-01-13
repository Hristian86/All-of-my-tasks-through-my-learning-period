using System;

namespace bestPlanetiket
{
    class Program
    {
        static void Main(string[] args)
        {

            int lowestMinsStay = int.MaxValue;
            string bestTicketNumber = "";
            double bestTicketNoTransferPrice = double.MaxValue;

            string ticketNumber = Console.ReadLine();
            while (ticketNumber != "End")
            {
                double ticketPrice = double.Parse(Console.ReadLine());
                int minutesStay = int.Parse(Console.ReadLine());

                ticketPrice = ticketPrice * 1.96;
                if (minutesStay < lowestMinsStay)
                {
                    bestTicketNoTransferPrice = ticketPrice;
                    bestTicketNumber = ticketNumber;
                    lowestMinsStay = minutesStay;
                }

                ticketNumber = Console.ReadLine();
            }

            Console.WriteLine($"Ticket found for flight {bestTicketNumber} costs {bestTicketNoTransferPrice:F2} leva with {lowestMinsStay / 60}h {lowestMinsStay % 60}m stay");

        }
    }
}
