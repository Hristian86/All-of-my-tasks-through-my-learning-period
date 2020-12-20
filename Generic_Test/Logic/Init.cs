using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Generic_Test.Classes;

namespace Generic_Test.Logic
{
    public class Init
    {
        private Human human;
        private List<Human> humanCol;

        private Teacher teacher;
        private List<Teacher> teacherCol;

        public void Initialize()
        {
            this.humanCol = new List<Human>();
            this.teacherCol = new List<Teacher>();

            AddToCollections();

            this.ComparePropertiesInClasses<Human>(this.humanCol);
            Console.WriteLine();

            this.ComparePropertiesInClasses<Teacher>(this.teacherCol);
        }

        public void ComparePropertiesInClasses<T>(List<T> coll) where T : class
        {
            for (int i = 0; i < coll.Count; i++)
            {
                T obj = coll[i];

                Type currentElType = coll[i].GetType();
                PropertyInfo[] prop = currentElType.GetProperties();

                this.CompareProperties(prop, i, obj, coll);
            }
        }

        private void CompareProperties<T>(PropertyInfo[] propertyInfo, int i, T obj, List<T> coll) where T : class
        {
            for (int j = i + 1; j < coll.Count; j++)
            {
                this.InnerCompare(i, j, coll, propertyInfo, obj);
            }
        }

        private void InnerCompare<T>(int i, int j, List<T> coll, PropertyInfo[] propertyInfo, T obj) where T : class
        {
            T next = coll[j];

            foreach (var property1 in propertyInfo)
            {
                // Iterate through all properties in ProperyInfo array and get the value.
                var firstVal = property1.GetValue(obj).ToString();

                Type typeNextEl = next.GetType();
                PropertyInfo[] propertyInfo2 = typeNextEl.GetProperties();

                this.SearchInRestOfCollection(propertyInfo2, firstVal, next);
            }
        }

        private void SearchInRestOfCollection<T>(PropertyInfo[] propertyInfo2, string firstVal, T next) where T : class
        {
            foreach (var property2 in propertyInfo2)
            {
                var secondVal = property2.GetValue(next).ToString();

                if (firstVal == secondVal)
                {
                    Console.WriteLine(firstVal);
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private void AddToCollections()
        {
            this.teacher = new Teacher("BO6ko", 39);
            this.teacherCol.Add(teacher);

            this.teacher = new Teacher("Sel4o", 33);
            this.teacherCol.Add(teacher);

            this.teacher = new Teacher("BO6ko", 39);
            this.teacherCol.Add(teacher);

            this.human = new Human("Go6o", 23);
            this.humanCol.Add(human);

            this.human = new Human("Pe6o", 25);
            this.humanCol.Add(human);

            this.human = new Human("Go6o", 25);
            this.humanCol.Add(human);
        }
    }
}