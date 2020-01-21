using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zada4a_8_CLASS_VIACLES
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catelogue();
            catalog.Carses = new List<Car>();
            catalog.Truckses = new List<Truck>();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                var veacles = Console.ReadLine().Split("/");
                if (veacles[0] == "end")
                {
                    break;
                }
                string manufacture = veacles[1];
                string model = veacles[2];
                int horsePower = int.Parse(veacles[3]);
                if (veacles[0] == "Truck")
                {
                    Truck current = new Truck()
                    {
                        Manufacturer = manufacture,
                        Model = model,
                        Weight = horsePower
                    };
                    catalog.Truckses.Add(current);

                }
                else if (veacles[0] == "Car")
                {
                    Car current = new Car()
                    {
                        Manufacturer = manufacture,
                        Model = model,
                        HorsePower = horsePower
                    };
                    catalog.Carses.Add(current);
                    //Catelogue carses = new Catelogue()
                    //{
                    //    Carses = cars
                    //};
                }

            }
            // catalog.Carses = catalog.Carses.OrderBy(x => x.HorsePower).ToList();
            //catalog.Truckses = catalog.Truckses.OrderBy(x => x.Weight).ToList();
            //int count = 0;


            //foreach (var car in arengetCars)
            //{
            //    if (count == 0)
            //    {
            //        Console.WriteLine("Cars:");
            //    }
            //    count++;
            //    Console.WriteLine($"{car.Manufacturer}: {car.Model} - {car.HorsePower}hp");
            //}

            //int counter = 0;
            //foreach (var truck in arengetTrucks)
            //{
            //    if (counter == 0)
            //    {
            //        Console.WriteLine("Trucks:");
            //    }
            //    counter++;
            //    Console.WriteLine($"{truck.Manufacturer}: {truck.Model} - {truck.Weight}kg");
            //}

            Catelogue carseses = new Catelogue()
            {
                Carses = cars,
                Truckses = trucks
            };


            if (catalog.Carses.Count > 0)
            {

                catalog.Carses = catalog.Carses.OrderBy(x => x.Manufacturer).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Carses)
                {
                    Console.WriteLine($"{car.Manufacturer}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Truckses.Count > 0)
            {
                catalog.Truckses = catalog.Truckses.OrderBy(x => x.Manufacturer).ToList();
                Console.WriteLine("Trucks:");
                foreach (var car in catalog.Truckses)
                {
                    Console.WriteLine($"{car.Manufacturer}: {car.Model} - {car.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catelogue
    {
        public List<Car> Carses { get; set; }
        public List<Truck> Truckses { get; set; }
    }
}