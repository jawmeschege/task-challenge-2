using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge2.Repositories;
using Challenge2.Models;
using Challenge2.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Challenge2.Persistence.Repositories
{
    public class ProductCategoryRepository : BaseRepository, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductCategory>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
            

        }

        public async Task AddAsync(ProductCategory category)
        {
            await _context.Categories.AddAsync(category);
        }
    }


}