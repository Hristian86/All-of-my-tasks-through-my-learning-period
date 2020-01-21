using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeOfContract = Console.ReadLine();
            string sortOfContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double price = 0;

            switch (timeOfContract)
            {
                case "one":
                    if (sortOfContract == "Small")
                    {
                        price = 9.98;
                    }
                    else if (sortOfContract == "Middle")
                    {
                        price = 18.99;
                    }
                    else if (sortOfContract == "Large")
                    {
                        price = 25.98;
                    }
                    else if (sortOfContract == "ExtraLarge")
                    {
                        price = 35.99;
                    }
                    break;
                case "two":
                    if (sortOfContract == "Small")
                    {
                        price = 8.58;
                    }
                    else if (sortOfContract == "Middle")
                    {
                        price = 17.09;
                    }
                    else if (sortOfContract == "Large")
                    {
                        price = 23.59;
                    }
                    else if (sortOfContract == "ExtraLarge")
                    {
                        price = 31.79;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Contract!");
                    break;
                    


            }
            if (internet == "yes")
            {
                if (price <= 10.00)
                {
                    price = price + 5.50;
                }
                else if (price <= 30.00 && price > 10.00)
                {
                    price = price + 4.35;
                }
                else
                {
                    price = price + 3.85;
                }
            }
            else if (internet == "no")
            {
                price = price * 1;
            }
            if (timeOfContract == "two")
            {
                price = price * 0.9625;
            }
            double sum = price * months;
            Console.WriteLine($"{sum:f2} lv.");









            //bool years = false;

            //if (timeOfContract == "one")
            //{
            //    years = true;
            //}
            //else if (timeOfContract == "two")
            //{
            //    years = false;
            //}





        }
    }
}
