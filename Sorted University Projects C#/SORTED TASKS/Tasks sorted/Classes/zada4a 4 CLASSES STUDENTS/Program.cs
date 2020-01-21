using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_CLASSES_STUDENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            var listOfStudents = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] person = Console.ReadLine().Split(" ").ToArray();

                Student student = new Student()
                {
                    FirsName = person[0],
                    LastName = person[1],
                    Grade = double.Parse(person[2])
                };

                listOfStudents.Add(student);
            }
            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();

            foreach (var student1 in listOfStudents)
            {
                Console.WriteLine(student1);
            }
        }
    }
    class Student
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        //public Student(string firsName,string lastName,int grade)
        //{
        //    this.FirsName = firsName;
        //    this.LastName = lastName;
        //    this.Grade = grade;
        //}
        public override string ToString()
        {
            return $"{FirsName} {LastName}: {Grade:f2}";
        }
    }
}