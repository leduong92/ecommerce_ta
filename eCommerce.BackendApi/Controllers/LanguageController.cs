using eCommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLanguagesAsync()
        {
            var results = await _languageService.GetLanguagesAsync();
            return Ok(results);
        }
    }
}
