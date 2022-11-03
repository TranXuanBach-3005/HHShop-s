using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
