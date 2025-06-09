using ECommerce.Application.Auth.DTOs;
using ECommerce.Application.Auth.Interfaces;
using ECommerce.Persistence;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommerce.Infrastructure.Auth;

public class AuthService : IAuthService
{
	private readonly ApplicationDbContext _context;
	private readonly IConfiguration _config;

	public AuthService(ApplicationDbContext context, IConfiguration config)
	{
		_context = context;
		_config = config;
	}

	public async Task<LoginResponse> LoginAsync(LoginRequest request)
	{
		var user = await _context.Users.Include(x => x.UserRoles)
						.ThenInclude(x=> x.Role)
						.FirstOrDefaultAsync(x => x.Email == request.Email);
		if (user == null || user.PasswordHash != request.Password) 
			throw new UnauthorizedAccessException("Invalid username or password");

		var token = GenerateJwtToken(user);

		return new LoginResponse
		{
			Token = token,
			Email = user.Email,
			Role = user.UserRoles.First().Role.Name
	};
	}

	private string GenerateJwtToken(User user)
	{
		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]!));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var claims = new[]
		{
			new Claim(ClaimTypes.Email, user.Email),
			new Claim(ClaimTypes.Role, user.UserRoles.First().Role.Name),
		};

		var token = new JwtSecurityToken(
			issuer: _config["Jwt:Issuer"],
			audience: _config["Jwt:Audience"],
			claims: claims,
			expires: DateTime.UtcNow.AddHours(2),
			signingCredentials: creds
		);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}
}
