using EcommerceGateway.Services.Interfaces;
using EcommerceGateway.ViewModels;

namespace EcommerceGateway.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly HttpClient _httpClient;

        public InventoryService(IHttpClientFactory httpClientFactory)
        {
            this._httpClient = httpClientFactory.CreateClient("InventoryService");
        }

        public async Task<ApiResponse<List<ProductVM>>> GetProductByBrandId(long brandId)
        {
            var response = await _httpClient.GetAsync($"api/product/getall-by-brandid?brandId={brandId}");

            
            if(!response.IsSuccessStatusCode)
            {
                return ApiResponse<List<ProductVM>>.ErrorResponse($"Inventory API returnd error: {response.StatusCode}",(int)response.StatusCode);
            }
            var result = await response.Content.ReadFromJsonAsync<ApiResponse<List<ProductVM>>>();

            return result ?? ApiResponse<List<ProductVM>>.ErrorResponse("Invalid API response");
        }

        public async Task<ApiResponse<List<ProductVM>>> GetProductByCategoryId(long categoryId)
        {
            var response = await _httpClient.GetAsync($"api/product/getall-by-categoryid?categoryId={categoryId}");


            if (!response.IsSuccessStatusCode)
            {
                return ApiResponse<List<ProductVM>>.ErrorResponse($"Inventory API returnd error: {response.StatusCode}", (int)response.StatusCode);
            }
            var result = await response.Content.ReadFromJsonAsync<ApiResponse<List<ProductVM>>>();

            return result ?? ApiResponse<List<ProductVM>>.ErrorResponse("Invalid API response");
        }

        public async Task<ApiResponse<ProductVM?>> GetProductByVariantId(long variantId)
        {
            var response = await _httpClient.GetAsync($"api/product/by-id?productVariantId={variantId}");


            if (!response.IsSuccessStatusCode)
            {
                return ApiResponse<ProductVM?>.ErrorResponse($"Inventory API returnd error: {response.StatusCode}", (int)response.StatusCode);
            }
            var result = await response.Content.ReadFromJsonAsync<ApiResponse<ProductVM?>>();

            return result ?? ApiResponse<ProductVM?>.ErrorResponse("Invalid API response");
        }

        public async Task<ApiResponse<List<ProductVM>>> GetProductByVariantIds(List<long> variantIds)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/product/by-ids",variantIds);


            if (!response.IsSuccessStatusCode)
            {
                return ApiResponse<List<ProductVM>>.ErrorResponse($"Inventory API returnd error: {response.StatusCode}", (int)response.StatusCode);
            }
            var result = await response.Content.ReadFromJsonAsync<ApiResponse<List<ProductVM>>>();

            return result ?? ApiResponse<List<ProductVM>>.ErrorResponse("Invalid API response");
        }
    }
}
