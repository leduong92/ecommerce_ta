using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using eCommerce.Web.Services.IService;
using Microsoft.Extensions.Localization;

namespace eCommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ProductController> _logger;
        private readonly IProductApiClient _productApiClient;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _localizer;
        public ProductController(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<ProductController> logger
            , IProductApiClient productApiClient
            , IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _productApiClient = productApiClient;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id, string regionCode)
        {
            ViewBag.CurrentRegion = regionCode;
            ViewData["Message"] = _localizer["Welcome"];
            ViewData["Culture"] = Thread.CurrentThread.CurrentUICulture.Name;

            //var client = _httpClientFactory.CreateClient("ApiClient");
            var latitude = HttpContext.Session.GetString("CustomerLatitude");
            var longitude = HttpContext.Session.GetString("CustomerLongitude");

            //string requestUrl = $"{_apiBaseUrl}Product/{id}/detail/{regionCode}";
            //if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            //{
            //    requestUrl += $"?latitude={latitude}&longitude={longitude}";
            //}

            //_logger.LogInformation($"Requesting product details from: {requestUrl}");

            //var response = await client.GetAsync(requestUrl);
            var response = await _productApiClient.GetProductDetail(id, regionCode, latitude, longitude);

            if (response.IsSuccess)
            {
                //var content = await response.Content.ReadAsStringAsync();
                //var product = JsonSerializer.Deserialize<ProductDetailDto>(content, new JsonSerializerOptions
                //{
                //    PropertyNameCaseInsensitive = true
                //});
                return View(response.Data);
            }
            else if (response.StatusCode == 404)
            {
                TempData["ErrorMessage"] = $"Product {id} not found or not available in region '{regionCode}'.";
                return RedirectToAction("Index", "Home", new { regionCode = regionCode });
            }
            else
            {
                TempData["ErrorMessage"] = $"Error fetching product details: {response.Message}";
                _logger.LogError($"Error fetching product details: {response.StatusCode} - {response.Message}");
                return RedirectToAction("Index", "Home", new { regionCode = regionCode });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity, string regionCode)
        {
            if (quantity <= 0)
            {
                TempData["ErrorMessage"] = "Quantity must be positive.";
                return RedirectToAction("Detail", new { id = productId, regionCode = regionCode });
            }

            var client = _httpClientFactory.CreateClient("ApiClient");
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                // Nếu chưa có Session, khởi tạo Session ID mới ( ASP.NET Core tự làm)
                // và thiết lập một giá trị bất kỳ để kích hoạt Session
                HttpContext.Session.SetString("Initialized", DateTime.UtcNow.ToString());
                sessionId = HttpContext.Session.Id;
            }

            // Use the AddToCartRequest DTO from the API project
            var requestData = new AddToCartRequest
            {
                SessionId = sessionId,
                ProductId = productId,
                Quantity = quantity,
                CustomerRegionCode = regionCode
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{_apiBaseUrl}ShoppingCart/add", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Product added to cart successfully!";
                return RedirectToAction("Index", "Cart");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error adding to cart: {response.StatusCode} - {errorContent}");
                TempData["ErrorMessage"] = $"Error adding product to cart: {errorContent}";
                return RedirectToAction("Detail", new { id = productId, regionCode = regionCode });
            }
        }
    }
}
