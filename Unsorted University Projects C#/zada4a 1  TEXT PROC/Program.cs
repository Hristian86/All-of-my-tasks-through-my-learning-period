using System;
using System.Text;

namespace zada4a_1__TEXT_PROC
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = "";
            //string reversedComand = "";
            StringBuilder susu = new StringBuilder();
            while ((comand = Console.ReadLine()) != "end")
            {
                for (int i = comand.Length-1; i >= 0; i--)
                {
                    susu.Append(comand[i]);
                }
                Console.WriteLine($"{comand} = {susu}");
                susu = new StringBuilder();
            }
        }
    }
}