using System;

namespace zada4a_1_1VA_KOLEDNI_LAKOMSTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine())*1.60;
            double muphinsPrice = double.Parse(Console.ReadLine())*1.80;
            double shtolenKilos = double.Parse(Console.ReadLine());
            double bonbonsKilos = double.Parse(Console.ReadLine());
            double cookiesKilos = double.Parse(Console.ReadLine())*7.50;

            shtolenKilos *= baklavaPrice;
            bonbonsKilos *= muphinsPrice;

            double total = shtolenKilos + bonbonsKilos + cookiesKilos;

            Console.WriteLine($"{total:f2}");
        }
    }
}