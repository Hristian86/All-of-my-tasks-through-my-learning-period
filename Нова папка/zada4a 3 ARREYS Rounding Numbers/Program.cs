using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a_3_ARREYS_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} => {1}", nums[i], Math.Round(nums[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
