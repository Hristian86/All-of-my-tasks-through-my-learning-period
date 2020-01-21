using System;
using System.Linq;
namespace zada4a_5_ARREYS_Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int even = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    even += num;

                }
            }
            Console.WriteLine(even);
        }
    }
}
