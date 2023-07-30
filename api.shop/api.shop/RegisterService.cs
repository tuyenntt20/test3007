using api.shop.Clients;
using api.shop.Interfaces;
using api.shop.Interfaces.Clients;
using api.shop.Services;

namespace api.shop
{
    public static class RegisterService
	{
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}

