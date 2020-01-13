using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_ICOMPARE
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<People> peps = new List<People>();
            peps.Add(new People { Name = "Pesho", Age = 4 });
            peps.Add(new People { Name = "Sasho", Age = 2 });
            peps.Add(new People { Name = "Kosho", Age = 3 });
            peps.Add(new People { Name = "Sosho", Age = 2 });
            peps.Add(new People { Name = "Ansho", Age = 3 });
            peps.Add(new People { Name = "Plsho", Age = 2 });
            peps.Add(new People { Name = "Gosho", Age = 3 });
            peps.Add(new People { Name = "Vosho", Age = 2 });
            peps.Add(new People { Name = "Ersho", Age = 4 });
            peps.Add(new People { Name = "Trsho", Age = 2 });
            peps.Add(new People { Name = "Uisho", Age = 4 });

            var groupByAgePeoples = peps.GroupBy(x => x.Age);
            foreach (var group in groupByAgePeoples.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"Group by age {group.Key}");
                foreach (var item in group.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"--{item.Name}");
                }
            }

            Cat caty = new Cat();
            Cat otherCat = new Cat("Gosho", 16);
            Cat anothorCat = new Cat("Ivan", 22);
            Cat stupedCat = new Cat("Pepi", 3);
            caty.AddCats(otherCat);
            caty.AddCats(anothorCat);
            string name = "Suzi";
            int age = 6;
            caty.AddCats(stupedCat);
            caty.AddCatProperty("John", 17);
            caty.AddCatProperty("Mishel", 8);
            caty.AddCatProperty(name, age);
            name = "fifi";
            age = 2;
            caty.AddCatProperty(name, age);
            apple.sayHi("jonh");
            foreach (Cat item in caty.GetEnumerator().OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }

        //private static object GroupBy(Func<object, object> p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
