using System;

namespace zada4a_9_METHODS_PALINDROME
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "END")
                {
                    break;
                }
                bool isSimetric = false;
                bool result = ChekingForSimetric(text, isSimetric);
                if (result)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
        static bool ChekingForSimetric(string text,bool isSimetric)
        {
            //bool chek = false;
            //isSimetric = false;
            //if (text[0] == text[2])
            //{
            //    chek = true;
            //}
            //else
            //{
            //    chek = false;
            //}
            //if (chek)
            //{
            //    isSimetric = true;
            //}
            //else
            //{
            //    isSimetric = false;
            //}
            //return isSimetric;
            int count = text.Length;
            string symmary = "";
            string counter = "";
            int numCounter = 0;
            for (int i = 0; i < text.Length / 2; i++)
            {
                symmary += text[i];
                for (int j = text.Length / 2; j < text.Length; j++)
                {
                    counter += text[j];
                    if (symmary[i] == counter[j])
                    {
                        return isSimetric = true;
                    }
                    else
                    {
                        return isSimetric = false;
                    }
                }
            }
            
            
            return isSimetric;
        }
    }
}
