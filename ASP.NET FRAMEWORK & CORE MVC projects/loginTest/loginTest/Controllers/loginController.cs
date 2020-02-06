using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginTest.Models;

namespace loginTest.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Sign()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(Authentication UserStats)
        {
            using (RegistrationEntities db = new RegistrationEntities())
            {
                var userDetail = db.Authentication.Where(x => x.User == UserStats.User && x.PassWord == UserStats.PassWord).FirstOrDefault();

                if (userDetail == null)
                {
                    UserStats.ErrorMessageUs = "Wrong user name or password";
                    return View("Sign", UserStats);
                }
                else
                {
                    return RedirectToAction("Index", "SignUp");
                }
            }
            //return View();
        }
    }
}