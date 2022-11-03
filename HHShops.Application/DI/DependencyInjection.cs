using HHShops.Application.Repositories.IRepositories;
using HHShops.Application.Repositories.Repositories;
using HHShops.Application.Services.IServices;
using HHShops.Application.Services.Services;
using HHShops.Application.Unitofworks;
using HHShops.Data.EF;
using HHShops.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HHShops.Application.DI
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructuresService(
           this IServiceCollection services,
           IConfiguration configuration
           )
        {
            //DI
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContactDetailRepository, ContactDetailRepository>();
            services.AddScoped<IErrorRepository, ErrorRepository>();
            services.AddScoped<IFeedBackRepository, FeedBackRepository>();
            services.AddScoped<IFooterRepository, FooterRepository>();
            services.AddScoped<IMenuGroupRepository, MenuGroupRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPageRepository, PageRepository>();
            services.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostTagRepository, PostTagRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTagRepository, ProductTagRepository>();
            services.AddScoped<ISlideRepository, SlideRepository>();
            services.AddScoped<ISupportOnlineRepository, SupportOnlineRepository>();
            services.AddScoped<ISystemConfigRepository, SystemConfigRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IVisitorStatisticRepository, VisitorStatisticRepository>();

            services.AddScoped<IApplicationGroupService, ApplicationGroupService>();
            //DbContext
            services.AddDbContext<hhShopDbContext>(options =>
                options.UseSqlServer(configuration
                       .GetConnectionString(SystemConstant.HhConnectionString)));
            //Mapper
          
            //Identity
           
            return services;
        }
    }
}
