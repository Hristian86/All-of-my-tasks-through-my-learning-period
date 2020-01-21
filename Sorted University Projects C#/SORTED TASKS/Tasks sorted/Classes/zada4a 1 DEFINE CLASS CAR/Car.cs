using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        //Engine engine = new Engine();
        private Engine engine;
        private Tire[] tires;

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
            }
        }

        //Tire[] tires = new Tire[4]
        //{
        //    new Tire(1,2.5),
        //    new Tire(1,2.2),
        //    new Tire(2,2.3),
        //    new Tire(2,2.3),
        //};

        public Car(string make, string model, int year, double fuelQuantty, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantty, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }




        /// <summary>
        /// Default Car:
        /// </summary>
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = FuelConsumption;
        }
        ///// <summary>
        ///// Fuel maneging with basic stats:
        ///// </summary>
        ///// <param name="fuelQuantity">Fuel liters</param>
        ///// <param name="fuelConsumption">Fuel spended</param>
        //public Car(double fuelQuantity, double fuelConsumption) : this()
        //{
        //    this.fuelQuantity = fuelQuantity;
        //    this.fuelConsumption = fuelConsumption;
        //}

        /// <summary>
        /// Change basic stats:
        /// </summary>
        /// <param name="make">maker</param>
        /// <param name="model">model</param>
        /// <param name="year">year</param>
        public Car(string make, string model, int year) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        /// <summary>
        ///  Change all stats:
        /// </summary>
        /// <param name="make">Creator</param>
        /// <param name="model">Model</param>
        /// <param name="year">Year of creation</param>
        /// <param name="fuelQuantity">Liters of fuel</param>
        /// <param name="fuelConsumption">Consumed fuel</param>
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;
            if (canContinue)
            {
                this.FuelQuantity -= distance * (this.FuelConsumption / 100);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder display = new StringBuilder();

            this.Make = this.Make.Length > 1 ? this.Make = make : this.Make = "VW";

            this.Model = this.Model.Length > 1 ? this.Model = model : this.Model = "Golf";

            display.AppendLine($"Make: {this.make}");
            display.AppendLine($"Model: {this.model}");
            display.AppendLine($"Year: {this.year}");
            display.Append($"Fuel: {this.FuelQuantity:f2}L");
            return display.ToString();
        }
        //public override string ToString()
        //{
        //    StringBuilder display = new StringBuilder();
        //    display.AppendLine($"Make: {this.make}");
        //    display.AppendLine($"Model: {this.model}");
        //    display.AppendLine($"Year: {this.year}");
        //    display.Append($"Fuel: {this.fuelQuantity:f2}L");
        //    return display.ToString();
        //}

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

    }
}