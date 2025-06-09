using ECommerce.Application.Common.Interfaces;
using ECommerce.Domain.Common;
using Microsoft.Extensions.Configuration;


namespace ECommerce.Infrastructure.Common
{
	public class JwtSettingsService : IJwtSettingsService
	{
		private readonly JwtSettings _jwtSettings;

		public JwtSettingsService(IConfiguration configuration)
		{
			_jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
		}

		public JwtSettings GetJwtSettings() => _jwtSettings;
	}
}
