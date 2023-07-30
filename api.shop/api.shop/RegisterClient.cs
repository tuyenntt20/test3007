using api.shop.Clients;
using api.shop.Interfaces.Clients;

namespace api.shop
{
    public static class RegisterClient
    {
        public static void ConfigureClients(this IServiceCollection services)
        {
            services.AddHttpClient();

            services.AddScoped<IHttpClientBase, HttpClientBase>();

            services.AddScoped<ICategoryClient, CategoryClient>();
        }
    }
}

