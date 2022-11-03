using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;

namespace HHShops.Application.Unitofworks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly hhShopDbContext _hhShopDbContext;
        private readonly IContactDetailRepository _contactDetailRepository;
        private readonly IErrorRepository _errorRepository;
        private readonly IFeedBackRepository _feedBackRepository;
        private readonly IFooterRepository _footerRepository;
        private readonly IMenuGroupRepository _menuGroupRepository;
        private readonly IMenuRepository _menuRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IPageRepository _pageRepository;
        private readonly IPostCategoryRepository _postCategoryRepository;
        private readonly IPostRepository _postRepository;
        private readonly IPostTagRepository _postTagRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProductTagRepository _productTagRepository;
        private readonly ISlideRepository _slideRepository;
        private readonly ISupportOnlineRepository _supportOnlineRepository;
        private readonly ISystemConfigRepository _systemConfigRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IVisitorStatisticRepository _visitorStatisticRepository;
        public UnitOfWork(hhShopDbContext hhShopDbContext, 
                          IContactDetailRepository contactDetailRepository, 
                          IErrorRepository errorRepository, 
                          IFeedBackRepository feedBackRepository, 
                          IFooterRepository footerRepository, 
                          IMenuGroupRepository menuGroupRepository, 
                          IMenuRepository menuRepository, 
                          IOrderDetailRepository orderDetailRepository, 
                          IOrderRepository orderRepository, 
                          IPageRepository pageRepository, 
                          IPostCategoryRepository postCategoryRepository, 
                          IPostRepository postRepository, 
                          IPostTagRepository postTagRepository, 
                          IProductCategoryRepository productCategoryRepository,
                          IProductRepository productRepository, 
                          IProductTagRepository productTagRepository, 
                          ISlideRepository slideRepository, 
                          ISupportOnlineRepository supportOnlineRepository, 
                          ISystemConfigRepository systemConfigRepository, 
                          ITagRepository tagRepository, 
                          IVisitorStatisticRepository visitorStatisticRepository)
        {
            _hhShopDbContext = hhShopDbContext;
            _contactDetailRepository = contactDetailRepository;
            _errorRepository = errorRepository;
            _feedBackRepository = feedBackRepository;
            _footerRepository = footerRepository;
            _menuGroupRepository = menuGroupRepository;
            _menuRepository = menuRepository;
            _orderDetailRepository = orderDetailRepository;
            _orderRepository = orderRepository;
            _pageRepository = pageRepository;
            _postCategoryRepository = postCategoryRepository;
            _postRepository = postRepository;
            _postTagRepository = postTagRepository;
            _productCategoryRepository = productCategoryRepository;
            _productRepository = productRepository;
            _productTagRepository = productTagRepository;
            _slideRepository = slideRepository;
            _supportOnlineRepository = supportOnlineRepository;
            _systemConfigRepository = systemConfigRepository;
            _tagRepository = tagRepository;
            _visitorStatisticRepository = visitorStatisticRepository;
        }

        public IContactDetailRepository ContactDetailRepository { get => _contactDetailRepository; }

        public IErrorRepository ErrorRepository { get => _errorRepository; }

        public IFeedBackRepository FeedBackRepository { get => _feedBackRepository; }

        public IFooterRepository FooterRepository { get => _footerRepository; }

        public IMenuGroupRepository MenuGroupRepository { get => _menuGroupRepository; }

        public IMenuRepository MenuRepository { get => _menuRepository; }

        public IOrderDetailRepository OrderDetailRepository { get => _orderDetailRepository; }

        public IOrderRepository OrderRepository { get => _orderRepository; }

        public IPageRepository PageRepository { get => _pageRepository; }

        public IPostCategoryRepository PostCategoryRepository { get => _postCategoryRepository; }

        public IPostRepository PostRepository { get => _postRepository; }

        public IPostTagRepository PostTagRepository { get => _postTagRepository; }

        public IProductCategoryRepository ProductCategoryRepository { get => _productCategoryRepository; }

        public IProductRepository ProductRepository { get => _productRepository; }

        public IProductTagRepository ProductTagRepository { get => _productTagRepository; }

        public ISlideRepository SlideRepository { get => _slideRepository; }

        public ISupportOnlineRepository SupportOnlineRepository { get => _supportOnlineRepository; }

        public ISystemConfigRepository SystemConfigRepository { get => _systemConfigRepository; }

        public ITagRepository TagRepository { get => _tagRepository; }

        public IVisitorStatisticRepository VisitorStatisticRepository { get => _visitorStatisticRepository; }

        public void BeginTransaction()
        {
            _hhShopDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _hhShopDbContext.Database.CommitTransaction();
        }

        public void Dispose()
        {
            _hhShopDbContext.Dispose();
        }

        public void Save()
        {
            _hhShopDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
          return  await _hhShopDbContext.SaveChangesAsync();
        }
    }
}
