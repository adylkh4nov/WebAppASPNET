using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    [AuthorizeCookie]
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
