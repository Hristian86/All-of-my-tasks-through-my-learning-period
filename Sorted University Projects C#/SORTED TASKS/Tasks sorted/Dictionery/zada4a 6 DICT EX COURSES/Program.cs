using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_6_DICT_EX_COURSES
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<Person>>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ").ToArray();
                string course = command[0];
                if (course == "end")
                {
                    break;
                }
                string name = command[1];
                if (!dict.ContainsKey(course))
                {
                    dict[course] = new List<Person>();
                }
                    Person person = new Person()
                    {
                        Name = name,
                        Count = 1
                    };
                    dict[course].Add(person);
            }
            var dict1 = dict.OrderByDescending(x => x.Value.Count);
            int sum = 0;
            foreach (var item in dict1)
            {
                sum = item.Value.Count;
                Console.WriteLine($"{item.Key}: {sum}");
                foreach (var items in item.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-- {items.Name}");
                }
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}