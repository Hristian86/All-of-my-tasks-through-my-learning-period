using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace zada4a_1_ICOMPARE
{
    class Cat : IEnumerable
    {
        List<Cat> cats = new List<Cat>();

        public Cat()
        {
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void AddCatProperty(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            var cat = new Cat(this.Name, this.Age);
            AddCats(cat);
        }
        public void AddCats(Cat cat)
        {
            cats.Add(cat);
        }
        public List<Cat> GetEnumerator()
        {
            return this.cats;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this.cats;
        }
        
    }
}