using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] plebs = Console.ReadLine().Split();

                string name = plebs[0];
                int age = int.Parse(plebs[1]);

                    Person peps = new Person(name, age);
                    family.AddMembers(peps);
                //try
                //{
                //    //var person = new Person(name, age);
                //    //Console.WriteLine(person);
                //}
                //catch (ArgumentException ea)
                //{
                //    Console.WriteLine(ea.Message);
                //}

            }

            List<Person> selqni = family.FileterdByYear().OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, selqni));



            //    var oldestMember = family.GetOldestMember();

            //      Console.WriteLine(oldestMember);





            //string age = Console.ReadLine();
            //int ages;
            //if (int.TryParse(age, out ages))
            //{
            //}
            //else
            //{
            //    Console.WriteLine("No valid number");
            //}

            //Person person = new Person();
            //person.Name = "Pesho";
            //person.Age = 20;
            //Person person2 = new Person();
            //person2.Name = "Gosho";
            //person2.Age = 18;
            //Person person3 = new Person();
            //person3.Name = "Stamen";
            //person3.Age = 43;
            //Console.WriteLine($"{person.Name} {person.Age}");
            //Console.WriteLine($"{person2.Name} {person2.Age}");
            //Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
}
