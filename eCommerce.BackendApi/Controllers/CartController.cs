using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;

namespace eCommerce.BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        private readonly IShoppingCartService _cartService;
        private readonly ILogger<CartController> _logger;

        public CartController(IShoppingCartService cartService
            , ILogger<CartController> logger)
        {
            _cartService = cartService;
            _logger = logger;
        }

        // Helper to get User ID (Anonymous or Authenticated) as Guid
        private Guid GetCurrentUserId()
        {
            // Prefer User ID from authentication if user is logged in
            if (User.Identity?.IsAuthenticated == true)
            {
                // In API, ClaimTypes.NameIdentifier is the standard way to get User ID from token/cookie auth
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (Guid.TryParse(userIdClaim, out Guid authenticatedUserId))
                {
                    return authenticatedUserId;
                }
            }
            // Fallback to a default GUID for authenticated but unparseable ID - should not happen with proper Identity setup
            return Guid.Empty;
        }
        private string GetAnonymoustUserId()
        {
            // For anonymous users, create or retrieve a GUID from a cookie.
            var anonymousCartCookieName = SD.AnonymousId;
            var anonymousIdString = HttpContext.Request.Cookies[anonymousCartCookieName];
            string anonymousId;

            if (string.IsNullOrEmpty(anonymousIdString))
            {
                anonymousId = Guid.NewGuid().ToString();
                // Store cookie in Response to persist for subsequent requests
                HttpContext.Response.Cookies.Append(anonymousCartCookieName, anonymousId.ToString(), new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(30), // Cookie lives for 30 days
                    HttpOnly = true, // Not accessible by JavaScript for security
                    IsEssential = true, // Important for core functionality
                    SameSite = SameSiteMode.Lax // Or Strict depending on security requirements
                });
                return anonymousId;
            }
            else
            {
                return anonymousIdString;
            }
        }

        [HttpGet] 
        public async Task<IActionResult> GetCart([FromQuery] string? anonymousId)
        {
            var userId = GetCurrentUserId();
            var cart = await _cartService.GetCartItemsAsync(userId, anonymousId);
            return Ok(cart);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (string.IsNullOrEmpty(request.CustomerRegionCode))
            {
                return BadRequest("CustomerRegionCode is required to determine product price.");
            }

            var userId = GetCurrentUserId();
            var anonymousId = GetAnonymoustUserId();

            try
            {
                var cart = await _cartService.AddToCartAsync(request.ProductId, request.Quantity, request.CustomerRegionCode, userId, request.AnonymousId);
                return Ok(new { Message = "Product added to cart.", CartId = cart.Id });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateCart([FromBody] UpdateCartRequest request)
        {
            var userId = GetCurrentUserId();
            var anonymousId = GetAnonymoustUserId();
            try
            {
                var cart = await _cartService.UpdateCartItemQuantityAsync(request.ProductId, request.Quantity, userId, request.AnonymousId);
                return Ok(new { Message = "Cart updated.", CartId = cart.Id });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveFromCart([FromBody] RemoveFromCartRequest request)
        {
            var userId = GetCurrentUserId();
            var anonymousId = GetAnonymoustUserId();
            var cart = await _cartService.RemoveFromCartAsync(request.ProductId, userId, request.AnonymousId);
            return Ok(new { Message = "Product removed from cart.", CartId = cart.Id });
        }
        [HttpDelete("clear")]
        public async Task<IActionResult> ClearCart()
        {
            var userId = GetCurrentUserId();
            var anonymousId = GetAnonymoustUserId();
            await _cartService.ClearCartAsync(userId, anonymousId);
            return Ok(new { Message = "Cart cleared." });
        }
        [HttpPost("merge")]
        [Authorize] // Only allow authenticated users to call this
        public async Task<IActionResult> MergeCarts([FromBody] MergeCartRequestDto request)
        {
            if (User.Identity?.IsAuthenticated != true)
            {
                return Unauthorized("User must be authenticated to merge carts.");
            }

            var authenticatedUserIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(authenticatedUserIdString, out Guid authenticatedUserId))
            {
                return Unauthorized("Authenticated user ID is not a valid GUID.");
            }

            if (string.IsNullOrEmpty(request.AnonymousId)) // Ensure anonymousUserId is also Guid
            {
                return BadRequest("Anonymous user ID is required and must be a valid GUID for merging.");
            }

            if (request.AnonymousId == authenticatedUserId.ToString())
            {
                return BadRequest("Cannot merge a cart with itself.");
            }

            try
            {
                await _cartService.MergeCartsAsync(authenticatedUserId, request.AnonymousId);
                return Ok(new { success = true, message = "Carts merged successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error merging carts for anonymous user {AnonymousId} and authenticated user {AuthenticatedId}.", request.AnonymousId, authenticatedUserId);
                return StatusCode(500, "An error occurred while merging carts.");
            }
        }
    }
}
