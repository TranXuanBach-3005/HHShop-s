using AutoMapper;
using HHShops.Application.Services.IServices;
using HHShops.Application.Unitofworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Web.Models;

namespace HHShops.Application.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductAsync()
        {
            var listProduct = await _unitOfWork.ProductRepository.GetAllAsync();
            var listProductVm = _mapper.Map<IEnumerable<ProductViewModel>>(listProduct);
            return listProductVm;
        }
    }
}
