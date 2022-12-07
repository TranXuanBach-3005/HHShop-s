using HHShops.Model.Entities;

namespace HHShops.Application.Services.IServices
{
    public interface IPostService
    {
        Task<Post> CreateAsync(Post post);
        void UpdateAsync(Post post);
        void DeleteAsync(int id);
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(int postId);
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int cateId, int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByTagPaging(int tag, int page, int pageSize, out int totalRow);
    }
}
