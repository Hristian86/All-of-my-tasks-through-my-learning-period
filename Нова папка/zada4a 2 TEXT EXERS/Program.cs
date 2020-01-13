using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_2_TEXT_EXERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ");
            string first = text[0];
            string second = text[1];
            int lenght = Math.Min(first.Length, second.Length);
            int sum = MultiPlayer(first, second, lenght);
            int totalOfDifrences = 0;
            if (first.Length > second.Length)
            {
                totalOfDifrences = MinerCalculate(first, lenght);
            }
            else
            {
                totalOfDifrences = MinerCalculate(second, lenght);
            }
            int totalSum = sum + totalOfDifrences;
            Console.WriteLine(totalSum);
        }
        static int MinerCalculate(string first, int leftOvers)
        {
            int nums = 0;
            for (int i = leftOvers; i < first.Length; i++)
            {
                nums += (int)first[i];
            }
            return nums;
        }
        static int MultiPlayer(string first, string second, int lenght)
        {
            int num = 0;
            for (int i = 0; i < lenght; i++)
            {
                int firstNum = (int)first[i];
                int secondNum = (int)second[i];
                num += firstNum * secondNum;
            }
            return num;
        }
    }
}