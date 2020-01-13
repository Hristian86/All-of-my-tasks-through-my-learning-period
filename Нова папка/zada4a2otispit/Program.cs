using System;

namespace zada4a2otispit
{
    class Program
    {
        static void Main()
        {
            double lemonsKg = double.Parse(Console.ReadLine());
            double shugarkg = double.Parse(Console.ReadLine());
            double waterLit = double.Parse(Console.ReadLine()) * 1000;

            double lemonjuse = lemonsKg * 980;
            double shugarmix = lemonjuse + waterLit + (shugarkg * 0.30);
            double cups = Math.Floor(shugarmix / 150);
            double totalP = cups * 1.2;

            Console.WriteLine("All cups sold: {0}",cups);
            Console.WriteLine($"Money earned: {totalP:f2}");



        }
    }
}
