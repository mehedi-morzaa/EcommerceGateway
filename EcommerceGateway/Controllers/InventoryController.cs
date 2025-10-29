using EcommerceGateway.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            this._inventoryService = inventoryService;
        }
    }
}
