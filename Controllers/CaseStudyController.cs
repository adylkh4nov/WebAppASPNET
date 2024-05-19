using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    [AuthorizeCookie]
    public class CaseStudyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
