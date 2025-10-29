using EcommerceGateway.Services;
using EcommerceGateway.Services.Interfaces;

namespace EcommerceGateway.ServiceExtension
{
    public static class DIServices
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services)
        {
            //========= Register HttpClients for microservices ==============
            services.AddHttpClient("InventoryService", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7280/");
            });

            services.AddHttpClient("OrderService", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7002/");
            });
            // ======= End =======

            // ======= Register services =======
            services.AddScoped<IInventoryService, InventoryService>();
            // ======= End =======

            return services;
        }
    }
}
