using Blazored.SessionStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;
using WebUI.PBYS.Shared.Services.Abstract;
using static System.Net.WebRequestMethods;

namespace WebUI.PBYS.Shared.Services.Concrete
{
    public class DashboardService : IDashboardService
    {
        private HttpClient _httpClient;
        private ISessionStorageService _sessionStorage;
        public DashboardService(HttpClient httpClient , ISessionStorageService sessionStorage)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
        }

 
        public Task<DashBoardTotalDto[]> DashboardTotalDay()
        {
            return _httpClient.GetFromJsonAsync<DashBoardTotalDto[]>("api/Dashboard/dashboardtotalday");
           
        }

        public Task<DashboardDetailDto[]> DashboardDetailDay(int EntryOut)
        {
            return _httpClient.GetFromJsonAsync<DashboardDetailDto[]>("api/Dashboard/dashboarddetaillday?EntryOut=" + EntryOut);
        }





       

    }
}
 
