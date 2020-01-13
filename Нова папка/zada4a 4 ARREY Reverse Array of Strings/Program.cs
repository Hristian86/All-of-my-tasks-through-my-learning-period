using System;

namespace zada4a_4_ARREY_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rever = Console.ReadLine().Split(' ');
            for (int i = 0; i < rever.Length; i++)
            {
                //Console.WriteLine(rever[i]);
            }
            string[] reverse = rever;
            for (int i = reverse.Length-1; i >= 0 ; i--)
            {
                Console.Write(reverse[i]+ " ");
            }

        }
    }
}
