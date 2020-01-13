using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_3_LIST_EXERCISE_HOUSE_PARTY
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var guests = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string[] namesIsGoing = Console.ReadLine().Split(" ").ToArray();
                string name = namesIsGoing[0];
                
                string condition = namesIsGoing[2];

                if (condition != "not")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(string.Join(" ", guests[i]));
            }
        }
    }
}
