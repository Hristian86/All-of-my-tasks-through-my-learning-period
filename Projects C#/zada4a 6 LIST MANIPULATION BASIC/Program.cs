using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_6_LIST_MANIPULATION_BASIC
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToList();
            var outputList = new List<int>();
            bool print = false;
            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                string command = commands[0];
                int secondComand = 0;

                if (command == "end")
                {
                    break;
                }
                else if (command == "Add")
                {
                    secondComand = int.Parse(commands[1]);
                    listOfNumbers.Add(secondComand);
                    print = true;
                }
                else if (command == "Remove")
                {
                    secondComand = int.Parse(commands[1]);
                    listOfNumbers.RemoveAll(x => x == secondComand);
                    print = true;
                }
                else if (command == "RemoveAt")
                {
                    secondComand = int.Parse(commands[1]);
                    listOfNumbers.RemoveAt(secondComand);
                    print = true;
                }
                else if (command == "Insert")
                {
                    secondComand = int.Parse(commands[1]);
                    int thirdCommand = int.Parse(commands[2]);
                    listOfNumbers.Insert(thirdCommand, secondComand);
                    print = true;
                }

                if (command == "Contains")
                {
                    int numOfContain = int.Parse(commands[1]);
                    if (listOfNumbers.Contains(numOfContain))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    var evenNums = new List<int>();
                    evenNums = listOfNumbers.Where(x => x % 2 == 0).ToList();
                    //for (int i = 0; i < listOfNumbers.Count; i++)
                    //{
                    //    if (listOfNumbers[i] % 2 == 0)
                    //    {
                    //        evenNums.Add(listOfNumbers[i]);
                    //    }
                    //}
                    Console.WriteLine(string.Join(" ", evenNums));
                }
                else if (command == "PrintOdd")
                {
                    var oddNumbers = new List<int>();
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] % 2 == 1)
                        {
                            oddNumbers.Add(listOfNumbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (command == "GetSum")
                {
                    int sumNums = listOfNumbers.Sum(x => x = Convert.ToInt32(x));
                    //listOfNumbers.Sum(x => Convert.ToInt32(x));
                    Console.WriteLine(sumNums);
                }
                else if (command == "Filter")
                {
                    string conditions = commands[1];
                    int nums = Convert.ToInt32(commands[2]);
                    var filteredList = new List<int>();
                    filteredList = listOfNumbers.ToList();

                    if (conditions == ">")
                    {
                        filteredList.RemoveAll(x => x <= nums);
                        Console.WriteLine(string.Join(" ", filteredList));
                        filteredList = listOfNumbers.ToList();
                    }
                    else if (conditions == "<")
                    {
                        filteredList.RemoveAll(x => x >= nums);
                        Console.WriteLine(string.Join(" ", filteredList));
                        filteredList = listOfNumbers.ToList();
                    }
                    else if (conditions == ">=")
                    {
                        filteredList.RemoveAll(x => x < nums);
                        Console.WriteLine(string.Join(" ", filteredList));
                        filteredList = listOfNumbers.ToList();
                    }
                    else if (conditions == "<=")
                    {
                        filteredList.RemoveAll(x => x > nums);
                        Console.WriteLine(string.Join(" ", filteredList));
                        filteredList = listOfNumbers.ToList();
                    }
                }
            }
            if (print)
            {
                Console.WriteLine(string.Join(" ",listOfNumbers));
            }
        }
    }
}