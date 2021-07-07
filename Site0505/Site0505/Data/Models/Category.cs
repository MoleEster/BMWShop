using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Models
{
    public class Category:BaseModel
    {
        public List<Vehicle> Vehicles { get; set; }
    }
}
