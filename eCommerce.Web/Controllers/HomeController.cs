using Azure;
using eCommerce.Application.Dtos;
using eCommerce.Web.Models;
using eCommerce.Web.Resources;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;


namespace eCommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer; // NEW

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration, IStringLocalizer<SharedResources> sharedLocalizer) // NEW
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
            _sharedLocalizer = sharedLocalizer; // NEW
        }

        public async Task<IActionResult> Index(string? regionCode)
        {
            // Lấy regionCode từ session nếu không có trong query string
            if (string.IsNullOrEmpty(regionCode))
            {
                regionCode = HttpContext.Session.GetString("CurrentRegion") ?? "US"; // Default to US
            }
            else
            {
                // Lưu regionCode vào session để duy trì qua các request
                HttpContext.Session.SetString("CurrentRegion", regionCode);
            }
            ViewBag.CurrentRegion = regionCode;
            ViewBag.Regions = new List<Tuple<string, string>>
            {
                Tuple.Create("US", "United States"),
                Tuple.Create("VN", _sharedLocalizer["Vietnam"].Value), // Use localizer for region name if needed
                Tuple.Create("UK", "United Kingdom"),
                Tuple.Create("SG", "Singapore"),
                Tuple.Create("CN", "China"),
                Tuple.Create("RU", "Russia"),
                Tuple.Create("ID", "Indonesia")
            };

            var client = _httpClientFactory.CreateClient("ApiClient");
            var latitude = HttpContext.Session.GetString("CustomerLatitude");
            var longitude = HttpContext.Session.GetString("CustomerLongitude");

            string requestUrl = $"{_apiBaseUrl}product/by-region/{regionCode}";
            if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            {
                requestUrl += $"?latitude={latitude}&longitude={longitude}";
            }
            _logger.LogInformation($"Requesting products from: {requestUrl}");

            var response = await client.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var products = JsonSerializer.Deserialize<IEnumerable<ProductListDto>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(products);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                ViewBag.ErrorMessage = $"No products found for region '{regionCode}'.";
                return View(new List<ProductListDto>());
            }
            else
            {
                ViewBag.ErrorMessage = $"Error fetching products: {response.ReasonPhrase}";
                _logger.LogError($"Error fetching products: {response.StatusCode} - {response.ReasonPhrase}");
                return View(new List<ProductListDto>());
            }
        }

        [HttpPost]
        public IActionResult SetRegion(string regionCode)
        {
            // In a real application, you might also store this in user preferences or a cookie
            // Lưu regionCode vào session khi người dùng chọn
            HttpContext.Session.SetString("CurrentRegion", regionCode);
            return RedirectToAction("Index", new { regionCode = regionCode });
        }
        [HttpPost]
        public IActionResult SetCustomerLocation(string latitude, string longitude, string currentRegion)
        {
            HttpContext.Session.SetString("CustomerLatitude", latitude);
            HttpContext.Session.SetString("CustomerLongitude", longitude);
            TempData["LocationSet"] = "Your location has been set for better stock estimates.";
            return Ok(); // Không cần redirect, client-side JS có thể xử lý tiếp
        }
        // NEW: Action to set language
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            // Kiểm tra giá trị của 'culture' nhận được
            _logger.LogInformation($"SetLanguage: Received culture: {culture}, returnUrl: {returnUrl}");

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    HttpOnly = true, // Tăng cường bảo mật, không cho JavaScript truy cập
                    IsEssential = true, // Đảm bảo cookie được lưu trữ ngay cả khi có GDPR consent
                    SameSite = SameSiteMode.Strict // Quan trọng cho bảo mật
                }
            );

            // Sau khi đặt cookie, điều hướng lại trang hiện tại.
            // Điều này sẽ kích hoạt lại middleware localization để đọc cookie mới.
            return LocalRedirect(returnUrl ?? "~/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
