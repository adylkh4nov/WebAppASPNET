using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class PageController : Controller
	{
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Career()
		{
			return View();
		}
	}
}
