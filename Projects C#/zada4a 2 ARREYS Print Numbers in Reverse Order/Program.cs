using System;
using System.Linq;

namespace zada4a_2_ARREYS_Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] revers = new int[num];
            
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                revers[i] = number;
            }
            for (int i = revers.Length - 1; i >= 0; i--)
            {
                Console.Write(revers[i] + " ");
            }
        }
    }
}
