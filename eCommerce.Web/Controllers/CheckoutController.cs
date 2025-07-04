using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using Azure.Core;
using eCommerce.Domain.Entities;

namespace eCommerce.Web.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CheckoutController> _logger;
        private readonly string _apiBaseUrl;

        public CheckoutController(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<CheckoutController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient("ApiClient");
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                TempData["ErrorMessage"] = "Your cart is empty or session expired. Please add items to cart.";
                return RedirectToAction("Index", "Cart");
            }

            // Fetch cart items to display in checkout summary
            var cartResponse = await client.GetAsync($"{_apiBaseUrl}ShoppingCart/{sessionId}");
            if (!cartResponse.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Could not load cart for checkout.";
                return RedirectToAction("Index", "Cart");
            }
            var cartContent = await cartResponse.Content.ReadAsStringAsync();
            var cartItems = JsonSerializer.Deserialize<IEnumerable<CartItemDto>>(cartContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (cartItems == null || !cartItems.Any())
            {
                TempData["ErrorMessage"] = "Your cart is empty. Cannot proceed to checkout.";
                return RedirectToAction("Index", "Home");
            }

            ViewBag.CartItems = cartItems;
            ViewBag.Subtotal = cartItems.Sum(item => item.TotalPrice);

            // You might want to pre-fill address if user is logged in or from previous session
            var model = new CheckoutRequest
            {
                SessionId = sessionId,
                // Prefill some dummy data for testing
                ShippingFirstName = "John",
                ShippingLastName = "Doe",
                ShippingAddress1 = "123 Main St",
                ShippingCity = "Los Angeles",
                ShippingStateProvince = "CA",
                ShippingZipCode = "90001",
                ShippingCountryCode = "US",
                ShippingPhoneNumber = "555-123-4567",
                ShippingLatitude = 34.0522, // Example US coords
                ShippingLongitude = -118.2437,
                ShippingIsRuralArea = false
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CalculateShipping(CheckoutRequest model)
        {
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                TempData["ErrorMessage"] = "Session expired. Please add items to cart again.";
                return RedirectToAction("Index", "Cart");
            }
            model.SessionId = sessionId;

            var client = _httpClientFactory.CreateClient("ApiClient");

            // Shipping calculation might require current cart items for weight/dimensions
            // Retrieve cart items to pass to shipping calculation
            var cartResponse = await client.GetAsync($"{_apiBaseUrl}ShoppingCart/{model.SessionId}");
            if (!cartResponse.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Could not load cart for shipping calculation.";
                return RedirectToAction("Index", "Cart");
            }
            var cartContent = await cartResponse.Content.ReadAsStringAsync();
            var cartItems = JsonSerializer.Deserialize<IEnumerable<CartItemDto>>(cartContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (cartItems == null || !cartItems.Any())
            {
                TempData["ErrorMessage"] = "Your cart is empty. Cannot calculate shipping.";
                return RedirectToAction("Index", "Cart");
            }

            // In a real app, you would populate ShippingOrderItemDetails based on CartItems
            model.OrderItemDetails = cartItems.Select(ci => new OrderItemDetailsDto // Assuming this DTO is in ECommerce.Api.Controllers
            {
                ProductId = ci.ProductId,
                Quantity = ci.Quantity
            }).ToList();

            var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_apiBaseUrl}Order/calculate-shipping", jsonContent);

            ViewBag.CartItems = cartItems;
            ViewBag.Subtotal = cartItems?.Sum(item => item.TotalPrice) ?? 0;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var shippingOptions = JsonSerializer.Deserialize<List<ShippingOptionDto>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                ViewBag.ShippingOptions = shippingOptions;
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error calculating shipping: {response.StatusCode} - {errorContent}");
                ModelState.AddModelError("", $"Error calculating shipping: {errorContent}");
                TempData["ErrorMessage"] = $"Failed to calculate shipping: {response.ReasonPhrase}. Details: {errorContent}";
                ViewBag.ShippingOptions = new List<ShippingOptionDto>(); // Clear options on error
            }
            return View("Index", model); // Return to the same checkout page with shipping options
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(CheckoutRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                TempData["ErrorMessage"] = "Session expired. Please add items to cart again.";
                return RedirectToAction("Index", "Cart");
            }
            model.SessionId = sessionId;

            var client = _httpClientFactory.CreateClient("ApiClient");

            // Re-fetch cart items to ensure OrderItemDetails is correctly populated
            var cartResponse = await client.GetAsync($"{_apiBaseUrl}ShoppingCart/{model.SessionId}");
            if (!cartResponse.IsSuccessStatusCode)
            {
                TempData["ErrorMessage"] = "Could not load cart for order placement.";
                return RedirectToAction("Index", "Cart");
            }
            var cartContent = await cartResponse.Content.ReadAsStringAsync();
            var cartItems = JsonSerializer.Deserialize<IEnumerable<CartItemDto>>(cartContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            ViewBag.CartItems = cartItems; // Keep for re-rendering if error
            ViewBag.Subtotal = cartItems?.Sum(item => item.TotalPrice) ?? 0;

            model.OrderItemDetails = cartItems.Select(ci => new OrderItemDetailsDto { ProductId = ci.ProductId, Quantity = ci.Quantity }).ToList();

            var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{_apiBaseUrl}Order/checkout", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var orderContent = await response.Content.ReadAsStringAsync();
                var order = JsonSerializer.Deserialize<OrderDto>(orderContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                ViewBag.OrderId = order?.Id;
                TempData["SuccessMessage"] = "Order placed successfully!";

                // Clear cart after successful order
                await client.DeleteAsync($"{_apiBaseUrl}Cart/{sessionId}");

                return RedirectToAction("Confirmation", new { orderId = order?.Id });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error placing order: {response.StatusCode} - {errorContent}");
                ModelState.AddModelError("", $"Failed to place order: {errorContent}");
                // You might want to re-calculate shipping options here as well if the page is reloaded due to error
                TempData["ErrorMessage"] = $"Failed to place order: {response.ReasonPhrase}. Details: {errorContent}";

                // Re-render checkout page with error
                ViewBag.CartItems = cartItems;
                ViewBag.Subtotal = cartItems.Sum(item => item.TotalPrice);

                return View("Index", model);
            }
        }

        [HttpGet]
        public IActionResult Confirmation(int orderId)
        {
            ViewBag.OrderId = orderId;
            return View();
        }
    }
}
