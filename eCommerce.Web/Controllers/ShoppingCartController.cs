using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Claims;
using eCommerce.Web.Services.IService;
using System.Net;
using Microsoft.Extensions.Localization;

namespace eCommerce.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ShoppingCartController> _logger;
        private readonly IShoppingCartApiClient _cartService;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _sharedLocalizer;
        public ShoppingCartController(
            IHttpClientFactory httpClientFactory
            , IConfiguration configuration
            , ILogger<ShoppingCartController> logger
            , StringLocalizer<SharedResources> sharedLocalizer
            , IShoppingCartApiClient cartService)
        {
            _sharedLocalizer = sharedLocalizer;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _cartService = cartService;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }
        // Helper to get User ID for the authenticated user, or null if anonymous
        private Guid? GetAuthenticatedUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdClaim, out Guid authenticatedUserId))
            {
                return authenticatedUserId;
            }
            return null;
        }
        // Helper to get the anonymous cart ID from the cookie
        private Guid? GetAnonymousCartIdFromCookie()
        {
            var anonymousCartCookieName = "AnonymousCartId";
            var anonymousIdString = HttpContext.Request.Cookies[anonymousCartCookieName];
            if (Guid.TryParse(anonymousIdString, out Guid anonymousId))
            {
                return anonymousId;
            }
            return null;
        }
        public async Task<IActionResult> Index()
        {

            ViewBag.CurrentRegion = HttpContext.Session.GetString("CurrentRegion") ?? "US";
            List<CartItemDto> cartItems = new List<CartItemDto>();
            try
            {
                cartItems = (await _cartService.GetCartItemsAsync()).Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve cart items for display.");
            }

            return View(cartItems);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1) // productId is now Guid
        {
            try
            {
                var currentItemCount = await _cartService.AddItemToCartAsync( new AddToCartRequestDto{ ProductId = productId,Quantity = quantity });
                TempData["SuccessMessage"] = _sharedLocalizer["ProductAddedToCart"].Value;
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = true, message = _sharedLocalizer["ProductAddedToCart"].Value, cartItemCount = currentItemCount });
                }
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
            {
                TempData["ErrorMessage"] = _sharedLocalizer["ProductNotFound"].Value;
                _logger.LogWarning($"Attempted to add non-existent product ID: {productId}");
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = false, message = _sharedLocalizer["ProductNotFound"].Value });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding product to cart for product ID: {ProductId}", productId);
                TempData["ErrorMessage"] = _sharedLocalizer["ErrorAddingProductToCart"].Value;
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new { success = false, message = _sharedLocalizer["ErrorAddingProductToCart"].Value });
                }
            }
            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int quantity)
        {
            try
            {
                await _cartService.UpdateItemQuantityAsync(new UpdateQuantityRequestDto { ProductId = productId, Quantity = quantity });
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(_sharedLocalizer["ProductNotFoundInCart"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating cart quantity for product ID: {ProductId}", productId);
                return BadRequest(_sharedLocalizer["ErrorUpdatingCart"].Value);
            }

            var cartItems = await _cartService.GetCartItemsAsync();
            return PartialView("_CartItemsPartial", cartItems);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            try
            {
                await _cartService.RemoveItemFromCartAsync(productId);
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(_sharedLocalizer["ProductNotFoundInCart"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removing item from cart for product ID: {ProductId}", productId);
                return BadRequest(_sharedLocalizer["ErrorRemovingItem"].Value);
            }

            var cartItems = await _cartService.GetCartItemsAsync();
            return PartialView("_CartItemsPartial", cartItems);
        }
        // Action to get cart item count (typically called via AJAX for header display)
        [HttpGet]
        public async Task<IActionResult> GetCartItemCount()
        {
            try
            {
                var cartItems = await _cartService.GetCartItemsAsync();
                var count = cartItems.Data.Sum(ci => ci.Quantity);
                return Ok(count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting cart item count.");
                return Ok(0); // Return 0 on error to avoid breaking UI
            }
        }
    }
}
