using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_7_TEXT_EXERS_STRING_EXPLOSION
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int parsedNum = 0;
            int leftovers = 0;
            int index = 0;
            int mathed = 0;
            int susu = 0;
            bool largerCount = false;
            
            for (int i = 0; i < text.Length - 1; i++)
            {
               
                if (text[i] == '>')
                {
                    // parse num for explosion
                    string temp = text[i + 1].ToString();
                    parsedNum = int.Parse(temp);    

                    // index of the explosionlsdn
                    index = text.IndexOf(text[i + 1]);
                    if (parsedNum > 1)
                    {

                        susu = index + parsedNum;
                        leftovers = parsedNum;
                        leftovers += mathed;
                        //   if (endOdArray)
                        // {
                        for (int j = i + 1; j < susu; j++)
                        {
                            if (susu > text.Length)
                            {
                                largerCount = true;
                                break;
                            }
                            else if (text[j] == '>')
                            {

                                mathed = Math.Abs(j - susu);
                                break;

                            }
                        }
                        // }
                        if (!largerCount)
                        {
                            if (!Calculated(i, index, parsedNum, text, mathed))
                            {
                                text = text.Remove(index, leftovers);
                            }
                            else
                            {
                                text = text.Remove(index, mathed);
                            }
                        }
                    }
                    else if (parsedNum == 1)
                    {
                        text = text.Remove(index, 1);
                    }
                    else if (parsedNum == 0)
                    {
                        text = text.Remove(index);
                    }
                }
                if (largerCount)
                {
                    text = text.Remove(text.Length-1);
                }
            }
            Console.WriteLine(text);
        }
        static bool Calculated(int i, int index, int parsedNum, string text, int mathed)
        {
            for (int j = i + 1; j < index + parsedNum; j++)
            {
                if (text[j] == '>')
                {
                    mathed = Math.Abs(j - (index + parsedNum));
                    return true;
                }
            }
            return false;
        }
    }
}