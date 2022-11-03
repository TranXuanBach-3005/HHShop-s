using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class FooterRepository : GenericRepository<Footer>, IFooterRepository
    {
        public FooterRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
