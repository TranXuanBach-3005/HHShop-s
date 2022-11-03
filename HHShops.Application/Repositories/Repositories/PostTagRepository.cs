using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class PostTagRepository : GenericRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
