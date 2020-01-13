using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_6_CLASS_VEHICLE_CATALOGUE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalog> soso = new List<Catalog>();

            var catalogue = new Catalog();
            catalogue.Car = new List<Vehicle>();
            catalogue.Truck = new List<Vehicle>();
            List<Vehicle> vehi = new List<Vehicle>();

            while (true)
            {
                string[] vehicle = Console.ReadLine().Split(" ");
                if (vehicle[0] == "End")
                {
                    break;
                }
                if (vehicle[0] == "car")
                {
                    Vehicle objVehicle = new Vehicle()
                    {

                        Type = "Car",
                        Model = vehicle[1],
                        Color = vehicle[2],
                        HorsePower = int.Parse(vehicle[3])

                    };

                    catalogue.Car.Add(objVehicle);
                    vehi.Add(objVehicle);
                    soso.Add(catalogue);
                }
                else if (vehicle[0] == "truck")
                {
                    Vehicle objVehicle = new Vehicle()
                    {

                        Type = "Truck",
                        Model = vehicle[1],
                        Color = vehicle[2],
                        HorsePower = int.Parse(vehicle[3])

                    };
                    catalogue.Truck.Add(objVehicle);
                    vehi.Add(objVehicle);
                    soso.Add(catalogue);
                }
            }
            int count = catalogue.Car.Count;
            int counter = catalogue.Truck.Count;
            double sumCars = catalogue.Car.Sum(x => x.HorsePower);
            double sumTrucks = catalogue.Truck.Sum(x => x.HorsePower);




            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }

                //foreach (var item in soso)
                //{
                //        if (item.Car.Contains)
                //        {
                //            Console.WriteLine($"Type: {item.Type}");
                //            Console.WriteLine($"Model: {item.Model}");
                //            Console.WriteLine($"Color: {item.Color}");
                //            Console.WriteLine($"Horsepower: {item.HorsePower}");
                //        }
                //    }
                //    foreach (var vehicle in items.Truck)
                //    {
                //        Console.WriteLine($"Type: {vehicle.Type}");
                //        Console.WriteLine($"Model: {vehicle.Model}");
                //        Console.WriteLine($"Color: {vehicle.Color}");
                //        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                //    }
                //}
                
                foreach (var item in catalogue.Car)
                {
                    if (item.Model.Equals(command))
                    {
                        Console.WriteLine(item);
                        //Console.WriteLine($"Type: {item.Type}");
                        //Console.WriteLine($"Model: {item.Model}");
                        //Console.WriteLine($"Color: {item.Color}");
                        //Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
                

                foreach (var item in catalogue.Truck)
                {
                    if (item.Model.Equals(command))
                    {
                        Console.WriteLine(item);
                        //Console.WriteLine($"Type: {item.Type}");
                        //Console.WriteLine($"Model: {item.Model}");
                        //Console.WriteLine($"Color: {item.Color}");
                        //Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }

                //foreach (var item in vehi)
                //{
                //    if (item.Model == command)
                //    {
                //        if (item.Type == "truck")
                //        {
                //            Console.WriteLine("Type: Truck");
                //            Console.WriteLine($"Model: {item.Model}");
                //            Console.WriteLine($"Color: {item.Color}");
                //            Console.WriteLine($"Horsepower: {item.HorsePower}");
                //        }
                //        else
                //        {
                //            Console.WriteLine("Type: Car");
                //            Console.WriteLine($"Model: {item.Model}");
                //            Console.WriteLine($"Color: {item.Color}");
                //            Console.WriteLine($"Horsepower: {item.HorsePower}");
                //        }
                //    }
                //}
            }

            double totalCars = sumCars / count;
            double totalTrucks = sumTrucks / counter;
                Console.WriteLine($"Cars have average horsepower of: {totalCars:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {totalTrucks:f2}.");
            
            
            

        }
    }
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            string vehicleses = ($"Type:  {Type}") + Environment.NewLine + ($"Model: {Model}") + Environment.NewLine + ($"Color: {Color}") + Environment.NewLine + ($"Horsepower: {HorsePower}");
            return vehicleses;
        }
    }
    public class Catalog
    {
        public List<Vehicle> Car { get; set; }
        public List<Vehicle> Truck { get; set; }
    }

}