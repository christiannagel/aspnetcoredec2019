using Microsoft.Extensions.DependencyInjection;
using System;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var provider = GetServiceProvider();
            var controller = provider.GetRequiredService<HelloController>();
            string result = controller.Index("Katharina");
            Console.WriteLine(result);
        }

        static ServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<HelloController>();
            return services.BuildServiceProvider();
        }
    }
}
