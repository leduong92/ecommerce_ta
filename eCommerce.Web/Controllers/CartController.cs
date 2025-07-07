using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace eCommerce.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CartController> _logger;
        private readonly string _apiBaseUrl;

        public CartController(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<CartController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }

        public async Task<IActionResult> Index()
        {
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                // Giỏ hàng trống nếu không có session
                return View(new List<CartItemDto>());
            }

            var client = _httpClientFactory.CreateClient("ApiClient");
            var response = await client.GetAsync($"{_apiBaseUrl}ShoppingCart/{sessionId}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cartItems = JsonSerializer.Deserialize<IEnumerable<CartItemDto>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return View(cartItems);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return View(new List<CartItemDto>()); // Giỏ hàng trống
            }
            else
            {
                _logger.LogError($"Error fetching cart: {response.StatusCode} - {response.ReasonPhrase}");
                ViewBag.ErrorMessage = "Error fetching cart contents.";
                return View(new List<CartItemDto>());
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int quantity)
        {
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                TempData["ErrorMessage"] = "Session not found. Please add items to cart first.";
                return RedirectToAction("Index");
            }

            if (quantity <= 0)
            {
                return RedirectToAction("Remove", new { productId = productId }); // If quantity is 0 or less, remove it
            }

            var client = _httpClientFactory.CreateClient("ApiClient");

            var requestData = new
            {
                sessionId = sessionId,
                productId = productId,
                quantity = quantity
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"{_apiBaseUrl}cart/update-quantity", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Cart item quantity updated.";
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error updating cart quantity: {response.StatusCode} - {errorContent}");
                TempData["ErrorMessage"] = $"Error updating cart quantity: {{(errorContent != null ? errorContent : response.ReasonPhrase)}}";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int productId)
        {
            var client = _httpClientFactory.CreateClient("ApiClient");
            var sessionId = HttpContext.Session.Id;

            if (string.IsNullOrEmpty(sessionId))
            {
                TempData["ErrorMessage"] = "Session not found.";
                return RedirectToAction("Index");
            }

            var requestData = new
            {
                sessionId = sessionId,
                productId = productId
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Delete, $"{_apiBaseUrl}cart/remove")
            {
                Content = jsonContent
            };

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Product removed from cart.";
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error removing from cart: {response.StatusCode} - {errorContent}");
                TempData["ErrorMessage"] = $"Error removing product from cart: {{(errorContent != null ? errorContent : response.ReasonPhrase)}}";
            }
            return RedirectToAction("Index");
        }
    }
}
