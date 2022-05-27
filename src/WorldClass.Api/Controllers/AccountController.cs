using Microsoft.AspNetCore.Mvc;
using WorldClass.Application.Dto;

namespace WorldClass.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("signUp")] //TODO норм такое имя
        public async Task<IActionResult> SignUpAsync(SignUpDto signUpDto)
        {
            return Ok(signUpDto);
        }

        [HttpPost("signIn")]
        public async Task<IActionResult> SignInAsync(SignInDto signInDto)
        {
            return Ok(signInDto);
        }

        [HttpPost("refresh-token")]
        public async Task<string> RefreshTokenAsync()
        {
            return "";
        }
    }
}
