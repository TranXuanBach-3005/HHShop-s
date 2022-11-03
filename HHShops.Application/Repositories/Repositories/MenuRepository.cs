using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
