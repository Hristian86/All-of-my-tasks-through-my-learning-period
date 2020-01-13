using System;

namespace Zada4a_3_CODING_FOR_LOOP_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = Console.ReadLine();
            int numb = 0;
            for (int i = numberAsText.Length - 1; i >=0 ; i--)
            {
                char input = numberAsText[i];
                numb = int.Parse(input.ToString());
                if (numb == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for (int j = 1; j <=numb ; j++)
                {
                    
                    Console.Write((char)(numb + 33));
                }
                Console.WriteLine();   
            }
        }
    }
}