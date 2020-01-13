using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace testove_BIG_MM_END_OF_NOVEMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            string setoKaiba = "";
            int num = 7;

            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    // Console.Write($"{i}");
                    setoKaiba += "*";
                }
                setoKaiba += Environment.NewLine;
                // Console.WriteLine();
            }
            string seto2 = "";
            // int count = 0;
            int sum = 0;

            List<BigMm> listOfBigMm = new List<BigMm>();
            var dict = new Dictionary<int, List<string>>();

            BigMm bigMm = new BigMm();

            int summary = 0;
            for (int i = 0; i <= num; i++)
            {
                summary++;
                for (int j = num; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        sum++;
                        //    Console.Write("*");
                        seto2 += "*";

                    }
                    else
                    {
                          //     Console.Write("-");
                        seto2 += "-";
                    }

                }

                seto2 += Engine(seto2, num, bigMm, summary);
                if (summary >= num / 2 + 2)
                {
                    for (int z = summary - 1; z < num; z++)
                    {
                        seto2 += "*";

                        //break;
                    }
                }
                if (i >= num / 2 + 2)
                {
                    for (int a = 1; a < summary; a++)
                    {
                        if (a > num / 2)
                        {
                            seto2 += "*";
                            
                        }
                        else if (a <= num / 2)
                        {
                            seto2 += "-";
                            
                        }
                    }
                }

                seto2 += Environment.NewLine;
                // Console.WriteLine();

               // Console.WriteLine(seto2);
               

                //seto2 = "";
            }
            bigMm.First = seto2;
            listOfBigMm.Add(bigMm);

            //foreach (var item in dict.Values)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in listOfBigMm)
            {
                Console.WriteLine(item.First);
            }


            //foreach (var item in listOfBigMm)
            //{
            //    Console.Write($"{item.First}");
            //}

        }
        static string Engine(string seto2, int num, BigMm bigMm, int summary)
        {
            string koko = "";
            int i = 0;
            //            string liolio = "";
            int r = num / 2 + 1;
            int pro = num;

            while (i < num)
            {
                i++;
                if (summary >= ((num / 2) + 2))
                {
                    //koko += "-";
                }
                else
                {
                    koko += "*";
                }
            }

            return koko;
        }
    }
    public class BigMm
    {
        public string First { get; set; }

        public string Second { get; set; }

        public string Third { get; set; }

        public string Forth { get; set; }

        public string Fifth { get; set; }

    }


}