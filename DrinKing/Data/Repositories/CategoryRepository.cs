using DrinKing.Data.Interfaces;
using DrinKing.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinKing.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _applicationDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _applicationDbContext.Categories;
    }
}
