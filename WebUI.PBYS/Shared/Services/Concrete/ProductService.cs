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
    public class ProductService : IProductService
    {

        private HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ProductDto> GetByProduct(int ProductId)
        {
            return _httpClient.GetFromJsonAsync<ProductDto>("api/Products/getbyproduct?Id=" + ProductId);
        }

        public async Task ProductAdd(ProductDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Products/addproduct", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);



        }

        public Task<ProductCartDto[]> ProductCartList()
        {
            return _httpClient.GetFromJsonAsync<ProductCartDto[]>("api/products/getall");
        }
    }
}
