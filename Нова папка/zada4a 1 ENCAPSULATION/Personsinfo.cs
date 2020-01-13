using System;
using System.Collections.Generic;
using System.Linq;

namespace Personsinfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] commands = Console.ReadLine().Split();
                var firstName = commands[0];
                var lastName = commands[1];
                var age = int.Parse(commands[2]);

                Person person = new Person(firstName,lastName,age);
                
                people.Add(person);
            }
            people.OrderBy(x => x.FirstName)
                .ThenBy(x => x.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));

            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
