using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class ContactDetailRepository : GenericRepository<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
