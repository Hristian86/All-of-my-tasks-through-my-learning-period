using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_1_LIST_EXERCISE_TRAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            
            string command = "";
            int numberses = 0;
            bool itsGonnaAdd = false;
            int counter = 0;

            while (true)
            {

                string[] input = Console.ReadLine().Split(" "); 
                command = input[0];

                if (command == "end")
                {
                    break;
                }

                if (command == "Add")
                {
                    int number = int.Parse(input[1]);
                    wagons.Add(number);
                }
                else
                {
                    numberses = Convert.ToInt32(command);
                    itsGonnaAdd = true;
                }

                if (itsGonnaAdd)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxPassengers >= numberses && itsGonnaAdd && maxPassengers >= wagons[i] + numberses)
                        {
                            if (maxPassengers >= wagons[i] + numberses)
                            {
                                int sum = wagons[i] + numberses;
                                wagons.Remove(wagons[i]);
                                wagons.Insert(i, sum);
                                counter++;
                                break;
                            }
                            numberses = 0;
                        }
                    }
                }
                counter = 0;
                itsGonnaAdd = false;
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
