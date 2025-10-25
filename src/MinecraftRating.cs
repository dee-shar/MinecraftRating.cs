using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinecraftRating {
    public class MinecraftRatingApi {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://minecraftrating.ru/api";
        public MinecraftRatingApi() {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent",
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
            var response = await httpClient.PostAsync($"{apiUrl}{endpoint}", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
