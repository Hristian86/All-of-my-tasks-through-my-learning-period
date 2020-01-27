using System;

namespace Zada4a_8_WHILE_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());


            int sum = width * lenght * hight;

            int count = 0;
            int summary = 0;

            int sum1 = 0;
            int sum2 = Math.Abs(sum1); // if more
            
            while (summary < sum)
            {

                count++;

                if (summary < sum)
                { 

                    string stop = Console.ReadLine();
                    if (stop == "Done")
                    {
                        if (summary <= sum)
                        {
                            int sum3 = Math.Abs(sum - summary);
                            Console.WriteLine($"{sum3} Cubic meters left.");
                            break;
                        }
                        
                    }
                    int numbers = int.Parse(stop);
                    summary += numbers;
                    sum1 = sum - summary;
                }
                if (sum1 <=0)
                {
                    break;
                }
            }
            if (summary > sum)
            {
                int sum5 = Math.Abs(sum - summary);
                Console.WriteLine($"No more free space! You need {sum5} Cubic meters more.");
                return;
            }
        }
    }
}