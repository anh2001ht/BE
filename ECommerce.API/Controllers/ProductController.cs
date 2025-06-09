using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		[Authorize(Roles = "Admin")] 
		public IActionResult GetAllProducts()
		{
			return Ok("List of products");
		}
	}
}
