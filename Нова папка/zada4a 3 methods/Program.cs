using System;

namespace zada4a_3_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Calculations(command);
        }
        static void Calculations(string command)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (command == "divide")
            {
                int sum = firstNum / secondNum;
                Console.WriteLine(sum);
            }
            else if (command == "subtract")
            {
                int sum = firstNum - secondNum;
                Console.WriteLine(sum);
            }
            else if (command == "add")
            {
                int sum = firstNum + secondNum;
                Console.WriteLine(sum);
            }
            else if (command == "multiply")
            {
                int sum = firstNum * secondNum;
                Console.WriteLine(sum);
            }
        }
    }
}
