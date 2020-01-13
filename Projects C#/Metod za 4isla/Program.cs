using System;

namespace Metod_za_4isla
{
    class Program
    {
        public static void numberses()
        {
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                counter = i;
                counter = counter * counter;
                Console.WriteLine(counter);
            }
            return;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while(text != "deam")
            {
                Console.WriteLine("Error ma friend");
                text = Console.ReadLine();
            }
            if (text == "deam")
            {
                numberses();
            }

        }
    }
}
