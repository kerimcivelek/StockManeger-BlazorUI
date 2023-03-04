using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;
using WebUI.PBYS.Shared.Services.Abstract;
using WebUI.PBYS.Shared.Utilities;

namespace WebUI.PBYS.Shared.Services.Concrete
{
    public class ProductStockService : IProductStockService
    {
        private HttpClient _httpClient;
        public ProductStockService(HttpClient httpClient)
        {
           _httpClient = httpClient;    
        }
        public async Task ProductStockAdd(ProductStockDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Stock/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);

        }

        public Task<ProductStockDetailDto[]> ProductStockDetail(int ProductId)
        {
            return _httpClient.GetFromJsonAsync<ProductStockDetailDto[]>("api/Stock/getbyproductdetail?ProductId=" + ProductId);
        }

        public async Task ProductStockRemove(int Id ,int ProductId)
        {
            var response =  await _httpClient.GetAsync("api/Stock/remove?Id=" + Id + "&ProductId="+ProductId);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<StockListDto[]> ProductStockList()
        {
            return _httpClient.GetFromJsonAsync<StockListDto[]>("api/Stock/groupbysumproducts");
        }

        public Task<ProductsInStockDto[]> ProductInStock(int ProductId)
        {
            return _httpClient.GetFromJsonAsync<ProductsInStockDto[]>("api/Stock/getbyproductid?Id=" + ProductId);
        }
    }
}
