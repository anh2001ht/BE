using ECommerce.Application.Auth.Interfaces;
using ECommerce.Application.Common.Interfaces;
using ECommerce.Domain.Common;
using ECommerce.Infrastructure.Auth;
using ECommerce.Infrastructure.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			IConfigurationSection jwtSection = configuration.GetSection("JwtSettings");
			services.Configure<JwtSettings>(jwtSection);
			services.AddSingleton<IJwtSettingsService, JwtSettingsService>();
			services.AddScoped<IAuthService, AuthService>();
			return services;
		}
	}
}
