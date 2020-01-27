using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Contact
    {
        //private int id;
        public Contact(string name,string number,int id)
        {
            id = 1;
            this.Id = id;
            this.Name = name;
            this.Number = number;
        }
        
        //public void Create(string name,string number)
        //{
        //    this.Name = name;
        //    this.Number = number;
        //}
        public int Id { get; set; }
        public string Name { get; set; }

        public string Number { get; set; }
    }
}