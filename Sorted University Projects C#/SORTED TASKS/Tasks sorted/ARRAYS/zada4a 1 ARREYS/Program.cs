using System;

namespace zada4a_1_ARREYS
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
                int days = int.Parse(Console.ReadLine());
                if (days >= 8 || days <= 0)
                {
                    Console.WriteLine("Invalid day!");
                //break;
            }
            else
            {
                string[] daysofweek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                for (int i = 0; i < daysofweek.Length; i++)
                {

                }
                Console.WriteLine(daysofweek[days - 1]);
            }
        }
    }
}
