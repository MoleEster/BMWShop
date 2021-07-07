using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Site0505.Data.Models
{
    public class Vehicle : BaseModel
    {
        public string Img { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }
        public virtual Category Category { get; set; }
        public int Price { get; set; }
    }
}
