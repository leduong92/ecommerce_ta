using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using Azure.Core;
using eCommerce.Domain.Entities;
using eCommerce.Shared.Common;
using eCommerce.Web.Services.IService;

namespace eCommerce.Web.Controllers
{
    public class CheckoutController : BaseController
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CheckoutController> _logger;
        private readonly ICartApiClient _cartService;
        private readonly IOrderApiClient _orderApiClient;
        private readonly IShippingApiClient _shippingApiClient;
        private readonly string _apiBaseUrl;

        public CheckoutController(
            IHttpClientFactory httpClientFactory
            , IConfiguration configuration
            , ILogger<CheckoutController> logger
            , ICartApiClient cartApiClient
            , IOrderApiClient orderApiClient
            , IShippingApiClient shippingApiClient )
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _cartService = cartApiClient;
            _orderApiClient = orderApiClient;
            _shippingApiClient = shippingApiClient;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var anonymousIdString = HttpContext.Request.Cookies[SD.AnonymousId];
            var cartItems = new List<CartItemDto>();

            try
            {
                cartItems = (await _cartService.GetCartItemsAsync(anonymousIdString)).Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve cart items for display.");
            }

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
                AnonymousId = anonymousIdString,
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
            var anonymousIdString = HttpContext.Request.Cookies[SD.AnonymousId];
            model.AnonymousId = anonymousIdString;

            var cartItems = new List<CartItemDto>();
            try
            {
                cartItems = (await _cartService.GetCartItemsAsync(anonymousIdString)).Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve cart items for display.");
            }
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

            var response = await _shippingApiClient.CalculateShipping(model);

            if (response.IsSuccess)
            {
                ViewBag.CartItems = cartItems;
                ViewBag.Subtotal = cartItems?.Sum(item => item.TotalPrice) ?? 0;

                ViewBag.ShippingOptions = response.Data;
            }
            else
            {
                var errorContent = response.Message;
                _logger.LogError($"Error calculating shipping: {response.StatusCode} - {errorContent}");
                ModelState.AddModelError("", $"Error calculating shipping: {errorContent}");
                TempData["ErrorMessage"] = $"Failed to calculate shipping: {response.Message}. Details: {errorContent}";
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
            var anonymousIdString = HttpContext.Request.Cookies[SD.AnonymousId];
            model.AnonymousId = anonymousIdString;

            var client = _httpClientFactory.CreateClient("ApiClient");

            // Re-fetch cart items to ensure OrderItemDetails is correctly populated
            var cartResponse = await client.GetAsync($"{_apiBaseUrl}Cart/{model.AnonymousId}");
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
                await client.DeleteAsync($"{_apiBaseUrl}Cart/{model.AnonymousId}");

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
