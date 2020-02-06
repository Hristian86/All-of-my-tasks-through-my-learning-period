using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataLibrary.Models;

namespace MVCApp.Models
{
    public class EmployeeModel
    {


        //[Display(Name = "Employee ID")]
        //[Range(100000,999999, ErrorMessage = "You need to enter a valid EmployeeId.")]
        //public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to enter First name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to enter last name.")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to give us your email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress",ErrorMessage = "Your email and confirnemail do not match.")]
        public string ConfirmAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password.")]
        [DataType(DataType.Password)]
        [StringLength(30,MinimumLength = 6, ErrorMessage = "You need to provide minimum 6 letters long password.")]
        public string Password { get; set; }

        //[Display(Name = "First Name")]
        //[Required(ErrorMessage = "You need to enter First name.")]

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Your password and confirmpassword do not match")]
        public string ConfirnPassword { get; set; }
        
    }
}