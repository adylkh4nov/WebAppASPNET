using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [AuthorizeCookie]
    public class ServiceController : Controller
	{
		// GET: ServiceController
		
		async public Task<IActionResult> Index()
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					var res = await httpClient.GetAsync("http://localhost:64508/api/Message");

					if (res.IsSuccessStatusCode)
					{
						var content = await res.Content.ReadAsStringAsync();
						var messages = JsonConvert.DeserializeObject<List<Message>>(content);
						return View(messages);
					}
					else
					{
						// Handle error response
						// For simplicity, returning an empty view with no messages
						return View(new List<Message>());
					}
				}


			}
			catch (Exception)
			{
				return RedirectToAction("Index"); // Перенаправление на другую страницу после успешного создания 

			}
		}

	}
}
