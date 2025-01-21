using AuthApi.Models.Dtos;
using AuthApi.Services.IAuthService;

namespace AuthApi.Services
{
    public class AuthService : IAuth
    {
        public Task<string> Register(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
