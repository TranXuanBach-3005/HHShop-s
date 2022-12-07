using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace HHShops.Application.Repositories.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(hhShopDbContext context) : base(context)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = _dbSet.Include(x => x.PostTags.Where(y => y.TagID == tag && x.Status))
                                                      .OrderByDescending(x=>x.CreatedDate)
                                                      .Skip((pageIndex -1)*pageSize)
                                                      .Take(pageSize);
            totalRow =  query.Count();
            return query;

        }
    }
}
