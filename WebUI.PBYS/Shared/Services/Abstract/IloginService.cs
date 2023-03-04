using WebUI.PBYS.Shared.Dto;

namespace WebUI.PBYS.Shared.Services.Abstract
{
    public interface IloginService
    {

        Task LoginControl(LoginDto loginModel);
        Task Logout();
    
        Task<UserInfoDto[]> Users();

        Task Register(UserInfoDto model);
        Task Update(UserInfoDto model);

        Task<UserInfoDto> GetByUser(int userId);

        Task<UserDto> GetUserInfo(Guid key);

        Task SetAuthorizationHeader();
    }
}
