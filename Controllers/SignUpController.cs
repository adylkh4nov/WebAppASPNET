using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebApp.Services;
using WebAppAPI.Models;

namespace WebApp.Controllers
{
    public class SignUpController : Controller
    {
        private readonly AccountService _accountService;

        public SignUpController(AccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accountService.RegisterAsync(model);
                if (response.IsSuccessStatusCode)
                {
                    var tokenResponse = await response.Content.ReadAsStringAsync();
                    var token = JObject.Parse(tokenResponse)["token"].ToString();

                    Response.Cookies.Append("token", token);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Registration failed. Please try again.");
            }

            return View(model);
        }
    }
    }
