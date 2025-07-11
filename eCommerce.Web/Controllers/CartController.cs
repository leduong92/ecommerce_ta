using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Claims;
using eCommerce.Web.Services.IService;
using System.Net;
using Microsoft.Extensions.Localization;
using eCommerce.Shared.Common;

namespace eCommerce.Web.Controllers
{
    public class CartController : BaseController
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CartController> _logger;
        private readonly IShoppingCartApiClient _cartService;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _localizer;
        public CartController(
            IHttpClientFactory httpClientFactory
            , IConfiguration configuration
            , ILogger<CartController> logger
            , IStringLocalizer<SharedResources> localizer
            , IShoppingCartApiClient cartService)
        {
            _localizer = localizer;
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
        private string? GetAnonymousCartIdFromCookie()
        {
            var anonymousIdString = HttpContext.Request.Cookies[SD.AnonymousId];
            if (!string.IsNullOrEmpty(anonymousIdString))
            {
                return anonymousIdString;
            }
            return null;
        }
        public async Task<IActionResult> Index()
        {

            ViewBag.CurrentRegion = HttpContext.Session.GetString("CurrentRegion") ?? "US";
            List<CartItemDto> cartItems = new List<CartItemDto>();
            var anynomousId = GetAnonymousCartIdFromCookie();
            try
            {
                cartItems = (await _cartService.GetCartItemsAsync(anynomousId)).Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve cart items for display.");
            }

            return View(cartItems);
        }
        //[HttpPost]
        //public async Task<IActionResult> AddToCart(int productId, int quantity = 1) // productId is now Guid
        //{
        //    try
        //    {
        //        var currentItemCount = await _cartService.AddItemToCartAsync( new AddToCartRequestDto{ ProductId = productId,Quantity = quantity });
        //        TempData["SuccessMessage"] = _localizer["ProductAddedToCart"].Value;
        //        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //        {
        //            return Json(new { success = true, message = _localizer["ProductAddedToCart"].Value, cartItemCount = currentItemCount });
        //        }
        //    }
        //    catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
        //    {
        //        TempData["ErrorMessage"] = _localizer["ProductNotFound"].Value;
        //        _logger.LogWarning($"Attempted to add non-existent product ID: {productId}");
        //        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //        {
        //            return Json(new { success = false, message = _localizer["ProductNotFound"].Value });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error adding product to cart for product ID: {ProductId}", productId);
        //        TempData["ErrorMessage"] = _localizer["ErrorAddingProductToCart"].Value;
        //        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //        {
        //            return Json(new { success = false, message = _localizer["ErrorAddingProductToCart"].Value });
        //        }
        //    }
        //    return RedirectToAction("Index", "Cart");
        //}

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int variantId, int quantity)
        {
            try
            {
                await _cartService.UpdateItemQuantityAsync(new UpdateQuantityRequestDto { ProductId = productId, VariantId = variantId, Quantity = quantity });
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(_localizer["ProductNotFoundInCart"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating cart quantity for product ID: {ProductId}", productId);
                return BadRequest(_localizer["ErrorUpdatingCart"].Value);
            }
            var anynomousId = GetAnonymousCartIdFromCookie();
            var cartItems = await _cartService.GetCartItemsAsync(anynomousId);
            return PartialView("_CartItemsPartial", cartItems.Data ?? new List<CartItemDto>());
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            var anynomousId = GetAnonymousCartIdFromCookie();
            try
            {
                await _cartService.RemoveItemFromCartAsync(new RemoveFromCartRequest { ProductId = productId, AnonymousId = anynomousId });
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(_localizer["ProductNotFoundInCart"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error removing item from cart for product ID: {ProductId}", productId);
                return BadRequest(_localizer["ErrorRemovingItem"].Value);
            }
            var cartItems = await _cartService.GetCartItemsAsync(anynomousId);
            return PartialView("_CartItemsPartial", cartItems.Data ?? new List<CartItemDto>());
        }
        // Action to get cart item count (typically called via AJAX for header display)
        [HttpGet]
        public async Task<IActionResult> GetCartItemCount()
        {
            try
            {
                var anynomousId = GetAnonymousCartIdFromCookie();
                var cartItems = await _cartService.GetCartItemsAsync(anynomousId);
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
