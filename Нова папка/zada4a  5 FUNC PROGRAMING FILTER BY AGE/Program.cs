using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace zada4a__5_FUNC_PROGRAMING_FILTER_BY_AGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<People> peps = new List<People>();
            for (int i = 0; i < number; i++)
            {
                string[] people = Console.ReadLine().Split(new char[] { ' ',','}).ToArray();

                string name = people[0];
                int age = int.Parse(people[2]);

                var peoples = new People(name,age);
                peps.Add(peoples);
                
            }
            string typeOfMature = Console.ReadLine();
            int ageOfMature = int.Parse(Console.ReadLine());
            if (typeOfMature == "older")
            {
                peps = peps.Where(x => x.Age >= ageOfMature).ToList();
            }
            else if (typeOfMature == "younger")
            {
                peps = peps.Where(x => x.Age < ageOfMature).ToList();
            }
            string format = Console.ReadLine();
            if (format == "name age")
            {
                foreach (var item in peps)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
            else if (format == "name")
            {
                foreach (var item in peps)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else if (format == "age")
            {
                foreach (var item in peps)
                {
                    Console.WriteLine(item.Age);
                }
            }
        }
    }
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Pens
        {
            get
            {
                return this.Name;
            }
            private set
            {
                this.Name = value;
            }
        }
        public People(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}