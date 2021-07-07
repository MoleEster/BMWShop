using Microsoft.EntityFrameworkCore;
using Site0505.Data.Database;
using Site0505.Data.Intefaces;
using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Repository
{
    public class VehiclesRepository : BaseRepository<Vehicle>,IAllVehicles
    {
        private AppDbContext _context;
        public VehiclesRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Vehicle> GetAllVehicles => _context.Vehicles.Include(c=> c.Category);

        public void AddtoCart(Guid VehicleId)
        {
            throw new NotImplementedException();
        }
    }
}
