using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            var tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.2),
                new Tire(2,2.3),
                new Tire(2,2.3),
            };

            var engine = new Engine(560, 6300);


            var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);


            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(thirdCar.WhoAmI());











            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());

            Console.WriteLine($"make: {car.Make}\nmodel: {car.Model}\nyear: {car.Year}");
        }
    }
}
