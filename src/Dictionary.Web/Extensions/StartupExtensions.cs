using System;
using Dictionary.Data;
using Dictionary.Web.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace Dictionary.Web.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection SetupConfiguration<T>(this IServiceCollection service, 
            IHostEnvironment environment, IConfiguration configuration)
            where T : class
        {
            var config = Activator.CreateInstance<T>();

            var name = typeof(T).Name;
            if (environment.IsDevelopment())
            {
                configuration.Bind(name, config);
            }
            else
            {
                var value = Environment.GetEnvironmentVariable(name);
                try
                {
                    JsonConvert.PopulateObject(value, config);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            service.AddSingleton(config);

            return service;
        }

        public static IServiceCollection AddMongoDb(this IServiceCollection service, IHostEnvironment environment, IConfiguration configuration)
        {
            service.SetupConfiguration<MongoDbConnect>(environment, configuration);
            service.AddSingleton<MongoDbContext>();
            return service;
        }
    }
}
