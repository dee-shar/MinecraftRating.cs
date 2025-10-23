using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinecraftRatingApi
{
	public class MinecraftRatingClient {
		private readonly HttpClient _client;
		private readonly string _baseUrl = "https://minecraftrating.ru/api";
		public MinecraftRatingClient() {
			_client = new HttpClient();
			_client.DefaultRequestHeaders.Add("User-Agent",
				"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
		}

		public async Task<string> RegisterAccount(string login, string email, string password) {
			var data = $"login={login}&email={email}&password={password}";
			return await PostAsync("/register/", data);
		}

		public async Task<string> Login(string username, string password) {
			var data = $"login_name={username}&login_password={password}&login=submit";
			return await PostAsync("/register/", data);
		}

		public async Task<string> AddServer(string serverAddress) {
			var data = $"ip={serverAddress}";
			return await PostAsync("/add-server/", data);
		}

		private async Task<string> PostAsync(string endpoint, string formData) {
			var content = new StringContent(formData, Encoding.UTF8, "application/x-www-form-urlencoded");
			var response = await _client.PostAsync($"{_baseUrl}{endpoint}", content);
			return await response.Content.ReadAsStringAsync();
		}
	}
}
