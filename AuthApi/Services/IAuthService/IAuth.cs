using AuthApi.Models.Dtos;

namespace AuthApi.Services.IAuthService
{
    public interface IAuth
    {
        Task<object> Register(CreateUserDto createUserDto);
        Task<object> Login(LoginIUserDto loginIUserDto);
    }
}
