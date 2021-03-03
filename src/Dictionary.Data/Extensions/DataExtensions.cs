using Microsoft.Extensions.DependencyInjection;

namespace Dictionary.Data.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddData(this IServiceCollection service)
        {
            service.AddScoped<UserRepository>();
            return service;
        }
    }
}
