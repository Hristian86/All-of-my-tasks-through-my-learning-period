using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double longMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double sumMetersTime = longMeters * timeInSeconds;
            double additionalTime = Math.Floor(longMeters / 15);
            double oditionalTime = additionalTime * 12.5;
            double sumTime = sumMetersTime + oditionalTime;
            double totall = Math.Abs(record - sumTime);
            double total = totall;

            if (record <= sumTime)
            {
                Console.WriteLine($"No, he failed! He was {total:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
            }
        }
    }
}
