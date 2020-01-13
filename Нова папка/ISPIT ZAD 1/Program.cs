using System;

namespace ISPIT_ZAD_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double mominPrice = double.Parse(Console.ReadLine());
            double loveCount = double.Parse(Console.ReadLine());
            double vosukRoses = double.Parse(Console.ReadLine());
            double keyHolders = double.Parse(Console.ReadLine());
            double karikaturi = double.Parse(Console.ReadLine());
            double luckySuprases = double.Parse(Console.ReadLine());

            double sum = (loveCount * 0.60) + (vosukRoses * 7.2) + (keyHolders * 3.60) + (karikaturi * 18.20) + (luckySuprases * 22);
            double count = loveCount + vosukRoses + keyHolders + karikaturi + luckySuprases;
            if (count > 25)
            {
                sum *= 0.65;
            }
            sum *= 0.90;
            if (sum > mominPrice)
            {
                sum -= mominPrice;
                Console.WriteLine($"Yes! {sum:f2} lv left.");
            }
            else if(mominPrice >= sum)
            {
                double result = Math.Abs(mominPrice - sum);
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
            
        }
    }
}
