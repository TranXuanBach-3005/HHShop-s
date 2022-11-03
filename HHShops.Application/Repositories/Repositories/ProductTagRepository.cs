using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class ProductTagRepository : GenericRepository<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
