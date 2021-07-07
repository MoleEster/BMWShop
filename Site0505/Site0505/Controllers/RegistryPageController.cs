using Microsoft.AspNetCore.Mvc;
using Site0505.Data.Intefaces;
using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Controllers
{
    public class RegistryPageController : Controller
    {
        private readonly IAllUsers allUsers;
        public RegistryPageController(IAllUsers allUsers)
        {
            this.allUsers = allUsers;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string email,string password)
        {
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {

                var User = allUsers.GetAllUsers.FirstOrDefault(c => c.Email.Equals(email));
                if (User != null && User.Password.Equals(password))
                {
                    return RedirectToRoute(new { controller = "HomePage", action = "Categories" });
                }
            }
            return RedirectToAction("RegisterNewUser");
        }

        public ActionResult RegisterNewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterNewUser(string email, string password, string surname, string name)
        {
            if (!(string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password) && string.IsNullOrEmpty(surname) && string.IsNullOrEmpty(name)))
            {

                User User = new User(email,password,surname,name);
                if (User != null)
                {
                    allUsers.Add(User);
                    return RedirectToRoute(new { controller = "HomePage", action = "Categories" });
                }
            }
            return RedirectToAction("RegisterNewUser");
        }
    }
}
