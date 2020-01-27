using System;
using System.Linq;
namespace zada4a_6_ARREYS_Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int summary = 0;
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    count += num;
                }
                else
                {
                    summary += num;
                }
            }
            int sum = count - summary;
            Console.WriteLine(sum);
        }
    }
}
