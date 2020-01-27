using System;

namespace zada4izaispit
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthPay = double.Parse(Console.ReadLine());
            double monthsSavings = double.Parse(Console.ReadLine());
            double personalMoney = double.Parse(Console.ReadLine());

            double emergencySavings = (0.3 * monthPay);
            double savingsPerMonth = monthPay - (personalMoney + emergencySavings);
            double legitSaves = monthsSavings * savingsPerMonth;
            double percentege = savingsPerMonth /monthPay*100;

            Console.WriteLine("She can save {0:f2}%",percentege);
            Console.WriteLine($"{legitSaves:f2}");

        }
    }
}
