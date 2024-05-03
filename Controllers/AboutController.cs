using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using WebApp.Models;


namespace WebApp.Controllers
{
	public class AboutController : Controller
	{

		public AboutController()
		{
			
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
		public async Task<IActionResult> CreateMessage(Message message)
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					var res = await httpClient.PostAsJsonAsync("http://localhost:64508/api/Message", message);
					return RedirectToAction("Index");
				}


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
