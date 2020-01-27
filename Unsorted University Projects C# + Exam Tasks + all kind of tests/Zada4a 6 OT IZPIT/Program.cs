using System;

namespace Zada4a_6_OT_IZPIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double count = 0;
            double counter2 = 0;
            double summary = 0;
            double totalSumOdd = 0;
            double EvenSum = 0;

            for (int i = 1; i <= days; i++)
            {
                summary = i;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 1 )
                    {
                        if (j % 2 == 0)
                        {
                            count += 1.25;
                        }
                        else
                        {
                            count += 1;
                        }            
                    }
                    else if (i % 2 == 0)
                    {
                        if (j % 2 == 1)
                        {
                            counter2+= 2.50;
                        }
                        else
                        {
                            counter2 += 1;
                        }
                    }
                }
                if (summary % 2 == 1)
                {
                    Console.WriteLine($"Day: {i} - {count:F2} leva");
                }
                else
                {
                    Console.WriteLine($"Day: {i} - {counter2:f2} leva");
                }
                totalSumOdd += count;
                EvenSum += counter2;
                count = 0;
                counter2 = 0;
            }
            double sum = totalSumOdd + EvenSum;
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}