using eCommerce.Application.Interface;
using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthService authService
            , IConfiguration configuration
            )
        {
            _authService = authService;
            _configuration = configuration;
        }
        [HttpGet("region")]
        public async Task<IActionResult> GetRegionsAsync()
        {
            var response = await _authService.GetRegionsAsync();
            return Ok(response);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDto model)
        {
            var response = await _authService.RegisterAsync(model);
            if (!response.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var response = await _authService.LoginAsync(model);
            if (response.Data == null)
            {
                return BadRequest();
            }
            return Ok(response);

        }

        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegisterationRequestDto model)
        {
            var response = await _authService.AssignRoleAsync(model);
            if (!response.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(response);

        }
    }
}
