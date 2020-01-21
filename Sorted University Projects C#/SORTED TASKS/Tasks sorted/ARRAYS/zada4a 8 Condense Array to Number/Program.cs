using System;
using System.Linq;

namespace zada4a_8_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = nums.Length;
            int sum = nums.Length;

            for (int i = sum; i > 1; i--)
            {
                //int[] condensed = new int[nums.Length - 1];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j] + nums[j + 1];
                    Console.WriteLine(nums[j]);
                }
                //sum--;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
