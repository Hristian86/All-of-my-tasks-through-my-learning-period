using System;

namespace StipendiqCROS
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double succsess = double.Parse(Console.ReadLine());
            double minWorkPayment = double.Parse(Console.ReadLine());
            double socialStripendiq = minWorkPayment * 0.35;
            double ExelentStipendiq1 = succsess * 25;

            if (succsess >= 5.50)
            {
                if (ExelentStipendiq1 >= socialStripendiq || income >= minWorkPayment)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(ExelentStipendiq1));
                }
                else if (income < minWorkPayment && ExelentStipendiq1 < socialStripendiq)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialStripendiq));
                }

            }
            else if (succsess > 4.50 && income < minWorkPayment)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialStripendiq));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
