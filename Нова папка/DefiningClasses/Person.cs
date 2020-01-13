using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public override string ToString()
        {
            return $"{this.name} - {this.age}";
        }
        public string Name
        {
            get { return this.name; }
            private set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's lenght should not be less than 3 symbols!");
                }
                this.name = value;
            }
        }
        public virtual int Age
        {
            get { return this.age; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(int age) : this("No name", age)
        {
        }
        public Person() : this("No name", 1)
        {
        }
        
    }
}
