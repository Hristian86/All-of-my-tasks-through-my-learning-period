using System;
using System.Collections.Generic;
using System.Text;

namespace Personsinfo
{
    public class Person
    {
        public Person(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //private string firstName;

        //private string lastName;

        //private int age;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
