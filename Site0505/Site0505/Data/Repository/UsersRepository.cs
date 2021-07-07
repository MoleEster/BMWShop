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
    public class UsersRepository : BaseRepository<User>,IAllUsers
    {
        private readonly AppDbContext _context;
        public UsersRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers => _context.Users.Include(c => c.VehiclesInCart);
    }
}
