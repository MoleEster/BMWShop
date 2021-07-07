using Microsoft.AspNetCore.Mvc;
using Site0505.Data.Intefaces;
using Site0505.Data.Models;
using Site0505.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Controllers
{
    public class HomePageController:Controller
    {
        public IAllCategories categories;

        public HomePageController(IAllCategories allCategories)
        {
            categories = allCategories;
        }

        public ActionResult Categories()
        {
            var Categories = new HomePageViewModel
            {
                Categories = categories.GetAllCategories
            };
            return View(Categories);
        }
    }
}
