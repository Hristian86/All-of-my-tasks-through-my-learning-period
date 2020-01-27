using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_6_CLASSES_STUDENTS_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] independent = text.ToCharArray();
            int[] nums = new int[independent.Length];
            var testing = new List<string>();
            for (int i = 0; i < independent.Length; i++)
            {
                string num = independent[i].ToString();
                char nymes = independent[i];
                nums[i] = int.Parse(num);
                
                    int numb = nums[i];
                    for (int s = 0; s < numb; s++)
                    {
                        Console.Write(numb);
                    string temp = numb.ToString();
                    testing.Add(temp);
                    
                    }
                testing.Add(" ");
                Console.WriteLine();
            }
            for (int i = independent.Length-1; i > 0; i--)
            {
                string num = independent[i].ToString();
                char nymes = independent[i];
                nums[i] = int.Parse(num);

                int numb = nums[i-1];
                for (int s = numb; s > 0; s--)
                {
                    Console.Write(numb);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(string.Join(" ",testing));
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int nym = (char)nums[i];
            //    char nymes = (char)nym;
            //    //Console.WriteLine(nymes);
            //}

            //Console.WriteLine(string.Join(" ",nums));
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int number = nums[i];
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(string.Join(" ",independent));



        }
    }
}
