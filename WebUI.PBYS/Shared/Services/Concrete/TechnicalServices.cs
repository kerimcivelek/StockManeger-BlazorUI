using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;
using WebUI.PBYS.Shared.Services.Abstract;
using WebUI.PBYS.Shared.Utilities;

namespace WebUI.PBYS.Shared.Services.Concrete
{
    public class TechnicalServices : ITechnicalService
    {
        private HttpClient _httpClient;
        public TechnicalServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task Add(TechnicalServiceDto model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/TechnicalServices/add", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<TechnicalServiceDto[]> GetAll()
        {
             return   _httpClient.GetFromJsonAsync<TechnicalServiceDto[]>("api/TechnicalServices/getall");
        }

        public Task<TechnicalServiceDto> GetById(int Id)
        {
            return _httpClient.GetFromJsonAsync<TechnicalServiceDto>("api/TechnicalServices/detail?Id=" + Id);
        }
    }
}
