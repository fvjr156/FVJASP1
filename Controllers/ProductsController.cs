using Microsoft.AspNetCore.Mvc;
using FVJASP1.Models;

namespace FVJASP1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreService _storeService;

        public ProductsController(StoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _storeService.GetAllProducts();
            return Ok(products);
        }
    }
}
