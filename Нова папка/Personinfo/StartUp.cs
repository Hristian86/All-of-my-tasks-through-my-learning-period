using System;
using System.Linq;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Team team = new Team("Softuni");
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {

                string[] commands = Console.ReadLine().Split();
                var firstName = commands[0];
                var lastName = commands[1];
                var age = int.Parse(commands[2]);
                 string salaryInString = commands[3];
                decimal salary = 0;
                if (!decimal.TryParse(salaryInString, out salary))
                {
                    Console.WriteLine("Bot");
                }
                else
                {
                    salary = decimal.Parse(salaryInString);
                }
              //  try
                //{
                    Person person = new Person(firstName, lastName, age, salary);

                    persons.Add(person);
                    team.AddPlayer(person);
               // }
              //  catch (Exception ex)
             //   {
               //     Console.WriteLine(ex.Message);
               // }

            }
            //var percentege = decimal.Parse(Console.ReadLine());

            Console.WriteLine("First team has {0} players.",team.FirstTeam.Count);
            Console.WriteLine("Reserve team has {0} players.",team.ReserveTeam.Count);

            //persons.ForEach(x => x.IncreaseSalary(percentege));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));
            //persons.OrderBy(x => x.FirstName)
            //    .ThenBy(x => x.Age)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
