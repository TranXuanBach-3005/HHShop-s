﻿using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using HHShops.Model.Entities;

namespace HHShops.Application.Repositories.Repositories
{
    public class SupportOnlineRepository : GenericRepository<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(hhShopDbContext context) : base(context)
        {
        }
    }
}
