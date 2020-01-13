using System;

namespace Zada4a_4_FOR_CIKAL_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxDiffrence = 0;
            int firstSum = 0;

            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                int numberses = int.Parse(Console.ReadLine());
                int sum = numbers + numberses;
                if (i == 0)
                {
                    firstSum = sum;
                }
                int difrence = Math.Abs(firstSum - sum);
                if (difrence > maxDiffrence)
                {
                    maxDiffrence = difrence;
                    firstSum = sum;
                }
                //firstSum = sum;
            }
            if (maxDiffrence == 0)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }
            else 
            {
                
                Console.WriteLine($"No, maxdiff={maxDiffrence}");
            }
        }
    }
}