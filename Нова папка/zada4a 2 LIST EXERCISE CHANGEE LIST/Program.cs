using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_2_LIST_EXERCISE_CHANGEE_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            while (true)
            {
                
                string[] commands = Console.ReadLine().Split(" ");
                string command = commands[0];
                if (command == "end")
                {
                    break;
                }
                int number = int.Parse(commands[1]);
                if (command == "Delete")
                {
                    listOfNumbers.RemoveAll(x => x == number);
                }
                else if (command == "Insert")
                {
                    int num = int.Parse(commands[2]);
                    listOfNumbers.Insert(num, number);
                }
            }
            Console.WriteLine(string.Join(" ",listOfNumbers));

        }
    }
}
