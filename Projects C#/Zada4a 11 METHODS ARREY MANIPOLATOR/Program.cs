using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Zada4a_11_METHODS_ARREY_MANIPOLATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            InputOptions(numbers);
        }
        static void InputOptions(int[] numbers)
        {
            // int[] currentNums = new int[numbers.Length];
            string maxOdds = "";
            string maxEven = "";
            // string minOdd = "";
            // string minEven = "";

            while (true)
            {
                string[] inputOptions = Console.ReadLine().Split(" ");
                string command = inputOptions[0];

                bool maxOrMin = false; // false == min // true == max;
                bool evenOrOddNumbers = false; // false = odd // true == even

                if (command == "end")
                {
                    break;
                }
                if (command == "exchange")
                {
                    int num = int.Parse(inputOptions[1]);
                    //int[] rotaitedNums = Exchange(num, numbers);
                    //currentNums = rotaitedNums;
                    //numbers = rotaitedNums;
                    numbers = Exchange(num, numbers);
                    //Console.WriteLine(string.Join(" ",rotaitedNums));
                }
                else if (command == "max" || command == "min")
                {
                    string textComand = inputOptions[1];


                    if (command == "max")
                    {
                        maxOrMin = true;
                        if (textComand == "odd")
                        {
                            evenOrOddNumbers = false;
                            maxOdds = MaxOrMinOddOrEven(numbers, maxOrMin, evenOrOddNumbers);
                        }
                        if (textComand == "even")
                        {
                            evenOrOddNumbers = true;
                            maxEven = MaxOrMinOddOrEven(numbers, maxOrMin, evenOrOddNumbers);
                        }
                    }
                    if (command == "min")
                    {
                        maxOrMin = false;
                        if (textComand == "odd")
                        {
                            evenOrOddNumbers = false;
                            maxEven = MaxOrMinOddOrEven(numbers, maxOrMin, evenOrOddNumbers);
                        }
                        if (textComand == "even")
                        {
                            evenOrOddNumbers = true;
                            maxEven = MaxOrMinOddOrEven(numbers, maxOrMin, evenOrOddNumbers);
                        }
                    }
                }
                bool lastOrFirst = false; // reversed nums false == first true = last
                if (command == "first")
                {
                    lastOrFirst = false;
                    int num1 = int.Parse(inputOptions[1]);
                    string evenOrOddOption = inputOptions[2];
                    EvenOddDisplayCount(num1, evenOrOddOption, numbers, lastOrFirst);
                }
                if (command == "last")
                {
                    lastOrFirst = true;
                    int num1 = int.Parse(inputOptions[1]);
                    string evenOrOddOption = inputOptions[2];
                    Array.Reverse(numbers);
                    EvenOddDisplayCount(num1, evenOrOddOption, numbers, lastOrFirst);
                    Array.Reverse(numbers);
                }
            }
            string revos = string.Join(", ", numbers);
            Console.WriteLine($"[{revos}]");
        }
        static void EvenOddDisplayCount(int num, string evenOrOddOption, int[] numbers, bool lastOrFirst)
        {
            // evenOrOddOption = even / odd 
            var listOfNumsEven = new List<int>();
            var listOfNumsOdd = new List<int>();

            int count = num;

            if (evenOrOddOption == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (listOfNumsOdd.Count == num)
                    {
                        break;
                    }
                    if (numbers[i] % 2 == 1)
                    {
                        listOfNumsOdd.Add(numbers[i]);
                    }
                }
                if (lastOrFirst)
                {
                    listOfNumsOdd.Reverse();
                }
                if (numbers.Length < num)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (numbers.Length >= num)
                {
                    Console.WriteLine($"[{string.Join(", ", listOfNumsOdd)}]");
                }
            }
            if (evenOrOddOption == "even")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (listOfNumsEven.Count == num)
                    {
                        break;
                    }
                    if (numbers[i] % 2 == 0)
                    {
                        listOfNumsEven.Add(numbers[i]);
                    }
                }
                if (lastOrFirst)
                {
                    listOfNumsEven.Reverse();
                }
                if (numbers.Length < num)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (numbers.Length >= num)
                {
                    Console.WriteLine($"[{string.Join(", ", listOfNumsEven)}]");
                }
            }
        }
        static string MaxOrMinOddOrEven(int[] currentNums, bool maxOrMin, bool evenOrOddNumbers)
        {
            int[] count = new int[currentNums.Length];
            string symmary = "";
            int temp = int.MaxValue;
            int temp1 = int.MinValue;
            bool chk = false;
            //  int index = -1;
            for (int i = 0; i < currentNums.Length; i++)
            {
                if (evenOrOddNumbers)
                {
                    if (currentNums[i] % 2 == 0)
                    {
                        chk = true;
                        //        count[i] = currentNums[i];
                    }
                }
                else
                {
                    if (currentNums[i] % 2 == 1)
                    {
                        chk = true;
                        //      count[i] = currentNums[i];
                    }
                }
            }
            if (!chk)
            {
                symmary = "No matches";
            }
            else
            {
                for (int i = 0; i < currentNums.Length; i++)
                {
                    if (maxOrMin == true) // max num
                    {

                        if (currentNums[i] >= temp1) // bigest num
                        {
                            if (evenOrOddNumbers) // even num
                            {
                                if (currentNums[i] % 2 == 0)
                                {
                                    temp1 = currentNums[i];
                                    int s = i;
                                    symmary = s.ToString();
                                }
                            }
                            if (!evenOrOddNumbers)
                            {
                                if (currentNums[i] % 2 == 1)
                                {
                                    temp1 = currentNums[i];
                                    int s = i;
                                    symmary = s.ToString();
                                }
                            }
                        }

                    }
                    if (maxOrMin == false) //smalest num
                    {
                        if (currentNums[i] <= temp)
                        {
                            if (evenOrOddNumbers) // even num
                            {
                                if (currentNums[i] % 2 == 0)
                                {
                                    temp = currentNums[i];
                                    int s = i;
                                    symmary = s.ToString();
                                }
                            }
                            if (!evenOrOddNumbers)
                            {
                                if (currentNums[i] % 2 == 1)
                                {
                                    temp = currentNums[i];
                                    int s = i;
                                    symmary = s.ToString();
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(symmary);
            return symmary;
        }
        static int[] Exchange(int num, int[] numbers)
        {
            int count = 0;

            if (num >= numbers.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = 0; i <= num; i++)
                {
                    count = numbers[0];
                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    numbers[numbers.Length - 1] = count;
                    //        Console.WriteLine(string.Join(" ", numbers));
                }
                //  Console.WriteLine(string.Join(" ",numbers));
            }
            return numbers;
        }
    }
}