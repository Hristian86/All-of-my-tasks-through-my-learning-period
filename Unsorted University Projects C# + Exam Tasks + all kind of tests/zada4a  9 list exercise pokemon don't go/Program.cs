using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a__9_list_exercise_pokemon_don_t_go
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            int result = 0;
            int place = 0;

            while (listOfNumbers.Count - 1 > -1)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    place = listOfNumbers[0];
                    place = Steps(listOfNumbers, place);
                    listOfNumbers.RemoveAt(0);
                    listOfNumbers.Insert(0, listOfNumbers.Count - 1);
                    result += place;
                }
                else if (number > listOfNumbers.Count - 1)
                {
                    place = listOfNumbers[listOfNumbers.Count - 1];
                    place = Steps(listOfNumbers, place);
                    listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                    listOfNumbers.Add(listOfNumbers[0]);
                    result += place;
                }
                else
                {
                    place = listOfNumbers[number];
                    place = Steps(listOfNumbers, place);
                    listOfNumbers.RemoveAt(number);
                    result += place;
                }
            }
            Console.WriteLine(result);
        }
        static int Steps(List<int> listOfNumbers, int place)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers.Count - 1 > -1)
                {
                    if (place >= listOfNumbers[i])
                    {
                        int temp = listOfNumbers[i] + place;
                        listOfNumbers.RemoveAt(i);
                        listOfNumbers.Insert(i, temp);
                    }
                    else if (place < listOfNumbers[i])
                    {
                        int temp = listOfNumbers[i] - place;
                        listOfNumbers.RemoveAt(i);
                        listOfNumbers.Insert(i, temp);
                    }
                }
            }
            return place;
        }
    }
}