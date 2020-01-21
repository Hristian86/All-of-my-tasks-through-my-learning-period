using System;

namespace Zada4a_12_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double whasherPrice = double.Parse(Console.ReadLine());
            int toys = int.Parse(Console.ReadLine());
            int sumOfToysAtAge = 0;
            
            int count = 0;
            double summary = 0;
            double hooke = 0;
            int counter = 0;
            //double sum = sumOfToysAtAge * toys;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    count++;
                    summary = count * 10;
                    hooke += summary;
                }
                if (i % 2 == 1)
                {
                    //counter++;
                    sumOfToysAtAge++;
                }
            }
            double sum = sumOfToysAtAge * toys;
            double sums = sum + (hooke - counter);
            double total = Math.Abs (sums - whasherPrice);
            double sum5 = whasherPrice - sums;
            if (whasherPrice > sums)
            {
                Console.WriteLine($"No! {sum5:f2}");
            }
            if (sums >= whasherPrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(sum5):f2}");
            }
        }
    }
}
