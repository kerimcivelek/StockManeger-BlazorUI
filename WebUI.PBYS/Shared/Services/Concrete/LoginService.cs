using Blazored.LocalStorage;
using Blazored.SessionStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebUI.PBYS.Shared.Dto;
using WebUI.PBYS.Shared.Services.Abstract;
using WebUI.PBYS.Shared.Utilities;

namespace WebUI.PBYS.Shared.Services.Concrete
{
    public class LoginService : IloginService
    {
        private HttpClient _http;
        private ISessionStorageService _sessionStorage;
        private ILocalStorageService _localStorageService;
        public bool IsLoggedIn { get; private set; }
        public LoginService(HttpClient http,  ISessionStorageService sessionStorage , ILocalStorageService localStorageService)
        {
            _http = http;
            _sessionStorage = sessionStorage;
            _localStorageService = localStorageService; 
        }

        public async Task LoginControl(LoginDto loginDto)
        {
            var response = await _http.PostAsJsonAsync("api/Auth/login", loginDto);
            var result = await response.Content.ReadFromJsonAsync<TokenDto>();
           
            if (!string.IsNullOrEmpty(result.Token))
            {
               
                 await _sessionStorage.SetItemAsync("userkey", result.userkey);
                 await _sessionStorage.SetItemAsync("token", result.Token);
                
                 await SetAuthorizationHeader();
                 IsLoggedIn = true;

            }
        }


        public async Task SetAuthorizationHeader()
        {
            if (!_http.DefaultRequestHeaders.Contains("Authorization"))
            {
                var token = await _sessionStorage.GetItemAsync<string>("token");
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            }

        }

        public async Task Logout()
        {
            await _sessionStorage.RemoveItemAsync("token");
            await _sessionStorage.RemoveItemAsync("userkey");
            IsLoggedIn = false;
        }

        public  Task<UserDto> GetUserInfo(Guid key)
        {
            return _http.GetFromJsonAsync<UserDto>("api/Auth/getbyuser?key=" + key);
            
        }

        public  Task<UserInfoDto[]> Users()
        {
            return _http.GetFromJsonAsync<UserInfoDto[]>("api/Auth/getall");
        }

        public async Task Update(UserInfoDto model)
        {
            var response = await _http.PostAsJsonAsync("api/Auth/update", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

        public Task<UserInfoDto> GetByUser(int userId)
        {
            return _http.GetFromJsonAsync<UserInfoDto>("api/Auth/getbyuserid?Id=" + userId);
        }

        public async Task Register(UserInfoDto model)
        {
            var response = await _http.PostAsJsonAsync("api/Auth/register", model);
            var exception = await response.Content.ReadAsStringAsync();
            BaseException.ResponseException(exception);
        }

       
    }





}
