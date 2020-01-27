using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data.Models;
using Phonebook.Data;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {


        //private int id = 1;
        public IActionResult Create(string name, string number, int id)
        {
            int count = 0;
            Contact contact = new Contact(name, number, id);



            bool contain = DataAccess.Contacts.Any(x => x.Name == contact.Name);

            if (!contain)
            {

                if (DataAccess.Contacts.Count == 0)
                {
                    count = 1;
                }
                else
                {
                    count = DataAccess.Contacts.Count + 1;
                }
                contact.Id = count;
                DataAccess.Contacts.Add(contact);
            }

            return RedirectToAction("Index", "Home");

        }
        public IActionResult Edit(string name, string number)
        {
            var editName = DataAccess.Contacts.Where(x => x.Name == name);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            Contact contToBeRemoved = DataAccess.Contacts.FirstOrDefault(x => x.Id == id);

            DataAccess.Contacts.Remove(contToBeRemoved);

            return RedirectToAction("Index", "Home");
        }
    }
}