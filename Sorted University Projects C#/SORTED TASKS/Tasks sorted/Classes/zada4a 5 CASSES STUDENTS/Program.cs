using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace zada4a_5_CASSES_STUDENTS
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> exactList = new List<Student>();
            while (true)
            {
                var peaople = Console.ReadLine().Split(" ");
                if (peaople[0] == "end")
                {
                    break;
                }
                string firstName = peaople[0];
                string lastName = peaople[1];
                int age = int.Parse(peaople[2]);
                string town = peaople[3];
                if (IsExistingStudent(exactList,firstName,lastName))
                {
                    Student stud = GetStudents(exactList, firstName, lastName);

                    stud.FirstName = firstName;
                    stud.LastName = lastName;
                    stud.Age = age;
                    stud.HomeTown = town;
                }
                else
                {
                    Student current = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = town
                    };
                    exactList.Add(current);
                }
            }
            string searchByTown = Console.ReadLine();
            //Console.WriteLine((" ",exactList));

            List<Student> filteredList = exactList.Where(x => x.HomeTown == searchByTown).ToList();
            filteredList.OrderByDescending(x => x.Age).ToList();
            foreach (var studented in filteredList)
            {
                Console.WriteLine("{0} {1} is {2} years old.",studented.FirstName,studented.LastName,studented.Age);
            }
        }
        static Student GetStudents(List<Student> students,string firstName,string lastName)
        {
            Student existingStudent = null;
            foreach ( Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
        static bool IsExistingStudent (List<Student> students,string firstName,string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}