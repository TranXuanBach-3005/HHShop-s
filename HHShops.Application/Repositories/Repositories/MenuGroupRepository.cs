using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShops.Application.Repositories.Repositories
{
    public class MenuGroupRepository : GenericRepository<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
