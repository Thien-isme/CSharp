using healthcareProject.Helpers;
using healthcareProject.Models.Request;
using healthcareProject.Models.Response;
using healthcareProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace healthcareProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserService userService;
        private readonly JwtHelper _jwtHelper;

        public LoginController(UserService userService, JwtHelper jwtHelper)
        {
            this.userService = userService;
            _jwtHelper = jwtHelper;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if(request == null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Email and Password are required.");
            }

            var user = await userService.Login(request.Email, request.Password);
            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var token = JwtHelper.GenerateToken(user);
            return Ok(new LoginUserResponse
            {
                Message = "Login successful",
                Token = token,
                UserId = user.UserId,
                FullName = user.FullName,
                Email = user.Email,
                Role = user.Role
            });

        }
    }
}
