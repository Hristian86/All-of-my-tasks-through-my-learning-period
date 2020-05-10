using System;
using System.Collections.Generic;
using System.Text;

namespace Recursions
{
    public class Reverse
    {
        public Reverse()
        {

        }

        public int ReverseArray(int[] arr, int index)
        {
            if (arr.Length == index)
            {
                Console.WriteLine();
                Console.WriteLine("Reversed:");
                return 0;
            }
            Console.Write(arr[index]);

            ReverseArray(arr,index + 1);

            Console.Write(arr[index]);
            return arr[index];
        }
    }
}