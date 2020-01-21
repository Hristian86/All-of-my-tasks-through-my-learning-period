using System;

namespace Zadara_8_METHODS_FACTORIEL
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = FacturOne(firstNum, secondNum);
            double result1 = FacturTwo(firstNum,secondNum);
            double sum = (result * 1.0 / result1);
            Console.WriteLine($"{sum:f2}");
        }
        static double FacturOne(double firstNum,double secondNum)
        {
            double factorialOne = 1;
            for (int i = 1; i < firstNum; i++)
            {
                factorialOne += factorialOne * i;
            }
            return factorialOne;
        }
        static double FacturTwo(double firstNum,double secondNum)
        {
            double factorialTwo = 1;
            for (int i = 1; i < secondNum; i++)
            {
                factorialTwo += factorialTwo * i;
            }
            return factorialTwo;
        }
    }
}
