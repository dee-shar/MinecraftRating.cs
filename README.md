# minecraft_rating.cs
Web-API for [minecraftrating.ru](https://minecraftrating.ru) is the most popular monitoring of Minecraft servers in Runet

## Example
```cs
using System;
using System.Threading.Tasks;
using MinecraftRatingApi;

namespace Application {
	internal class Program {
		static async Task Main() {
			var api = new MinecraftRatingClient();
			string loginResponse = await api.Login("testuser", "password123");
			Console.WriteLine(loginResponse);
		}
	}
}
```
