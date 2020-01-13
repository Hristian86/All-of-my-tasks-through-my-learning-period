using System;

namespace zada4a_1_3TA_BILET_ZA_SNUKER
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = Console.ReadLine();
            string tiket = Console.ReadLine();
            int numberOfTikets = int.Parse(Console.ReadLine());
            string picture = Console.ReadLine();
            int trophyPics = numberOfTikets * 40;
            double price = 0;
            double total = 0;
            
            bool freePicture = false;
            if (picture == "Y")
            {
                freePicture = true;
            }
            else if (picture == "N")
            {
                freePicture = false;
            }
            

            if (final == "Quarter final")
            {
                if (tiket == "Standard")
                {
                    price = numberOfTikets * 55.50;
                }
                else if(tiket == "Premium")
                {
                    price = numberOfTikets * 105.20;
                }
                else if (tiket == "VIP")
                {
                    price = numberOfTikets * 118.90;
                }
            }
            else if (final == "Semi final")
            {
                if (tiket == "Standard")
                {
                    price = numberOfTikets * 75.88;
                }
                else if (tiket == "Premium")
                {
                    price = numberOfTikets * 125.22;
                }
                else if (tiket == "VIP")
                {
                    price = numberOfTikets * 300.40;
                }
            }
            else if (final == "Final")
            {
                if (tiket == "Standard")
                {
                    price = numberOfTikets * 110.10;
                }
                else if (tiket == "Premium")
                {
                    price = numberOfTikets * 160.66;
                }
                else if (tiket == "VIP")
                {
                    price = numberOfTikets * 400;
                }
            }
            if (price > 4000)
            {
                total = price * 0.75;
                if (freePicture)
                {
                    total = total * 1;
                }
                else
                {
                   total = total * 1;
                }
            }
            if (price >= 2500 && price <= 4000)
            {
                total = price * 0.90;
                if (freePicture)
                {
                     total += trophyPics;
                }
                else
                {
                    total *= 1;
                }
            }
            if (price < 2500)
            {
                if (freePicture)
                {
                    total = price + trophyPics;
                }
                else
                {
                    total = price * 1;
                }
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}