using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Challenge.Api
{
    public class Program
    {
        public static void Main(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { 
                webBuilder.UseStartup<Startup>();
            }).Build().Run();
    }
}
