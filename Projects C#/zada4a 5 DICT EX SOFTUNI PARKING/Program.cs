using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_5_DICT_EX_SOFTUNI_PARKING
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOdPeople = int.Parse(Console.ReadLine());
            var peaole = new Dictionary<string, string>();
            for (int i = 0; i < numberOdPeople; i++)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                string register = commands[0];
                string name = commands[1];    
                if (register == "register")
                {
                    string identity = commands[2];
                    if (!peaole.ContainsKey(name))
                    {   
                        peaole[name] = identity;
                        Console.WriteLine($"{name} registered {identity} successfully");
                    }
                    else
                    {
                        //var realName = peaole.First(x => x.Key == name);
                        //Console.WriteLine(realName.Key);
                        Console.WriteLine($"ERROR: already registered with plate number {peaole[name]}");
                    }
                }
                else if(register == "unregister")
                {
                    if (peaole.ContainsKey(name))
                    {
                        peaole.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in peaole)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}