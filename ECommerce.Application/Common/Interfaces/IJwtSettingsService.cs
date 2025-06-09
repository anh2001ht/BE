using ECommerce.Domain.Common;

namespace ECommerce.Application.Common.Interfaces
{
	public interface IJwtSettingsService
	{
		JwtSettings GetJwtSettings();
	}
}
