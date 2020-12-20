using System;

namespace PlusMinusTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 0, 0, -1, 1, 1, };
            plusMinus(arr);
        }

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive += 1;
                }
                else if (arr[i] < 0)
                {
                    negative += 1;
                }
                else if (arr[i] == 0)
                {
                    zero += 1;
                }
            }
            //Console.WriteLine(positive);
            //Console.WriteLine(arr.Length);
            Console.WriteLine(((positive * 01) / arr.Length).ToString("f6"));
            Console.WriteLine(((negative * 01) / arr.Length).ToString("f6"));
            Console.WriteLine(((zero * 01) / arr.Length).ToString("f6"));
        }
    }
}
