using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using WebApp.Models;
using WebApp.Services;


namespace WebApp.Controllers
{
    [AuthorizeCookie]
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
				return RedirectToAction("Index"); // Перенаправление на другую страницу после успешного создания 

			}
		}

		[HttpPost]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					var res = await httpClient.DeleteAsync("http://localhost:64508/api/Message/" + id);
					return RedirectToAction("Index");
				}


			}
			catch (Exception)
			{
				return RedirectToAction("Index"); // Перенаправление на другую страницу после успешного создания 

			}
		}
	}
}
