using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Nest;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [AuthorizeCookie]
    public class HomeController : Controller
    {
		private readonly ILogger<HomeController> _logger;
		//private readonly IRepository _repo;
		//private readonly IHttpContextAccessor _context;
		//private readonly IStringLocalizer<HomeController> _local;

		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
			//_repo = repo;
			//_context = context;
			//_local = local;
		}

        public IActionResult Index()
        {
			_logger.LogInformation("Это информационное сообщение");
			_logger.LogWarning("Это предупреждение");
			_logger.LogError("Это сообщение об ошибке: {0}","");
			return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
