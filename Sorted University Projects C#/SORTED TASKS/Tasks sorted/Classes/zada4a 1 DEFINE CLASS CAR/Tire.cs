using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire()
        {

        }
        public Tire(int year,double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;
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
