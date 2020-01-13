using System;

namespace zada4a_9_METHODS_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Options(command);
        }
        static void Options(string command)
        {

            if (command == "int")
            {
                Numbers(command);
            }
            if (command == "char")
            {
                Characters(command);
            }
            if (command == "string")
            {
                StrAsText(command);
            }
        }
        static void Numbers(string command)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num1);
            }
        }
        static void StrAsText(string command)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            int textExit1 = 0;
            int textExit2 = 0;
            for (int i = 0; i < text1.Length; i++)
            {
                char sum1 = (char)text1[i];
                textExit1 += sum1;
            }
            for (int j = 0; j < text2.Length; j++)
            {
                char sum2 = (char)text2[j];
                textExit2 += sum2;
            }
            if (textExit1 <= textExit2)
            {
                Console.WriteLine(text2);
            }
            else
            {
                Console.WriteLine(text1);
            }
        }
        static void Characters(string command)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            int sum1 = (int)letter1;
            int sum2 = (int)letter2;
            if (sum1 < sum2)
            {
                Console.WriteLine(letter2);
            }
            else
            {
                Console.WriteLine(letter1);
            }
        }
    }
}
