using ECommerce.Application.Auth.DTOs;
using ECommerce.Application.Auth.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginRequest request)
		{
			try
			{
				var result = await _authService.LoginAsync(request);
				return Ok(result);
			}
			catch (UnauthorizedAccessException)
			{
				return Unauthorized("Invalid credentials");
			}
		}
	}
}
