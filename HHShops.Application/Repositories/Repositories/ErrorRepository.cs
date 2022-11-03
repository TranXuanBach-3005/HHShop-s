using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class ErrorRepository : GenericRepository<Error>, IErrorRepository
    {
        public ErrorRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
