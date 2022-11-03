using HHShops.Application.Repositories.IRepositories;

namespace HHShops.Application.Unitofworks
{
    public interface IUnitOfWork : IDisposable
    {
        public IContactDetailRepository ContactDetailRepository { get; }
        public IErrorRepository ErrorRepository { get; }
        public IFeedBackRepository FeedBackRepository { get; }
        public IFooterRepository FooterRepository { get; }
        public IMenuGroupRepository MenuGroupRepository { get; }
        public IMenuRepository MenuRepository { get; }
        public IOrderDetailRepository OrderDetailRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IPageRepository PageRepository { get; }
        public IPostCategoryRepository PostCategoryRepository { get; }
        public IPostRepository PostRepository { get; }
        public IPostTagRepository PostTagRepository { get; }
        public IProductCategoryRepository ProductCategoryRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IProductTagRepository ProductTagRepository { get; }
        public ISlideRepository SlideRepository { get; }
        public ISupportOnlineRepository SupportOnlineRepository { get; }
        public ISystemConfigRepository SystemConfigRepository { get; }
        public ITagRepository TagRepository { get; }
        public IVisitorStatisticRepository VisitorStatisticRepository { get; }
        void Commit();
        void Save();
        void BeginTransaction();
        Task<int> SaveAsync();

    }
}
