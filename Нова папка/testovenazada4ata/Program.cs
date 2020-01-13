using System;

namespace testovenazada4ata
{
    class Program
    {
        static void Main()
        {
            int dayofres = int.Parse(Console.ReadLine());
            int monthofres = int.Parse(Console.ReadLine());

            int dayofarraive = int.Parse(Console.ReadLine());
            int monthofarraive = int.Parse(Console.ReadLine());

            int leavingday = int.Parse(Console.ReadLine());
            int leavingmonth = int.Parse(Console.ReadLine());

            int nights = leavingday - dayofarraive;
            int daysapart = Math.Abs(dayofres - dayofarraive);
            int monthsapart = Math.Abs(monthofres - monthofarraive);

            //bool earlybookdays = false;
            //bool earlybookmonths = false;
            double price = 30;
            //if (daysapart <= 10)
            //{
            //    earlybookdays = true;
            //}
            //if (monthsapart >= 1)
            //{
            //    earlybookmonths = true;
            //    earlybookdays = true;
            //}
            //double cost = nights * price;
            //if (earlybookdays)
            double cost = 0;
            while (daysapart >= 10)
            {
                cost = nights * 25;

                //if (daysapart >= 10)
                //{
                //    cost = nights * 25;
                //}
                if (daysapart <= 10)
                {
                    cost = nights * price;
                }
                //if (daysapart > 10)
                //{
                //    cost = nights * 25;
                //}
                //cost = nights * 25;

                //if (earlybookmonths)
                }
            while (monthsapart >= 1)
            {
                cost *= 0.8;

                //if (monthsapart > 1)
                //{
                //    cost *= 0.8;
                //}
                if (monthsapart < 1)
                {
                    cost *= 1;
                }
                {

                }

                //cost *= 0.8;
            }
            Console.WriteLine($"Your stay from {dayofarraive}/{monthofarraive} to {leavingday}/{leavingmonth} will cost {cost:f2}");

        }
    }
}
