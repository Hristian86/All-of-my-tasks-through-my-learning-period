using System;
using System.Linq;

namespace RevArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            ReverseArr(arr, 0);
            Console.WriteLine(string.Join(" ", arr));
        }

        //private static void ReverseArr(int[] arr, int index)
        //{
        //    var loop = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1 ;
        //    for (int i = 0; i < loop; i++)
        //    {
        //        var last = arr[arr.Length - i - 1];
        //        var first = arr[i];
        //        arr[i] = last;
        //        arr[arr.Length - i - 1] = first;
        //    }
        //}

        private static void ReverseArr(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                arr[0] = arr[arr.Length - 1];
                return;
            }

            int dp = arr[arr.Length - index - 2];

            index += 1;

            ReverseArr(arr, index);
            arr[index] = dp;
        }
    }
}