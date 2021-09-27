using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PageViewsProject.Application;
using PageViewsProject.Application.Interfaces;
using PageViewsProject.Domain.Entities;
using PageViewsProject.Infraestructure;
using PageViewsProject.Infraestructure.Interfaces;
using System;
using System.IO;

namespace PageViewsProject.Presentation
{
    public class Startup
    {
        
        
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSingleton<IConfigurationRoot>(Configuration);
            services.AddSingleton<IStartApplication, StartApplication>();
            services.AddSingleton<IUrlApplication, UrlApplication>();
            services.AddSingleton<IDownloadInfraestructure, DownloadInfraestructure>(); 
            services.AddSingleton<IDescompressionApplication, DescompressionApplication>();
            services.AddSingleton<IReadStreamApplication, ReadStreamApplication>();
            services.AddSingleton<IListPageApplication, ListPageApplication>(); 
            services.AddSingleton<IResultPageViewApplication, ResultPageViewApplication>();
            services.AddSingleton<IOutputResultApplication, OutputResultApplication>();
            services.AddSingleton(Configuration.GetSection("myConfiguration").Get<MyConfiguration>());
        }

        
    }
}
