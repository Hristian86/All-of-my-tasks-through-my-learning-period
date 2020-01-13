using System;

namespace ISPIT_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double monts = double.Parse(Console.ReadLine());
            double taxes = 0;
            double electricity = 0;
            double water = monts * 20;
            double internet = monts * 15;
            double other = 0;
            double avarege = 0;

            for (int i = 0; i < monts; i++)
            {
                taxes = double.Parse(Console.ReadLine());
                electricity += taxes;
                other += (taxes + 20 + 15) * 1.20;

            }
            avarege = (electricity + water + internet + other) / monts;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {avarege:f2} lv");

        }
    }
}
