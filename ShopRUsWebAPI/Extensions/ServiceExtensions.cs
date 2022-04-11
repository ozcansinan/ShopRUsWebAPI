using Microsoft.Extensions.DependencyInjection;
using ShopRUsWebAPI.Helpers;
using ShopRUsWebAPI.Services;

namespace ShopRUsWebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDiscountService(this IServiceCollection services) =>
          services.AddScoped<IDiscountService, DiscountService>();
        public static void ConfigureDiscountHelper(this IServiceCollection services) =>
          services.AddScoped<IDisCountHelper, DiscountHelper>();

    }
}
