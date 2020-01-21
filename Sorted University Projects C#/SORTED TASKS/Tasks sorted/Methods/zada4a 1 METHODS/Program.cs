using System;

namespace zada4a_1_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums =int.Parse(Console.ReadLine());
            PringNum(nums);

        }
        static void PringNum(int nums)
        {

            if (nums > 0)
            {
                Console.WriteLine($"The number {nums} is positive.");
            }
            else if (nums < 0)
            {
                Console.WriteLine($"The number {nums} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {nums} is zero.");
            }

        }
    }
}
