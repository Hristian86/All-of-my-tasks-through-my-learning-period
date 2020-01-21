using System;

namespace Zada4a_8_VLOJEN_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayStayed = int.Parse(Console.ReadLine());
            string placeToStay = Console.ReadLine();
            string grade = Console.ReadLine();
            int nighs = dayStayed - 1;
            double price = 0;
            double sum = 0;
            double discount = 0;

            if (grade == "positive")
            {
                discount = 1.25;
            }
            else if (grade == "negative")
            {
                discount = 0.90;
            }

            if (placeToStay == "room for one person")
            {
                price = nighs * 18.00;
                Console.WriteLine($"{price * discount:f2}");
            }

            if (dayStayed <= 10)
            {
                if (placeToStay == "apartment")
                {
                    sum = nighs * 25.00;
                    price = sum * 0.70;
                    Console.WriteLine($"{price * discount:f2}");
                }
                else if (placeToStay == "president apartment")
                {
                    sum = nighs * 35.00;
                    price = sum * 0.90;
                    Console.WriteLine($"{price * discount:f2}");
                }

            }
            else if (dayStayed <= 15 && dayStayed > 10)
            {
                if (placeToStay == "apartment")
                {
                    sum = nighs * 25.00;
                    price = sum * 0.65;
                    Console.WriteLine($"{price * discount:f2}");
                }
                else if (placeToStay == "president apartment")
                {
                    sum = nighs * 35.00;
                    price = sum * 0.85;
                    Console.WriteLine($"{price * discount:f2}");
                }
            }
            else if (dayStayed > 15)
            {
                if (placeToStay == "apartment")
                {
                    sum = nighs * 25.00;
                    price = sum * 0.50;
                    Console.WriteLine($"{price * discount:f2}");
                }
                else if (placeToStay == "president apartment")
                {
                    sum = nighs * 35.00;
                    price = sum * 0.80;
                    Console.WriteLine($"{price * discount:f2}");
                }
            }
        }
    }
}