using System;

namespace testFILM
{
    class Program
    {
        static void Main(string[] args)
        {
            double budzhet = double.Parse(Console.ReadLine());
            int brStatisti = int.Parse(Console.ReadLine());
            double cenaOblekloEdinStatist = double.Parse(Console.ReadLine());
            double dekor = 0.1 * budzhet;
            double drehi = cenaOblekloEdinStatist * brStatisti;
            if (brStatisti >= 150)
            {
                drehi = drehi * 0.1;
            }
            double total = (dekor + drehi) - budzhet;  
            if (budzhet >= total)
            {
                double totall = budzhet - (dekor + drehi);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totall:f2} leva left.");
            }
            else if (budzhet < total)
            {
                double totall = (dekor + drehi) - budzhet;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totall:f2} leva more.");
            }
        


        }
    }
}
