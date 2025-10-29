using EcommerceGateway.Services.Interfaces;

namespace EcommerceGateway.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly HttpClient _httpClient;

        public InventoryService(IHttpClientFactory httpClientFactory)
        {
            this._httpClient = httpClientFactory.CreateClient("InventoryService");
        }
    }
}
