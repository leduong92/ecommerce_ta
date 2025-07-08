using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace eCommerce.BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _cartService;
        private readonly ILogger<ShoppingCartController> _logger;

        public ShoppingCartController(IShoppingCartService cartService
            , ILogger<ShoppingCartController> logger)
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
                _logger.LogWarning($"Authenticated user ID claim '{userIdClaim}' is not a valid GUID.");
                // Fallback to a default GUID for authenticated but unparseable ID - should not happen with proper Identity setup
                return Guid.Empty;
            }
            else
            {
                // For anonymous users, create or retrieve a GUID from a cookie.
                var anonymousCartCookieName = "AnonymousCartId";
                var anonymousIdString = HttpContext.Request.Cookies[anonymousCartCookieName];
                Guid anonymousId;

                if (string.IsNullOrEmpty(anonymousIdString) || !Guid.TryParse(anonymousIdString, out anonymousId))
                {
                    anonymousId = Guid.NewGuid();
                    // Store cookie in Response to persist for subsequent requests
                    HttpContext.Response.Cookies.Append(anonymousCartCookieName, anonymousId.ToString(), new CookieOptions
                    {
                        Expires = DateTimeOffset.UtcNow.AddDays(30), // Cookie lives for 30 days
                        HttpOnly = true, // Not accessible by JavaScript for security
                        IsEssential = true, // Important for core functionality
                        SameSite = SameSiteMode.Lax // Or Strict depending on security requirements
                    });
                    _logger.LogInformation($"Created new anonymous cart ID via API: {anonymousId}");
                }
                return anonymousId;
            }
        }

        [HttpGet("{sessionId?}")] // Optional sessionId for anonymous carts
        public async Task<IActionResult> GetCart()
        {
            var userId = GetCurrentUserId();
            var cart = await _cartService.GetOrCreateCartAsync(userId);
            return Ok(cart.CartItems.Select(ci => new CartItemDto // Return DTO to avoid circular references
            {
                ProductId = ci.ProductId,
                ProductName = ci.Product.Name,
                Quantity = ci.Quantity,
                UnitPrice = ci.UnitPrice,
                TotalPrice = ci.TotalPrice
            }).ToList());
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
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

            try
            {
                var cart = await _cartService.AddToCartAsync(request.SessionId, request.ProductId, request.Quantity, request.CustomerRegionCode, userId);
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
            try
            {
                var cart = await _cartService.UpdateCartItemQuantityAsync(request.SessionId, request.ProductId, request.Quantity, userId);
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
            var cart = await _cartService.RemoveFromCartAsync(request.SessionId, request.ProductId, userId);
            return Ok(new { Message = "Product removed from cart.", CartId = cart.Id });
        }
        [HttpDelete("clear/{sessionId?}")]
        public async Task<IActionResult> ClearCart(string? sessionId)
        {
            var userId = GetCurrentUserId();
            await _cartService.ClearCartAsync(sessionId, userId);
            return Ok(new { Message = "Cart cleared." });
        }
    }
}
