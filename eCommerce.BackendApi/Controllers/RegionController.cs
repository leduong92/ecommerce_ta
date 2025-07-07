using eCommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : Controller
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }
        [HttpGet]
        public async Task<IActionResult> GetRegionsAsync()
        {
            var results = await _regionService.GetRegionsAsync();
            return Ok(results);
        }
    }
}
