using System;

namespace zada4a_1_BITWISE_OPERATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count0 = 0;
            int count1 = 0;

            string result = "";
            while (a > 0)
            {
                if (a%2==1)
                {
                    count1++;
                    result += 1;
                }
                else
                {
                    count0++;
                    result += 0;
                }
                a /= 2;
            }
            string[] reversestr = new string[result.Length];
            for (int i = 0; i < reversestr.Length; i++)
            {
                reversestr[i] = result[i].ToString();
            }
            Array.Reverse(reversestr);
            //Console.WriteLine(string.Join("",reversestr));
            if (b == 0)
            {
                Console.WriteLine(count0);
            }
            else
            {
                Console.WriteLine(count1);
            }
        }
    }
}