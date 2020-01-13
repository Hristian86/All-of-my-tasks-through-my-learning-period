using System;

namespace zada4a_1_CINEMA_VAUCHER_4TA
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucherPrice = int.Parse(Console.ReadLine());
            int movies = 0;
            int product = 0;
            //int symmary = 0;
            int askkiPrice = 0;
            int acsiPrice = 0;
            string tiketMovie = "";

            while (true)//(voucherPrice >= askkiPrice || voucherPrice >= acsiPrice)
            {
                tiketMovie = Console.ReadLine();
                if (tiketMovie == "End")
                {
                    break;
                }

                if (tiketMovie.Length > 8)
                {
                    askkiPrice = tiketMovie[0] + tiketMovie[1];
                    //askkiPrice += tiketMovie[1];
                    if (voucherPrice - askkiPrice < 0)
                    {
                        break;
                    }
                    else
                    {
                        movies++;
                        voucherPrice -= askkiPrice;
                    }
                }
                if (tiketMovie.Length <= 8)
                {
                    acsiPrice = tiketMovie[0];
                    if (voucherPrice - acsiPrice < 0)
                    {
                        break;
                    }
                    else
                    {
                        product++;
                        voucherPrice -= acsiPrice;
                    }
                }
            }
            Console.WriteLine(movies);
            Console.Write(product);
        }
    }
}
