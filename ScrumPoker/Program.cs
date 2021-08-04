using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ScrumPoker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // use this to allow command line parameters in the config
            //var configuration = new ConfigurationBuilder()
            //    .AddCommandLine(args)
            //    .Build();

            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseUrls("http://0.0.0.0:5000")
            //    .UseContentRoot(Directory.GetCurrentDirectory())
            //    .UseIISIntegration()
            //    .UseStartup<Startup>()
            //    .UseConfiguration(configuration)
            //    .Build();

            //host.Run();
            Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .Build()
            .Run();
        }
    }
}
