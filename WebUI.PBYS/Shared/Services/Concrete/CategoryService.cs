using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;
using WebUI.PBYS.Shared.Services.Abstract;

namespace WebUI.PBYS.Shared.Services.Concrete
{
    public class CategoryService : ICategoryService
    {

        private HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<BaseCategoryDto[]> BaseCategory()
        {
            return _httpClient.GetFromJsonAsync<BaseCategoryDto[]>("api/Categories/basecategorygetall");
        }
        public Task<CategoryDto[]> GetCategoryById(int id)
        {
            return _httpClient.GetFromJsonAsync<CategoryDto[]>("api/Categories/getcategorybyid?Id=" + id);
        }
        public Task BrandAdd(BrandDto model)
        {
            return _httpClient.PostAsJsonAsync("api/Categories/brandadd", model);
        }

        public Task BrandRemove(int id)
        {
            return _httpClient.GetAsync("api/Categories/brandremovegetbyid?Id=" + id);
        }

        public Task<BrandDto[]> Brands(int categoryId)
        {
            return _httpClient.GetFromJsonAsync<BrandDto[]>("api/Categories/brandgetbyid?Id=" + categoryId);
        }

        public async Task CategoryAdd(CategoryDto model)
        {
            await _httpClient.PostAsJsonAsync("api/Categories/categoryadd", model);
        }

        public Task<CategoryBrandDto[]> CategoryBrandList()
        {
            return _httpClient.GetFromJsonAsync<CategoryBrandDto[]>("api/Categories/categorygbrandlist");
        }

        public Task<CategoryDto[]> GetAllCategory()
        {
            return _httpClient.GetFromJsonAsync<CategoryDto[]>("api/Categories/categorygetall");
        }

      

        public Task ModelAdd(ModelDto model)
        {
            return _httpClient.PostAsJsonAsync("api/Categories/modeladd", model);
        }

        public Task<CategoryBrandModelDto[]> ModelList()
        {
            return _httpClient.GetFromJsonAsync<CategoryBrandModelDto[]>("api/Categories/modelgetall");
        }

        public Task<ModelDto[]> Models(int BrandId)
        {
            return _httpClient.GetFromJsonAsync<ModelDto[]>("api/Categories/modelgetbyid?Id=" + BrandId);
        }
    }
}