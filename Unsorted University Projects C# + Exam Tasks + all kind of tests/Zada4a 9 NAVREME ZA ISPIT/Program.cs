using System;

namespace Zada4a_9_NAVREME_ZA_ISPIT
{
    class Program
    {
        static void Main(string[] args)
        {
            byte examHour = byte.Parse(Console.ReadLine());
            byte examMinutes = byte.Parse(Console.ReadLine());
            byte arriveHour = byte.Parse(Console.ReadLine());
            byte arriveMinutes = byte.Parse(Console.ReadLine());

            String late = "Late";
            String onTime = "On time";
            String early = "Early";
            int examTimeToMin = examHour * 60 + examMinutes;
            int arriveTimeToMin = arriveHour * 60 + arriveMinutes;
            int difference = arriveTimeToMin - examTimeToMin;

            String studentArrival = late;
            if (difference < -30)
            {
                studentArrival = early;
            }
            else if (difference <= 0)
            {
                studentArrival = onTime;
            }
            String result = "";
            if (difference != 0)
            {
                int hoursDifference = Math.Abs(difference / 60);
                int minutesDifference = Math.Abs(difference % 60);
                if (hoursDifference > 0)
                {
                    result = ($"{hoursDifference}:{minutesDifference:D2} hours");
                }
                else
                {
                    result = minutesDifference + "minutes";
                }
                if (difference < 0)
                {
                    result += "before the start";
                }
                else
                {
                    result += "after the start";
                }
            }
            Console.WriteLine(studentArrival);
            if (result != null)
            {
                Console.WriteLine(result);
            }
        }
    }
}
