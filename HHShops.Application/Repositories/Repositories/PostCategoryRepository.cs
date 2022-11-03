using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class PostCategoryRepository : GenericRepository<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
