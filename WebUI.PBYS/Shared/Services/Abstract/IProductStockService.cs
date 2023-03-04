using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface IProductStockService
    {
        Task ProductStockAdd(ProductStockDto model);
        Task ProductStockRemove(int Id ,int ProductId);
        Task<ProductStockDetailDto[]> ProductStockDetail(int ProductId);
        Task<StockListDto[]> ProductStockList();

        Task<ProductsInStockDto[]> ProductInStock(int ProductId);
    }
}
