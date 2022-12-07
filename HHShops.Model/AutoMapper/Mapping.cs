using AutoMapper;
using HHShops.Model.Entities;
using HHShops.Model.Models;
using TeduShop.Web.Models;

namespace HHShops.Model.AutoMaper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostCategory, PostCategoryViewModel>().ReverseMap();
            CreateMap<Tag, TagViewModel>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<ProductTag, ProductTagViewModel>().ReverseMap();
            CreateMap<Footer, FooterViewModel>().ReverseMap();
            CreateMap<Slide, SlideViewModel>().ReverseMap();
            CreateMap<Page, PageViewModel>().ReverseMap();
            CreateMap<ContactDetail, ContactDetailViewModel>().ReverseMap();

            CreateMap<Post, UpdatePostViewModel>().ReverseMap();
            CreateMap<PostCategory, UpdatePostCategoryViewModel>().ReverseMap();
            CreateMap<Product, UpdateProductViewModel>().ReverseMap();
            CreateMap<ProductCategory, UpdateProductCategoryViewModel>().ReverseMap();
        }
    }
}
