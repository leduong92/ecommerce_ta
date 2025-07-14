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
        private readonly ICartApiClient _cartService;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _localizer;
        public CartController(
            IHttpClientFactory httpClientFactory
            , IConfiguration configuration
            , ILogger<CartController> logger
            , IStringLocalizer<SharedResources> localizer
            , ICartApiClient cartService)
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
        public async Task<IActionResult> Index()
        {

            ViewBag.CurrentRegion = HttpContext.Session.GetString("CurrentRegion") ?? "US";
            List<CartItemDto> cartItems = new List<CartItemDto>();
            var anynomousId = HttpContext.Request.Cookies[SD.AnonymousId];
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

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int productId, int variantId, int quantity, int? sizeId, int? fabricId, int? finishId)
        {
            try
            {
                await _cartService.UpdateItemQuantityAsync(new UpdateQuantityRequestDto 
                    { 
                        ProductId = productId, 
                        VariantId = variantId, 
                        Quantity = quantity,
                        SizeId = sizeId,
                        FabricId = fabricId,
                        FinishId = finishId
                    }
                );
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
            var anynomousId = HttpContext.Request.Cookies[SD.AnonymousId];
            var cartItems = await _cartService.GetCartItemsAsync(anynomousId);
            return PartialView("_CartItemsPartial", cartItems.Data ?? new List<CartItemDto>());
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            var anynomousId = HttpContext.Request.Cookies[SD.AnonymousId];
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
                var anynomousId = HttpContext.Request.Cookies[SD.AnonymousId];
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
