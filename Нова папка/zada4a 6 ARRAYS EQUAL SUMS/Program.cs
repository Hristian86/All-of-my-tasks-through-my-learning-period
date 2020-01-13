using System;
using System.Linq;
namespace zada4a_6_ARRAYS_EQUAL_SUMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int counter = 0;
            int leftsSum = 0;
            int rightSum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if (leftsSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftsSum += nums[i];

            }
            Console.WriteLine("no");






            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            //int count = 0;
            //int symmary = 0;

            //int equals = 0;
            //bool chek = false;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums.Length == 1)
            //    {
            //        Console.WriteLine("0");
            //        return;
            //    }
            //    count += nums[i];
            //    for (int j = nums.Length - 1; j >= i; j--)
            //    {
            //        symmary += nums[j];
            //        if (count == symmary)
            //        {
            //            equals++;

            //        }

            //    }
            //    symmary = 0;

            //}
            //if (equals == 1 || equals == 0 )
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(equals);
            //}
        }
    }
}
