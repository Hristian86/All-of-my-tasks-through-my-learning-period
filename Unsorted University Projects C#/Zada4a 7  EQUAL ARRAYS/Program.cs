using System;
using System.Linq;
namespace Zada4a_7__EQUAL_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsFirst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numsSecond = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int first = 0;
            int second = 0;
            int counter = 0;
            bool identical = true;
            for (int i = 0; i < numsFirst.Length; i++)
            {
                first += numsFirst[i];
                second += numsSecond[i];
                if (numsFirst[i] == numsSecond[i])
                {

                }
                else
                {
                    identical = false;
                    counter++;
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index", i);
                    break;
                }
            }
            //for (int j = 0; j < numsSecond.Length; j++)
            //{
            //    second += numsSecond[j];

            //}
            int sum = first = second;
            if (identical)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", sum);
            }
            //else
            //{
            //    Console.WriteLine("Arrays are not identical. Found difference at {0} index", counter);
            //}
        }
    }
}
