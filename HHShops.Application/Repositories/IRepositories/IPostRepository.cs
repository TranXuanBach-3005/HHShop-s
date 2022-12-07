using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.IRepositories
{
    public interface IPostRepository: IGenericRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
}
