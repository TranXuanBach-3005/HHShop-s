using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class FeedBackRepository : GenericRepository<Feedback>, IFeedBackRepository
    {
        public FeedBackRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
