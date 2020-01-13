using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Person(string firstName, string lastName, int age, decimal salary) : this(firstName, lastName, age)
        {
            this.Salary = salary;
        }

        public void IncreaseSalary(decimal percentege)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentege / 100;
            }
            else
            {
                this.Salary += this.Salary * percentege / 200;
            }
        }

        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;
        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                //if (value < 460)
                //{
                //    throw new ArgumentException("Salary cannot be less than 460 leva!");
                //}
                this.salary = value;
            }
        }

        public void NamesChek(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Names must be at least 3 symbols!");
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                //if (value.Length < 3)
                //{
                //    throw new ArgumentException("Names must be at least 3 symbols!");
                //}

                //this.NamesChek(value);

                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                //if (value.Length < 3)
                //{
                //    throw new ArgumentException("Names must be at least 3 symbols!");
                //}
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                //if (age < 1)
                //{
                //    throw new ArgumentException("Age connot be zero or a negative integer!");
                //}
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {this.Salary:f2} leva.";
        }
    }
}