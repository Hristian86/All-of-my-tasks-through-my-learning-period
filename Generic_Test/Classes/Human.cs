using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Test.Classes
{
    public class Human
    {
        private string name;
        private int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get => this.name;
            private set => value = name;
        }

        public int Age
        {
            get => this.age;
            private set => value = age;
        }
    }
}
