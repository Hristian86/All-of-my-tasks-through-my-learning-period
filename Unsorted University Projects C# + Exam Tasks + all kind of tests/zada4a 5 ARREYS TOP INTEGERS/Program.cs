using System;
using System.Linq;
namespace zada4a_5_ARREYS_TOP_INTEGERS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool chek = true;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        chek = false;
                    }
                }
                if (chek)
                {
                    Console.Write(nums[i]+" ");
                }
            }
        }

    }
}
