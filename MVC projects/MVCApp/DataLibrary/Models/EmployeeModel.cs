using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{

    public class EmployeeModel
    {
        public int id;

        //public EmployeeModel(string firstName, string lastName, string emailAddress)
        //{
        //    this.FirstName = firstName;
        //    this.Lastname = Lastname;
        //    this.EmailAddress = emailAddress;
        //}
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }

    }
}
