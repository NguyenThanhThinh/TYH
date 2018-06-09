using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TYH.Domain.Entities;
using TYH.EntityFrameworkCore;

namespace TYH.Data.Repositories
{
   public class CategoryRepository: Repository<Category, int>, ICategoryRepository
    {
        TYHDbContext _context;
        public CategoryRepository(TYHDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Category> GetByAlias(string alias)
        {
            return _context.Categories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}
