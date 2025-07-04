using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _cartService;

        public ShoppingCartController(IShoppingCartService cartService)
        {
            _cartService = cartService;
        }

        // Helper to get session ID (or user ID if authenticated)
        private string GetSessionId() => HttpContext.Session.Id; // Requires session middleware
        // private int? GetUserId() => User.Identity?.IsAuthenticated == true ? int.Parse(User.FindFirst("UserId")?.Value ?? "0") : null;

        [HttpGet("{sessionId?}")] // Optional sessionId for anonymous carts
        public async Task<IActionResult> GetCart(string? sessionId)
        {
            sessionId ??= GetSessionId();
            var cart = await _cartService.GetOrCreateCartAsync(sessionId);
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
            request.SessionId ??= GetSessionId();

            if (string.IsNullOrEmpty(request.CustomerRegionCode))
            {
                return BadRequest("CustomerRegionCode is required to determine product price.");
            }

            try
            {
                var cart = await _cartService.AddToCartAsync(request.SessionId, request.ProductId, request.Quantity, request.CustomerRegionCode);
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
            request.SessionId ??= GetSessionId();
            try
            {
                var cart = await _cartService.UpdateCartItemQuantityAsync(request.SessionId, request.ProductId, request.Quantity);
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
            request.SessionId ??= GetSessionId();
            var cart = await _cartService.RemoveFromCartAsync(request.SessionId, request.ProductId);
            return Ok(new { Message = "Product removed from cart.", CartId = cart.Id });
        }
        [HttpDelete("clear/{sessionId?}")]
        public async Task<IActionResult> ClearCart(string? sessionId)
        {
            sessionId ??= GetSessionId();
            await _cartService.ClearCartAsync(sessionId);
            return Ok(new { Message = "Cart cleared." });
        }
    }
}
