using System.Linq.Expressions;

namespace HHShops.Application.Repositories.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);
        void Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Delete(int id);
        void DeleteMulti(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetSingleByIdAsync(int id);
        Task<TEntity> GetSingleByConditionAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null);
        Task<IEnumerable<TEntity>> GetAllAsync(string[] includes = null);
        IEnumerable<TEntity> GetMultiAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        IEnumerable<TEntity> GetMultiPagingAsync(Expression<Func<TEntity, bool>> filter, out int total, int index = 0, int size =50, string[] includes = null);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> where);
        bool CheckContains(Expression<Func<TEntity, bool>> predicate);
    }
}
