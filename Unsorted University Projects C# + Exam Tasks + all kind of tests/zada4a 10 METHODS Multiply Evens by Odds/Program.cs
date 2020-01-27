using System;
using System.Linq;
namespace zada4a_10_METHODS_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = Math.Abs(int.Parse(Console.ReadLine()));
            ConvertingIntsToString(numbers);
        }
        static void ConvertingIntsToString(int numbers)
        {
            string numsAsString = Convert.ToString(numbers);
            //int oddNums = 0;
            //int evenNums = 0;
            string[] textNum = new string[numsAsString.Length];
            for (int i = 0; i < textNum.Length; i++)
            {
                textNum[i] = numsAsString[i].ToString();
            }
            TextIsNumber(textNum);
        }
        static void TextIsNumber(string[] textNum)
        {
            int oddNums = 0;
            int evenNums = 0;
            for (int i = 0; i < textNum.Length; i++)
            {
                int temp = int.Parse(textNum[i]);
                if (temp % 2 == 0)
                {
                    evenNums += temp;
                }
                else
                {
                    oddNums += temp;
                }
            }
            //int sum = evenNums * oddNums;
            //Console.WriteLine(sum);
            int sum = Summing(evenNums, oddNums);
            Console.WriteLine(sum);
        }
        static int Summing(int evenNums,int oddNums)
        {
            int sum = evenNums * oddNums;
            return sum;
        }
    }
}
