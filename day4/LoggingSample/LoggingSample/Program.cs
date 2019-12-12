using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    //logging.AddConsole();
                    //logging.AddDebug();
                    //logging.AddSerilog
                })
                .ConfigureServices(services =>
                {
                    services.AddTransient<MyService>();
                })
                .Build();

            var service = host.Services.GetRequiredService<MyService>();
            service.Foo();
        }
    }
}
