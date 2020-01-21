using System;
using System.Linq;
namespace zada4a_7_ARRAYS_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int counter = 1;
            int symmary = 1;
            int theNumber = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int previosNum = nums[i - 1];
                int presentNum = nums[i];

                if (presentNum == previosNum)
                {
                    counter++;
                    if (counter > symmary)
                    {
                        symmary = counter;
                        theNumber = presentNum;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < symmary; i++)
            {
                Console.Write(theNumber +" ");
            }
        }
    }
}
