# minecraft_rating.cs
Web-API for [minecraftrating.ru](https://minecraftrating.ru) an website that serves as popular monitoring service for Minecraft servers in Russia.

## Example
```cs
using System;
using MinecraftRating;
using System.Threading.Tasks;

namespace Application {
    internal class Program {
        static async Task Main() {
            var api = new MinecraftRatingApi();
            string loginResponse = await api.Login("username", "password");
            Console.WriteLine(loginResponse);
        }
    }
}
```
