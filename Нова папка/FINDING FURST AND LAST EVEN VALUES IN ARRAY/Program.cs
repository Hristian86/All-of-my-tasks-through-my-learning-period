using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_LISTS_EXERCISE_TRAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Array.Sort(nums);
            Array.Reverse(nums);

            int[] temp = new int[number];
            //int count = 0;
            int counter = 0;
            int symmary = 0;
            for (int i = 0; i < temp.Length; i++)
            {

                //if (counter > 0)
                //{
                //    count = temp[i - 1];

                //}
                for (int j = counter; j < nums.Length; j++)
                {
                    ++counter;
                    int tempNums = nums[i];
                    if (nums[j] % 2 == 0)
                    {
                        temp[i] = nums[j];
                        j = counter;
                        symmary++;
                        break;
                    }
                }
            }

            string display = string.Join(", ", temp);
            if (symmary < number)
            {
                Console.WriteLine("no matches");
            }
            else
            {
                Console.WriteLine($"[{display}]");
                string index = (counter - 1).ToString();
                Console.WriteLine("{" + index + "}");
            }
        }
    }
}
