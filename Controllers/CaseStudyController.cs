using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class CaseStudyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
