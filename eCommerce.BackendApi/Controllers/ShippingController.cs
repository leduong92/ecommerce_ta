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
        [HttpPost("calculate")]
        public async Task<IActionResult> CalculateShipping([FromBody] ShippingCalculationRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var options = await _shippingCalculator.CalculateShippingRates(
                                                    request.DestinationCountryCode,
                                                    request.DestinationStateProvince,
                                                    request.DestinationZipCode,
                                                    request.DestinationLatitude, // New
                                                    request.DestinationLongitude, // New
                                                    request.OrderItems,
                                                    request.TotalOrderValue,
                                                    request.DestinationFloorNumber,
                                                    request.IsRuralArea
                                                );

            if (options == null || !options.Any())
            {
                return NotFound("No shipping options found for the specified criteria.");
            }
            return Ok(options);
        }
    }
}
