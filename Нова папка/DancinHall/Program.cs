using System;

namespace DancinHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double sideCm = side * 100;

            double volume = (lenght * 100) * (width * 100);
            double wardrobe = (sideCm * sideCm);
            double bench = volume / 10;
            double emptySpace = volume - wardrobe - bench;
            double dancers = emptySpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
