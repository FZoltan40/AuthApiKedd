using AuthApi.Datas;
using AuthApi.Models;
using AuthApi.Models.Dtos;
using AuthApi.Services.IAuthService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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

        public async Task<object> Register(CreateUserDto createUserDto)
        {
            var user = new ApplicationUser
            {
                UserName = createUserDto.UserName,
                Email = createUserDto.Email,
                BirthDate = createUserDto.BirthDate,
                PhoneNumber = createUserDto.PhoneNumber
            };

            var res = await userManager.CreateAsync(user, createUserDto.Password);

            if (res.Succeeded)
            {
                var existingUser = await _dbContext.applicationUsers.FirstOrDefaultAsync(user => user.UserName == createUserDto.UserName);

                return new { result = new { user.UserName, user.Email }, message = "Sikeres regisztráció." };
            }

            return new { result = "", message = res.Errors.FirstOrDefault().Description };
        }
    }
}
