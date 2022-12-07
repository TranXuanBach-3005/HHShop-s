using HHShops.Application.Services.IServices;
using HHShops.Application.Unitofworks;
using HHShops.Model.Entities;

namespace HHShops.Application.Services.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Post> CreateAsync(Post post)
        {
            return await _unitOfWork.PostRepository.CreateAsync(post);
        }

        public void DeleteAsync(int id)
        {
            _unitOfWork.PostRepository.Delete(id);
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _unitOfWork.PostRepository.GetAllAsync(new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int cateId, int page, int pageSize, out int totalRow)
        {
            return _unitOfWork.PostRepository.GetMultiPagingAsync(x => x.Status && x.CategoryID == cateId, out totalRow, page, pageSize, new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _unitOfWork.PostRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllByTagPaging(int tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return  _unitOfWork.PostRepository.GetMultiPagingAsync(x => x.Status, out totalRow, page, pageSize);
        }

        public async Task<Post> GetByIdAsync(int postId)
        {
            return await _unitOfWork.PostRepository.GetSingleByIdAsync(postId);
        }

        public void UpdateAsync(Post post)
        {
             _unitOfWork.PostRepository.Update(post);
        }
    }
}
