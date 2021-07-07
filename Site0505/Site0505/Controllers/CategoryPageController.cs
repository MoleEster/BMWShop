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
    public class CategoryPageController : Controller
    {
        //private readonly IAllCategories allCategories;
        private readonly IAllVehicles allVehicles;


        public CategoryPageController(IAllCategories allCategories, IAllVehicles allVehicles)
        {
            //this.allCategories = allCategories;
            this.allVehicles = allVehicles;
        }

        [Route("Home/Categories/{category}")]
        public ViewResult Categories(string category)
        {
            string _category = category;
            IEnumerable<Vehicle> vehicles = null;
            vehicles = allVehicles.GetAllVehicles.Where(o => o.Category.Name.Equals(_category));

            var view = new CategoryPageViewModel
            {
                Vehicles = vehicles
            };
            return View(view);
        }
    }
}
