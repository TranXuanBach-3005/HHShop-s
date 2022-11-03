using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
