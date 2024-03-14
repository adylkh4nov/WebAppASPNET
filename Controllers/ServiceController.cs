using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class ServiceController : Controller
	{
		// GET: ServiceController
		public ActionResult Index()
		{
			return View();
		}

	}
}
