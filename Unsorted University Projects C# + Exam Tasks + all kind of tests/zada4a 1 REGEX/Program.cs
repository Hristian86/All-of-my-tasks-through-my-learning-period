using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zada4a_1_REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matched = Regex.Matches(names, regex);
            int count = 0;
 //           bool counted = false;
            string items = "";
            foreach (Match item in matched)
            {
                for (int i = 0; i < matched.Count; i++)
                {
                    if (item.Value == matched[i].ToString())
                    {
                        count++;
                        if (count == 1)
                        {
                            items += item.Value + " ";
                        }
                        else if (count > 1)
                        {
   //                         counted = true;
                        }
                        // counted = true;
                    }
                }

                if (items.Contains(item.Value))
                {
                    items += item.Value + " ";
                //    Console.WriteLine(item.Value + " ");
                }
               count = 0;
                //if (item.Value == "Ivan Ivanov")
                //{
                //    count++;
                //    if (count == 1)
                //    {
                //        Console.Write(item.Value + " ");
                //    }
                //}
                //else
                //{
                //    Console.Write(item.Value + " ");
                //}
            }
            Console.WriteLine(items);
            Console.WriteLine();
        }
    }
}