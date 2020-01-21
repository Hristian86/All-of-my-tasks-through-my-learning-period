using System;

namespace Zada4a_7_IF_STATE_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string calculate = Console.ReadLine();
            double sum = 0;

            if (number2 == 0)
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
                return;
            }
            else if (calculate == "+")
            {
                sum = number1 + number2;
            }
            else if (calculate == "-")
            {
                sum = number1 - number2;
            }
            else if (calculate == "*")
            {
                sum = number1 * number2;
            }
            else if (calculate == "/")
            {
                sum = number1 / number2;
            }
            else if (calculate == "%")
            {
                sum = number1 % number2;
            }
            bool chek = sum % 2 == 0;
            string cheked = "";
            if (chek == true)
            {
                cheked = "even";
            }
            else
            {
                cheked = "odd";
            }
            if ( calculate == "%" )
            {
                Console.WriteLine($"{number1} {calculate} {number2} = {sum}");
            }
            else if (calculate == "/")
            {
                Console.WriteLine($"{number1} {calculate} {number2} = {sum:f2}");
            }
            else
            {
                Console.WriteLine($"{number1} {calculate} {number2} = {sum} - {cheked}");
            }
        }
    }
}