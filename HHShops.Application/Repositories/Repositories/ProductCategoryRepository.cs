using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace HHShops.Application.Repositories.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(hhShopDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductCategory>> GetByAliasAsync(string alias)
        {
            return await _dbSet.Where(x => x.Alias == alias).ToListAsync();
        }
    }
}
