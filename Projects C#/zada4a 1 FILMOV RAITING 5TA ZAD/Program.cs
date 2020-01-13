using System;

namespace zada4a_1_FILMOV_RAITING_5TA_ZAD
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MovieRating(num);
        }
        static void MovieRating(int num)
        {
            string highName = "";
            double highRating = double.MinValue;

            string lowName = "";
            double lowRating = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < num; i++)
            {
                string nameOfMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sum += rating;

                if (highRating < rating)
                {
                    highRating = rating;
                    highName = nameOfMovie;
                }
                if (lowRating > rating)
                {
                    lowRating = rating;
                    lowName = nameOfMovie;
                }
            }
            double result = sum / num;
            Console.WriteLine($"{highName} is with highest rating: {highRating:f1}");
            Console.WriteLine($"{lowName} is with lowest rating: {lowRating:f1}");
            Console.WriteLine($"Average rating: {result:f1}");
        }
    }
}