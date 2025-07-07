using eCommerce.Application.Interfaces;
using eCommerce.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Gets a list of products available in a specific region, with region-specific prices and estimated stock.
        /// </summary>
        /// <param name="regionCode">The 2-letter ISO country code or custom region code (e.g., "US", "VN").</param>
        /// <param name="latitude">Optional: Customer's latitude for more accurate nearest warehouse finding.</param>
        /// <param name="longitude">Optional: Customer's longitude for more accurate nearest warehouse finding.</param>
        /// <returns>A list of ProductListDto.</returns>
        [HttpGet("by-region/{regionCode}")]
        public async Task<IActionResult> GetProductsByRegion(string regionCode, [FromQuery] double? latitude, [FromQuery] double? longitude)
        {
            try
            {
                var products = await _productService.GetProductsByRegionAsync(regionCode, latitude, longitude);
                if (!products.Data.Any())
                {
                    return NotFound($"No products found for region '{regionCode}'.");
                }
                return Ok(products);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Gets details for a single product, including region-specific price and inventory from the nearest warehouse.
        /// </summary>
        /// <param name="productId">The ID of the product.</param>
        /// <param name="regionCode">The 2-letter ISO country code or custom region code (e.g., "US", "VN").</param>
        /// <param name="latitude">Optional: Customer's latitude for more accurate nearest warehouse finding.</param>
        /// <param name="longitude">Optional: Customer's longitude for more accurate nearest warehouse finding.</param>
        /// <returns>A ProductDetailDto.</returns>
        [HttpGet("{productId}/detail/{regionCode}")]
        public async Task<IActionResult> GetProductDetail(int productId, string regionCode, [FromQuery] double? latitude, [FromQuery] double? longitude)
        {
            try
            {
                var product = await _productService.GetProductDetailsAsync(productId, regionCode, latitude, longitude);
                if (product == null)
                {
                    return NotFound($"Product {productId} not found or not available in region '{regionCode}'.");
                }
                return Ok(product);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
