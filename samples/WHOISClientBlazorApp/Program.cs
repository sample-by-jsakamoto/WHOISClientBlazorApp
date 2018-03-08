using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;

namespace WHOISClientBlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                // Add any custom services here
            });

            new BrowserRenderer(serviceProvider).AddComponent<WHOISClientBlazorApp.Pages.Home>("app");
            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseContentRoot(Directory.GetCurrentDirectory())
            //    .UseIISIntegration()
            //    .UseStartup<Startup>()
            //    .UseApplicationInsights()
            //    .Build();

            //host.Run();
        }
    }
}
