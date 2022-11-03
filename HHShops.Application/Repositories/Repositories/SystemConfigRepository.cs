using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class SystemConfigRepository : GenericRepository<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
