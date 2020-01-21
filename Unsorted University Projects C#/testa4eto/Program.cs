using System;

namespace testa4eto
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine()) * 1000;

            double lemonJuice = lemonKg * 980;
            double lemonade = lemonJuice + water;
            lemonade += sugarKg * 0.3;

            double cups = Math.Floor(lemonade / 150);
            double finalPrice = cups * 1.2;

            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {finalPrice:F2}");
        }
    }
}
