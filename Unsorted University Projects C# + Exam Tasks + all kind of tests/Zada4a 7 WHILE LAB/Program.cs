using System;

namespace Zada4a_7_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double schoolGrade = 12;
            int counter = 0;
            double summary = 0;


            while (counter < schoolGrade)
            {
                double grade = double.Parse(Console.ReadLine());
                ++counter;
                summary += grade;
                //sum = summary / 12;
                if (grade < 2)
                {
                    Console.WriteLine($"Mimi has been excluded at {counter} grade");
                    return;
                    //summary += grade;
                }
                if (counter == schoolGrade)
                {
                    break;

                }

            }
            double sum = summary / 12;
            if (counter == schoolGrade)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
            }
            if (counter < schoolGrade)
            {
                Console.WriteLine($"Mimi has been excluded at {counter} grade");
            }
        }
    }
}
