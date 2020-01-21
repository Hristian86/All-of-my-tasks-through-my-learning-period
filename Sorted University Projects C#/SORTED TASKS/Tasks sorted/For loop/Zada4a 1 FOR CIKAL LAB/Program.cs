using System;

namespace Zada4a_1_FOR_CIKAL_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == 'a')
                {
                    counter++;
                }
                else if (letter == 'e')
                {
                    counter += 2;
                }
                else if (letter == 'i')
                {
                    counter += 3;
                }
                else if (letter == 'o')
                {
                    counter += 4;
                }
                else if (letter == 'u')
                {
                    counter += 5;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
