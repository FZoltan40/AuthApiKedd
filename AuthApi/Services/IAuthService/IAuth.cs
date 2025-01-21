using AuthApi.Models.Dtos;

namespace AuthApi.Services.IAuthService
{
    public interface IAuth
    {
        Task<string> Register(CreateUserDto createUserDto);
    }
}
