using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using DataLibrary;
using DataLibrary.BusinessLogic;
namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        static int count;
        static int records;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sing Up";

            return View();
        }

        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees List";

            var data = DataLibrary.BusinessLogic.EmployeeProcesor.LoadEmployees();

            List<EmployeeModel> employs = new List<EmployeeModel>();

            foreach (var item in data)
            {
                employs.Add(new EmployeeModel
                {
                    FirstName = item.FirstName,
                    LastName = item.Lastname,
                    EmailAddress = item.EmailAddress
                });
            }
            return View(employs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                count++;

                var data = DataLibrary.BusinessLogic.EmployeeProcesor.LoadEmployees();

                

                //bool go6o = data.Any(x => x.Id != 0);

                //if (go6o)
                //{
                //    throw new ArgumentException("Bla Bla");
                //}

                //foreach (var item in data)
                //{
                //    if (item.Id.ToString() != null)
                //    {

                //    }
                //}

                records = EmployeeProcesor.CreateEmployee(model.FirstName, model.LastName, model.EmailAddress);

                return RedirectToAction("index");
            }

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}