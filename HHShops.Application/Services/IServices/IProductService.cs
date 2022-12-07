using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Web.Models;

namespace HHShops.Application.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProductAsync();
    }
}
