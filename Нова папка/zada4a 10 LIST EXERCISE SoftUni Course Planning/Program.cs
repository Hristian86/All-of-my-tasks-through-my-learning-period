using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_10_LIST_EXERCISE_SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(", ").ToList();
            string therIsExercise = "";

            while (true)
            {
                var commands = Console.ReadLine().Split(":").ToList();
                string command = commands[0];
                if (command == "course start")
                {
                    break;
                }
                string splited = commands[1];
                string exers = "-Exercise";
                string final = splited + exers;

                
                if (command == "Add")
                {
                    if (listOfNumbers.Contains(commands[1]))
                    {

                    }
                    else
                    {
                        listOfNumbers.Add(commands[1]);
                    }
                }
                else if (command == "Insert")
                {
                    if (listOfNumbers.Contains(commands[1]))
                    {

                    }
                    else
                    {
                        int placement = int.Parse(commands[2]);
                        listOfNumbers.Insert(placement, commands[1]);
                    }
                }
                else if (command == "Remove")
                {
                    if (listOfNumbers.Contains(commands[1]))
                    {
                        listOfNumbers.Remove(commands[1]);

                        if (listOfNumbers.Contains(commands[1] + exers))
                        {
                            int num = listOfNumbers.IndexOf(commands[1] + exers);
                            listOfNumbers.RemoveAt(num);
                        }
                    }
                }
                else if (command == "Swap")
                {
                    if (listOfNumbers.Contains(commands[1]) && listOfNumbers.Contains(commands[2]))
                    {
                        // first string
                        int number = listOfNumbers.IndexOf(commands[1]);
                        string temp = listOfNumbers[number];

                        //second string
                        int number1 = listOfNumbers.IndexOf(commands[2]);
                        string secondTemp = listOfNumbers[number1];

                        listOfNumbers.RemoveAt(number);
                        listOfNumbers.Insert(number, secondTemp);
                        listOfNumbers.RemoveAt(number1);
                        listOfNumbers.Insert(number1, temp);

                        if (listOfNumbers.Contains(commands[1] + exers))
                        {
                            //int num = listOfNumbers.IndexOf(commands[1] + exers);
                            listOfNumbers = Exersiced(listOfNumbers, commands[1], exers);
                        }
                        else if (listOfNumbers.Contains(commands[2] + exers))
                        {
                            listOfNumbers = Exersiced(listOfNumbers, commands[2], exers);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string exerChek = commands[1];
                    exerChek += "-Exercise";
                    therIsExercise = exerChek;
                    //Console.WriteLine(exerChek);
                    if (listOfNumbers.Contains(commands[1]) && !(listOfNumbers.Contains(exerChek)))
                    {
                        int numIndex = listOfNumbers.IndexOf(commands[1]);
                        listOfNumbers.Insert(numIndex+1, exerChek);
                    }
                    else if (!(listOfNumbers.Contains(commands[1])) && !(listOfNumbers.Contains(exerChek)))
                    {
                        listOfNumbers.Add(commands[1]);
                        listOfNumbers.Add(exerChek);
                    }
                }
            }
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, listOfNumbers[i]);
            }
        }
        static List<string> Exersiced(List<string> listOfNumbers,string command,string exers)
        {
            int num = listOfNumbers.IndexOf(command + exers);
            string current = listOfNumbers[num];
            listOfNumbers.RemoveAt(num);
            int currentNum = listOfNumbers.IndexOf(command);
            listOfNumbers.Insert(currentNum + 1, current);
            return listOfNumbers;
        }
    }
}