using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
