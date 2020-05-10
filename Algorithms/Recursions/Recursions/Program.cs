using System;

namespace Recursions
{
    class Program
    {
        //basic recursion test
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int sum = PrintRec(arr, 0);
            Console.WriteLine($"Recursive array sum = {sum}");

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(" - - - - - ");
            Reverse reverse = new Reverse();
            var reverseArray = reverse.ReverseArray(arr,0);

        }

        private static int PrintRec(int[] arr, int index)
        {
            if (arr.Length == index)
            {
                return 0;
            }
            Console.WriteLine(arr[index]);
            return arr[index] + PrintRec(arr, index + 1);

        }
    }
}
