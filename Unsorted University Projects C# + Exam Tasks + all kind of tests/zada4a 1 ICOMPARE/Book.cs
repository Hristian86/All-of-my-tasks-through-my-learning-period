using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace zada4a_1_ICOMPARE
{
    public class Book
    {

        public Book(string title,int year,params string[] authors)
        {
            
        }
        public string Title { get { return this.Title; } private set { this.Title = value; } }
        public int Age { get { return this.Age; } private set { this.Age = value; } }
        public List<string> Authors { get { return this.Authors; } private set { this.Authors = value; } }

    }
}
