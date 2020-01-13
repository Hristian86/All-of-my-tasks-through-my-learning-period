using System;

namespace zada4a_1_2ra_koleden_bazar
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetMoney = double.Parse(Console.ReadLine());
            int fentasy = int.Parse(Console.ReadLine());
            int horror = int.Parse(Console.ReadLine());
            int romance = int.Parse(Console.ReadLine());

            double sum = (fentasy * 14.90) + (horror * 9.80) + (romance * 4.30);
            sum *= 0.80;
            if (sum >= targetMoney)
            {
                double total = sum - targetMoney;
                double personTotal = Math.Floor(total * 0.10);
                double sumOfTotal = total - personTotal;
                targetMoney += sumOfTotal;
                Console.WriteLine($"{targetMoney:f2} leva donated.");
                Console.WriteLine($"Sellers will receive { personTotal} leva.");
            }
            else
            {
                double result2 = Math.Abs(targetMoney - sum);
                Console.WriteLine($"{result2:f2} money needed.");
            }
        }
    }
}
