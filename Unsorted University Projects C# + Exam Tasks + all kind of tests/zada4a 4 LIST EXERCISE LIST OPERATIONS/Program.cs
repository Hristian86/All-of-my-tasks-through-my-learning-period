using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_4_LIST_EXERCISE_LIST_OPERATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(" ").Select(int.Parse).ToList();
            var outputList = new List<int>();
            
            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ").ToArray();
                string command = commands[0];
                
                if (command == "End")
                {
                    break;
                }
                else if (command == "Add")
                {
                    int secondComand = int.Parse(commands[1]);
                    listOfNumbers.Add(secondComand);
                }
                else if (command == "Removeat")
                {
                    int secondComand = int.Parse(commands[1]);
                    listOfNumbers.RemoveAll(x => x == secondComand);
                }
                else if (command == "Remove")
                {
                    int secondComand = int.Parse(commands[1]);
                    if (secondComand > listOfNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfNumbers.RemoveAt(secondComand);
                    }
                }
                else if (command == "Insert")
                {
                    int secondComand = int.Parse(commands[1]);
                    int thirdCommand = int.Parse(commands[2]);

                    if (thirdCommand > listOfNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfNumbers.Insert(thirdCommand, secondComand);
                    }
                }
                else if(command == "Shift")
                {
                    string secondCom = commands[1];
                    int numOfShifts = int.Parse(commands[2]);
                    if (secondCom == "left")
                    {
                        for (int i = 0; i < numOfShifts; i++)
                        {
                            int tempNum = listOfNumbers[0];
                            listOfNumbers.Add(tempNum);
                            listOfNumbers.RemoveAt(0);
                        }
                    }
                    else if (secondCom == "right")
                    {
                        //listOfNumbers.Reverse();
                        //for (int i = 0; i < numOfShifts; i++)
                        //{
                        //    int tempNum = listOfNumbers[0];
                        //    listOfNumbers.Add(tempNum);
                        //    listOfNumbers.RemoveAt(0);

                        //}
                        //listOfNumbers.Reverse();

                        for (int i = 0; i < numOfShifts; i++)
                        {
                            int ending = listOfNumbers.Count-1;
                            int tempNum = listOfNumbers[ending];
                            listOfNumbers.Insert(0, tempNum);
                            listOfNumbers.RemoveAt(listOfNumbers.Count-1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",listOfNumbers));
        }
    }
}
