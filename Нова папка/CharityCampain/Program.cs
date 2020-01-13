using System;

namespace CharityCampain
{
    class Program
    {
        static void Main(string[] args)
        {
            double promotionDays = int.Parse(Console.ReadLine());
            double sweetsCooks = int.Parse(Console.ReadLine());
            double tortes = int.Parse(Console.ReadLine());
            double gofretes = int.Parse(Console.ReadLine());
            double palachinki = int.Parse(Console.ReadLine());

            double sum1 = tortes * 45;
            double sum2 = gofretes * 5.80;
            double sum3 = palachinki * 3.20;

            double resultPerDay = (sum1 + sum2 + sum3) * sweetsCooks;
            double moneyForPromo = resultPerDay * promotionDays;
            double perCook = moneyForPromo / sweetsCooks;
            double cleenResult = (moneyForPromo / 8) * 7;
            Console.WriteLine($"{cleenResult:f2}");
        }
    }
}
