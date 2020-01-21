using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_1_OBJECTS_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            var list = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
;
            int numOfMEss = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfMEss; i++)
            {
                string phrase = list[random.Next(0, list.Count)]; /*phrases[random.Next(0, phrases.Length)];*/
                string even = events[random.Next(0, events.Length)];
                string author = authors[random.Next(0, authors.Length)];
                string city = cities[random.Next(0, cities.Length)];
                Console.WriteLine($"{phrase} {even} {author} - {city}.");
            }
        }
    }
    class Advertisment
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Author { get; set; }
        public string Cities { get; set; }
    }
}
