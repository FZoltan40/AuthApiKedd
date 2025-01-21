using AuthApi.Datas;
using AuthApi.Models;
using AuthApi.Models.Dtos;
using AuthApi.Services.IAuthService;
using Microsoft.AspNetCore.Identity;

namespace AuthApi.Services
{
    public class AuthService : IAuth
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AuthService(AppDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public Task<string> Register(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
