using System;
using System.Linq;
namespace zada4a_8_ARRAYS_MAGIC_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            int previosNum = 0;
            int currentNum = 0;
            int counter = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                previosNum = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    currentNum = nums[j];
                    int sum = previosNum + currentNum;
                    if (sum == number)
                    {
                        Console.WriteLine(previosNum + " " + currentNum);
                    }
                    sum = 0;
                }
                
            }
        }
    }
}
