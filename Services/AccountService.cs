using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebAppAPI.Models;

namespace WebApp.Services
{

	public class AccountService
	{
		private readonly HttpClient _httpClient;

		public AccountService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

        public async Task<HttpResponseMessage> RegisterAsync(RegisterModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("http://localhost:64508/api/Users/register", content);
            return response;
        }

        public async Task<HttpResponseMessage> LoginAsync(LoginModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("http://localhost:64508/api/Users/login", content);
            return response;
        }
    }

}