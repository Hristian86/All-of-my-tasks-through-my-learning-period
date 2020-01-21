using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_7_CLASS_ORDER_BY_AGE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                string name = command[0];
                if (command[0] == "End")
                {
                    break;
                }
                string identifier = command[1];
                int age = int.Parse(command[2]);
                
                Person person = new Person(name,identifier,age);
                persons.Add(person);
            }

            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Identity} is {item.Age} years old.");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Identity { get; set; }
        public int Age { get; set; }

        public Person(string name,string identifier,int age)
        {
            this.Name = name;
            this.Identity = identifier;
            this.Age = age;
        }

    }
}
