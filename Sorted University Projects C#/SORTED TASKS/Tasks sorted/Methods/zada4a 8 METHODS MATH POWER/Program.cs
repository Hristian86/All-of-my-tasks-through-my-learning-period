using System;

namespace zada4a_8_METHODS_MATH_POWER
{
    class Program
    {
        static void Main(string[] args)
        {
            double nums = double.Parse(Console.ReadLine());
            double numsPow = double.Parse(Console.ReadLine());
            double coun = Sum(nums, numsPow);
            Console.WriteLine(coun);
        }
        static double Sum(double nums, double numsPow)
        {
            double count = Math.Pow(nums, numsPow);
            return count;
        }
    }
}
