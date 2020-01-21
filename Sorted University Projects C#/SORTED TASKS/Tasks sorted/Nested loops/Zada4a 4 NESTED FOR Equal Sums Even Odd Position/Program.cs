using System;

namespace Zada4a_4_NESTED_FOR_Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            for (int i = minNum; i < maxNum; i++)
            {
                string current = i.ToString();
                int EvenSum = 0;
                int oddSum = 0;
                for (int j = 0; j < current.Length; j++)
                {
                    int temporaryNum = int.Parse(current[j].ToString());
                    if (j % 2 == 0)
                    {
                        EvenSum += temporaryNum;
                    }
                    else
                    {
                        oddSum += temporaryNum;
                    }

                }
                if (oddSum == EvenSum)
                {
                    Console.Write(i + " ");
                }
            }



        }
    }
}
