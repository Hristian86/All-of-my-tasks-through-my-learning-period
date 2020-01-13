using System;

namespace zada4a_6TA_BILETI_ZA_KINOTO___
{
    class Program
    {
        static void Main(string[] args)
        {

            double count = 0;
            double student = 0;
            double standard = 0;
            double kid = 0;
            int symmary = 0;
            string movie = Console.ReadLine();

            while (!(movie == "Finish"))
            {

                string tiketType = "";
                
                int freeSlots = int.Parse(Console.ReadLine());

                for (int i = 0; i < freeSlots; i++)
                {
                    
                    tiketType = Console.ReadLine();
                    
                    if (tiketType == "End")
                    {
                        break;
                    }
                    if (tiketType == "student")
                    {
                        student++;
                    }
                    else if (tiketType == "standard")
                    {
                        standard++;
                    }
                    else if (tiketType == "kid")
                    {
                        kid++;
                    }
                    symmary++;
                    count++;
                }
                double sum = ((symmary * 100) * 1.00) / freeSlots;

                Console.WriteLine($"{movie} - {sum:f2}% full.");
                symmary = 0;
                movie = Console.ReadLine();
                //if (tiketType == "Finish")
                //{
                //    break;
                //}
            }
            Console.WriteLine($"Total tickets: {count}");
            double result1 = PercentegeCalcolate(count, student);
            
            Console.WriteLine($"{result1:f2}% student tickets.");
            double result2 = PercentegeCalcolate(count, standard);
            
            Console.WriteLine($"{result2:f2}% standard tickets.");

            double result3 = PercentegeCalcolate(count, kid);
            
            Console.WriteLine($"{result3:f2}% kids tickets.");

        }
        static double PercentegeCalcolate(double count, double tiketSort)
        {
            double sum2 = (tiketSort * 100) / count;
            //double sum3 = Math.Ceiling(sum2);
            return sum2;
        }
    }
}
