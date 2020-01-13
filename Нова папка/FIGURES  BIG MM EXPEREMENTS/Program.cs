using System;

namespace FIGURES__BIG_MM_EXPEREMENTS
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int num = int.Parse(Console.ReadLine());
            string leftSide = "";
            string rightSide = "";
            //string middle = "";
            string reforgeNum = "";
            var leftRight = (num+1)/2;
            while (num <= 2 || num >=10000)
            {
                Console.WriteLine("Invalid number");
                num = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= num; i++)
            {
                reforgeNum += ("*"); //i.ToString();
                leftSide += ("-");
                rightSide += ("-");
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*',num));
                var mid = num - 2 * leftRight;
                if (mid >= 0)
                { 
                    Console.Write(new string('-', mid));
                    Console.Write(new string('*',num));
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }
            //string sum = leftSide + reforgeNum + rightSide;
            //Console.Write(new string('-', num) + new string('*', num) + new string('-', num));
            //Console.Write(leftSide + reforgeNum + rightSide);
            //Console.WriteLine(sum+sum+sum);

        }
    }
}
