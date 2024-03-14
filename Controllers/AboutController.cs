using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
	public class AboutController : Controller
	{
		private readonly _DbContext _context;

		public AboutController(_DbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateMessage(MessageASP message)
		{
			try
			{ 
				_context.Add(message);

			}
			catch (Exception)
			{
				return RedirectToAction("Index"); // Перенаправление на другую страницу после успешного создания сообщения

				throw;
			}
			// Обработка полученного сообщения
			// Ваша логика сохранения сообщения или что-то еще
			return RedirectToAction("Index"); // Перенаправление на другую страницу после успешного создания сообщения

		}
	}
}
