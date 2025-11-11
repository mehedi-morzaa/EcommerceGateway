using EcommerceGateway.ViewModels;

namespace EcommerceGateway.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<ApiResponse<List<ProductVM>>> GetProductByCategoryId(long categoryId);
        Task<ApiResponse<List<ProductVM>>> GetProductByBrandId(long brandId);
        Task<ApiResponse<List<ProductVM>>> GetProductByVariantIds(List<long> variantIds);
        Task<ApiResponse<ProductVM?>> GetProductByVariantId(long variantId);

        Task<ApiResponse<List<ProductCategoryVM>>> GetAllCategoriesWithProductCount();
        Task<ApiResponse<List<BrandVM>>> GetAllBrandsWithProductCount();

        Task<ApiResponse<List<ProductCategoryVM>>> GetAllCategoriesByBrandId(long brandId);
        Task<ApiResponse<List<BrandVM>>> GetAllBrandsByCategoryId(long categoryId);
    }
}
