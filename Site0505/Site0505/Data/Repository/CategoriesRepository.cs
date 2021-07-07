using Site0505.Data.Database;
using Site0505.Data.Intefaces;
using Site0505.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0505.Data.Repository
{
    public class CategoriesRepository : IAllCategories
    {
        private AppDbContext _context;

        public CategoriesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories => _context.Categories.ToList();
    }
}
