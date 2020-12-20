
namespace Generics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Name = "Suzi", LastName = "Gana" });
            persons.Add(new Person() { Name = "Zaza", LastName = "Bobs" });
            persons.Add(new Person() { Name = "Suzi", LastName = "Gana" });

            var items = GetPersons<Person>(persons, persons);
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

        }

        private static List<T> GetPersons<T>(List<T> entities, List<T> compareEntities) where T : new()
        {
            foreach (var entity in entities)
            {
                var instance = entity.GetType().GetProperty("Name");

                var values = instance.GetValue(entity);

                if (values.ToString() == "Suzi")
                {
                    Console.WriteLine("Suzi");
                }

                var props = entity.GetType().GetProperties();
                foreach (var prop in props)
                {
                    var value = prop.GetValue(entity);
                    if (prop.Name == "Name")
                    {
                        if (value.ToString() == "Zaza")
                        {
                            Console.WriteLine(value.ToString());
                        }
                    }
                }
            }
            return entities;
        }
    }
}
