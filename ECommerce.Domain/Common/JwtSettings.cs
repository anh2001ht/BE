using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Common
{
	public class JwtSettings
	{
		public string SecretKey { get; init; }
		public int ExpiryMinutes { get; init; }
		public string Issuer { get; init; }
		public string Audience { get; init; }
	}
}
