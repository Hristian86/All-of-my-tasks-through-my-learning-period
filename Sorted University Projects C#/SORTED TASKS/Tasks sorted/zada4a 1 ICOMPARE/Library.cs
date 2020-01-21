using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace zada4a_1_ICOMPARE
{
    public class Library //: IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>();
        }
        
        //public IEnumerator<Book> GetEnumerator()
        //{
        //     return new LibraryIterator(this.books);
        //}

        //IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }
}
