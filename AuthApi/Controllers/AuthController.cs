using AuthApi.Models.Dtos;
using AuthApi.Services.IAuthService;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;

        public AuthController(IAuth auth)
        {
            this.auth = auth;
        }

        [HttpPost("Register")]
        public async Task<ActionResult> AddNewUser(CreateUserDto createUserDto)
        {
            return Ok();
        }
    }
}
