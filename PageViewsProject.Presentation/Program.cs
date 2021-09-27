using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PageViewsProject.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace PageViewsProject.Presentation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            // Get Service and call method
            var service = serviceProvider.GetService<IStartApplication>();
            Task.WaitAll(service.GetInformationViews());


        }
    }
}
