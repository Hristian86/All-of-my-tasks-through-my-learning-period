using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_3_STACK_AND_QUEUES
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<int> stak = new Stack<int>();
            
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch == '(')
                {
                    stak.Push(i);   
                }
                else if(ch == ')')
                {
                    int strInd = stak.Pop();
                    int calcul = Math.Abs((i - strInd));
                    string content = text.Substring(strInd, ++calcul);
                    Console.WriteLine(content);
                }
             }
        }
    }
}
