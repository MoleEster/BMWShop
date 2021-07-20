using Microsoft.AspNetCore.Mvc;
using Site0505.Data.Intefaces;
using Site0505.Data.Models;
using Site0505.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Site0505.Controllers
{
    public class HomePageController:Controller
    {
        public IAllCategories categories;
        private readonly IAllVehicles allVehicles;
        public HomePageController(IAllCategories allCategories, IAllVehicles allVehicles)
        {
            categories = allCategories;
            this.allVehicles = allVehicles;

        }
        [HttpGet]
        public ActionResult Categories()
        {
            var Categories = new HomePageViewModel
            {
                Categories = categories.GetAllCategories,
                Vehicles = allVehicles.GetAllVehicles
            };
            return View(Categories);
        }

        [HttpPost]
        public ActionResult CategoryContent(string category)
        {
            IEnumerable<Vehicle> vehicles = allVehicles.GetAllVehicles;
            if (!string.IsNullOrEmpty(category) && category != "AllVehicles")
            {
                string _category = category;
                vehicles = allVehicles.GetAllVehicles.Where(o => o.Category.Name.Equals(_category));
            }
            else
            {
                vehicles = allVehicles.GetAllVehicles;
            }
            var Categories = new HomePageViewModel
            {
                Categories = categories.GetAllCategories,
                Vehicles = vehicles
            };
            return PartialView("CarsAndCategories", Categories);
        }

        [HttpGet]
        [Route(@"HomePage/Vehicle/{vehicleName}")]
        public ActionResult Vehicle(string vehicleName)
        {
            if (string.IsNullOrEmpty(vehicleName))
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return View();
            }
            else
            {
                var Vehicle = new HomePageViewModel
                {
                    Vehicles = allVehicles.GetAllVehicles,
                    Categories = categories.GetAllCategories,
                    vehicle = allVehicles.GetAllVehicles.First(x => x.Name == vehicleName)
                };
                return View(Vehicle);
            }
        }
    }
}
