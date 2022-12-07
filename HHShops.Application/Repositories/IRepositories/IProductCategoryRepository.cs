using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.IRepositories
{
    public interface IProductCategoryRepository: IGenericRepository<ProductCategory>
    {
        Task<IEnumerable<ProductCategory>> GetByAliasAsync(string alias);
    }
}
