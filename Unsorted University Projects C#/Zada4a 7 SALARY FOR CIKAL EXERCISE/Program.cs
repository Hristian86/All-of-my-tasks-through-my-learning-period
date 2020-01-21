using System;

namespace Zada4a_7_SALARY_FOR_CIKAL_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < num)
            {
                counter++;
                string numbersAsText = Console.ReadLine();
                if (numbersAsText == "Facebook")
                {
                    salary -= 150;
                }
                else if (numbersAsText == "Instagram")
                {
                    salary -= 100;
                }
                else if (numbersAsText == "Reddit")
                {
                    salary -= 50;
                }
                //if (salary <=0)
                //{
                //    Console.WriteLine("You have lost your salary.");
                //    return;
                //}
                if (salary <= 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else 
            {
                Console.WriteLine(salary);
            }
        }
    }
}
