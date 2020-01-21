using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_7_DICT_EX_STUDENT_AVADEMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<Student>>();
            var dict1 = new Dictionary<string, double>();

            for (int i = 0; i < studentCount; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<Student>();
                }
                var currentStudnet = new Student()
                {
                    Grade = grade
                };
                dict[name].Add(currentStudnet);
            }
            double sum = 0;
            double total = 0;
            int temp = 0;
            foreach (var items in dict)
            {
                foreach (var item in items.Value)
                {
                    sum += item.Grade;
                    temp++;
                }
                total = sum / temp;
                if (total >= 4.50)
                {
                    dict1[items.Key] = total;
                }
                sum = 0;
                total = 0;
                temp = 0;
            }
            foreach (var item in dict1.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
    public class Student
    {
        public double Grade { get; set; }

    }
}
