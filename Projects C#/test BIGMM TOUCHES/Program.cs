using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace test_BIGMM_TOUCHES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Logo => ");
            string num1 = Console.ReadLine();

            Engine(num1);
        }
        static void Engine(string num1)
        {
            int num = 0;

            while (true)
            {
                bool isNumber = int.TryParse(num1.ToString(), out num);
                if (!isNumber)
                {
                    Console.WriteLine("Length must be a number!");
                    Console.Write("Enter the length of the Logo: ");
                    num1 = Console.ReadLine();
                }
                else
                {

                    if (num >= 3 && num <= 10000)
                    {

                        if (num % 2 == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Length must be odd number!");
                            Console.Write("Enter the length of the Logo: ");
                            num1 = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lenght must be from 3 to 10000");
                        Console.Write("Enter the length of the Logo: ");
                        num1 = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine();

            string[] firstOne = new string[num + 1];
            string[] temp = new string[num + 1];
            string[] temp2 = new string[num + 1];
            var dict = new Dictionary<string[], string[]>();
            firstOne = FirstEngine(firstOne, num);
            firstOne = SecondEngine(firstOne, num);
            temp = ThirdEngine(temp, num);
            for (int i = 0; i < temp.Length; i++)
            {
                firstOne[i] += temp[i];
            }
            firstOne = SecondEngine(firstOne, num);
            temp2 = ForthEngine(temp2, num);
            for (int k = 0; k < temp2.Length; k++)
            {
                firstOne[k] += temp2[k];
            }

            // Array.Reverse(firstOne);
            var strbuild = new StringBuilder();
            string sesa = "";
            for (int i = 0; i < firstOne.Length; i++)
            {
                //Console.WriteLine($"{firstOne[i]}{firstOne[i]}");
                string sygh = Environment.NewLine;
                sesa += firstOne[i] + firstOne[i] + sygh;
            }
            Console.WriteLine(sesa.Trim());
        }
        static string[] ForthEngine(string[] firstOne, int num)
        {
            // this is 
            string seto2 = "";
            for (int i = 0; i <= num; i++)
            {

                for (int j = num; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        //Console.Write("*");
                        seto2 += "-";
                    }
                    else
                    {
                        // Console.Write("-");
                        seto2 += "*";
                    }

                }
                firstOne[i] += seto2;
                seto2 = "";
            }
            Array.Reverse(firstOne);
            return firstOne;
        }
        static string[] ThirdEngine(string[] firstOne, int num)
        {
            string seto2 = "";
            int gigi = 1;
            int teror = num / 2;
            for (int i = 0; i <= num; i++)
            {

                for (int j = num; j >= 1; j--)
                {

                    if (j <= i)
                    {
                        //Console.Write("*");
                        if (i >= num / 2 + 1)
                        {
                            if (j == num / 2 + 1)
                            {
                                for (int f = 0; f < gigi; f++)
                                {
                                    seto2 += "-";

                                }
                                gigi = gigi + 2;
                                for (int x = teror; x > 0; x--)
                                {
                                    seto2 += "*";
                                    // Console.Write(teror);
                                    //if (x == num)
                                    //{
                                    //    break;
                                    //}

                                }
                                teror--;
                                //  Console.WriteLine();
                            }

                            //else
                            //{
                            //    seto2 += "*";
                            //}

                        }
                        else
                        {
                            seto2 += "*";
                        }
                    }
                    else
                    {
                        //Console.Write("-");
                        seto2 += "*";
                    }

                }
                firstOne[i] += seto2;
                seto2 = "";
            }
            Array.Reverse(firstOne);
            return firstOne;
        }
        static string[] SecondEngine(string[] firstOne, int num)
        {
            string seto2 = "";
            int gigi = 1;
            int teror = num / 2;
            for (int i = 0; i <= num; i++)
            {

                for (int j = num; j >= 1; j--)
                {

                    if (j <= i)
                    {
                        //Console.Write("*");
                        if (i >= num / 2 + 1)
                        {
                            //var round = Math.Ceiling(num / 2.0);
                            //Console.WriteLine(round);
                            if (j == num / 2 + 1)
                            {
                                for (int f = 0; f < gigi; f++)
                                {
                                    seto2 += "-";

                                }
                                gigi = gigi + 2;
                                for (int x = teror; x > 0; x--)
                                {
                                    seto2 += "*";
                                    // Console.Write(teror);
                                    //if (x == num)
                                    //{
                                    //    break;
                                    //}

                                }
                                teror--;
                                //  Console.WriteLine();
                            }

                            //else
                            //{
                            //    seto2 += "*";
                            //}

                        }
                        else
                        {
                            seto2 += "*";
                        }
                    }
                    else
                    {
                        //Console.Write("-");
                        seto2 += "*";
                    }

                }
                firstOne[i] += seto2;
                seto2 = "";
            }
            return firstOne;
        }
        static string[] FirstEngine(string[] firstOne, int num)
        {
            string seto2 = "";
            for (int i = 0; i <= num; i++)
            {

                for (int j = num; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        //Console.Write("*");
                        seto2 += "*";
                    }
                    else
                    {
                        // Console.Write("-");
                        seto2 += "-";
                    }

                }
                firstOne[i] += seto2;
                seto2 = "";
            }
            return firstOne;
        }
    }
}