using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class VisitorStatisticRepository : GenericRepository<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
