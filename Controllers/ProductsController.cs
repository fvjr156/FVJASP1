using Microsoft.AspNetCore.Mvc;
using FVJASP1.Models;
using System.Threading.Tasks;

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

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct([FromQuery] string ProductName, [FromQuery] string BrandName, [FromQuery] double Price)
        {
            var product = new Product
            {
                ProductName = ProductName,
                BrandName = BrandName,
                Price = Price
            };

            await _storeService.AddProductAsync(product);
            return Ok(new { message = "Product added successfully" });
        }
    }
}
