using EcommerceGateway.Services.Interfaces;
using EcommerceGateway.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceGateway.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            this._inventoryService = inventoryService;
        }

        #region Product

        [HttpGet("product/getall-by-categoryid")]
        public async Task<ActionResult<ApiResponse<ProductVM>>> GetProductByCategoryId([FromQuery] long categoryId = 0)
        {
            var data = await _inventoryService.GetProductByCategoryId(categoryId);

            if (!data.Success) return StatusCode(data.StatusCode, data);

            return Ok(data);
        }

        [HttpGet("product/getall-by-brandid")]
        public async Task<ActionResult<ApiResponse<List<ProductVM>>>> GetProductByBrandId([FromQuery] long brandId)
        {
            var data = await _inventoryService.GetProductByBrandId(brandId);

            if (!data.Success) return StatusCode(data.StatusCode, data);

            return Ok(data);
        }

        [HttpGet("product/by-id")]
        public async Task<IActionResult> GetProductsById([FromQuery] long productVariantId)
        {
            var product = await _inventoryService.GetProductByVariantId(productVariantId);

            if (!product.Success) return StatusCode(product.StatusCode, product);

            return Ok(product);
        }
        [HttpPost("product/by-ids")]
        public async Task<IActionResult> GetProductsByIds([FromBody] List<long> productVariantIds)
        {
            var products = await _inventoryService.GetProductByVariantIds(productVariantIds);

            if (!products.Success) return StatusCode(products.StatusCode, products);

            return Ok(products);
        }

        [HttpGet("product/categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var data = await _inventoryService.GetAllCategoriesWithProductCount();

            if (!data.Success) return StatusCode(data.StatusCode, data);

            return Ok(data);
        }

        [HttpGet("product/brands/{categoryId:long}")]
        public async Task<IActionResult> GetAllBrandsByCategoryId(long categoryId)
        {
            var data = await _inventoryService.GetAllBrandsByCategoryId(categoryId);

            if (!data.Success) return StatusCode(data.StatusCode, data);

            return Ok(data);
        }

        [HttpGet("product/categories/{brandId:long}")]
        public async Task<IActionResult> GetAllCategoriesByBrandId(long brandId)
        {
            var data = await _inventoryService.GetAllCategoriesByBrandId(brandId);

            if (!data.Success) return StatusCode(data.StatusCode, data);

            return Ok(data);
        }

        #endregion 
    }
}
