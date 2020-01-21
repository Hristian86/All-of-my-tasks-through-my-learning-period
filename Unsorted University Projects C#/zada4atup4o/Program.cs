using System;

namespace zada4atup4o
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 1000)
            {
                bonus = num * 0.1;  //10 procenta
            }
            else if (num <=1000 && num > 100)
            {
                bonus = num * 0.2; //20 rpcenta
            }   
               if (num % 2 == 0)
                {
                    bonus = bonus + 1;
                }
                else if (num % 10 == 5)
                {
                    bonus += 2;
                }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);



        }
    }
}
