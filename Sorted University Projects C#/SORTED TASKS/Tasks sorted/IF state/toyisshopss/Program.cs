using System;

namespace Toyshop
{
    class Program
    {
        public static void Main(string[] args)
        {
            double ekskurziq = double.Parse(Console.ReadLine());
            double puzels = double.Parse(Console.ReadLine());
            double dols = double.Parse(Console.ReadLine());
            double bears = double.Parse(Console.ReadLine());
            double minioni = double.Parse(Console.ReadLine());
            double kamion = double.Parse(Console.ReadLine());

            double sum1 = puzels * 2.60 + dols * 3 + bears * 4.10 +
                minioni * 8.20 + kamion * 2;
            double sum2 = sum1;
            double counttoys = puzels + dols + bears + minioni + kamion;
            if (counttoys >= 50)
            {
                sum2 = sum2 * 0.75;
            }
            double price = sum2 * 0.90;
            if (price >= ekskurziq)
            {
                price = price - ekskurziq;
                Console.WriteLine($"Yes! {price:f2} lv left.");
            }
            else if (price < ekskurziq)
            {
                price = ekskurziq - price;
                Console.WriteLine($"Not enough money! {price:f2} lv needed.");
            }
        }
    }
}