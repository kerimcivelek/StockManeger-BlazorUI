using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface IProductService
    {
        Task ProductAdd(ProductDto model);
        Task<ProductDto> GetByProduct(int ProductId);
        Task<ProductCartDto[]> ProductCartList();
    }
}
