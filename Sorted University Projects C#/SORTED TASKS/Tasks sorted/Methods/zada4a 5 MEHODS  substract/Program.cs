using System;

namespace zada4a_5_MEHODS__substract
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = MidleText(text);
            Console.Write(result);
        }
        static string MidleText(string text)
        {
            int counter = text.Length;
            int count = 0;
            string midleText = "";
            for (int i = 0; i < text.Length; i++)
            {
                count++;
                counter--;
                if (count == counter)
                {
                    midleText += text[i];
                    if (i % 2 == 0)
                    {
                        midleText += text[i + 1];
                    }
                    else
                    {
                        midleText += text[i + 1];
                    }
                }
                if (i % 2 == 1)
                {
                    if (count - 1 == counter)
                    {
                        midleText += text[i];
                    }
                }
            }
            return midleText;
        }
    }
}
