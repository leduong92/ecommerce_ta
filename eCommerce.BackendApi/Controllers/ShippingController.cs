using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : Controller
    {
        private readonly ShippingCalculatorService _shippingCalculator;

        public ShippingController(ShippingCalculatorService shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        [HttpPost("calculate-shipping")]
        public async Task<IActionResult> CalculateShipping([FromBody] CheckoutRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var options = await _shippingCalculator.CalculateShippingRates(
                                                    request.ShippingCountryCode,
                                                    request.ShippingStateProvince,
                                                    request.ShippingZipCode,
                                                    request.ShippingLatitude, // New
                                                    request.ShippingLongitude, // New
                                                    request.OrderItemDetails,
                                                    request.TotalOrderValue,
                                                    request.ShippingFloorNumber,
                                                    request.ShippingIsRuralArea
                                                );

            if (options == null || !options.Data.Any())
            {
                return NotFound("No shipping options found for the specified criteria.");
            }
            return Ok(options);
        }
    }
}
