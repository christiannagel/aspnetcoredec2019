using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddTransient<IGreetingService, GreetingService>();
                    services.AddTransient<HelloController>();
                }).Build();

            var controller = host.Services.GetRequiredService<HelloController>();
            string result = controller.Index("Katharina");
            Console.WriteLine(result);
        }

    }
}
