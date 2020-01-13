using System;

namespace testifstate
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towel = double.Parse(Console.ReadLine());
            int procDiscount = int.Parse(Console.ReadLine());

            double umbrelaPrice = (towel * 2) / 3;
            double feetstraps = umbrelaPrice * 0.75;
            double beachPerse = (towel + feetstraps) / 3;

            double sum = (towel + umbrelaPrice + feetstraps + beachPerse)
                * (1-procDiscount/100.0);
            double abses = Math.Abs(budget - sum);

            if (sum <= budget)
            {
                Console.WriteLine($"Annie's sum is " +
                    $"{sum:f2} lv. She has {abses:f2} lv. " +
                    $"left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is " +
                    $"{sum:f2} lv. She needs {abses:f2} lv. " +
                    $"more.");
            }

        }
    }
}
