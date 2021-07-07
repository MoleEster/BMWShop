using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Models
{
    public class User:BaseModel
    {
        public User(string email, string password, string surname, string name)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            VehiclesInCart = new List<Vehicle>();
        }
        public string Surname { get; set; }
        [Required]
        [Compare("Username")]
        public string Email { get; set; }
        [Required]
        [Compare("Password")]
        public string Password { get; set; }
        public List<Vehicle> VehiclesInCart { get; set; }
    }
}
