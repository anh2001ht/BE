using ECommerce.Application.Auth.DTOs;

namespace ECommerce.Application.Auth.Interfaces
{
	public interface IAuthService
	{
		Task<LoginResponse> LoginAsync(LoginRequest request);
	}
}
