using eCommerce.Application.Interfaces;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Application.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly AppDbContext _context;

        public ShoppingCartService(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Gets an existing shopping cart or creates a new one for a given session/user.
        /// </summary>
        public async Task<Cart> GetOrCreateCartAsync(string sessionId, Guid? userId = null)
        {
            Cart? cart;
            if (userId.HasValue)
            {
                cart = await _context.Carts.Include(sc => sc.CartItems).ThenInclude(ci => ci.Product)
                                .FirstOrDefaultAsync(sc => sc.UserId == userId.Value);
            }
            else
            {
                cart = await _context.Carts.Include(sc => sc.CartItems).ThenInclude(ci => ci.Product)
                                .FirstOrDefaultAsync(sc => sc.SessionId == sessionId);
            }

            if (cart == null)
            {
                cart = new Cart()
                {
                    SessionId = userId.HasValue ? null : sessionId, // Only set SessionId if no UserId
                    UserId = userId,
                    CreatedDate = DateTime.UtcNow,
                    LastUpdatedDate = DateTime.UtcNow
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }
            return cart;
        }
        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        public async Task<Cart> AddToCartAsync(string sessionId, int productId, int quantity, string customerRegionCode, Guid? userId = null)
        {
            var cart = await GetOrCreateCartAsync(sessionId, userId);
            var product = await _context.Products
                .Include(p => p.ProductPrices)!
                    .ThenInclude(pp => pp.Region)
                .Include(p => p.ProductCategory) // Still need this for dimensional factor fallback
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                throw new ArgumentException("Product not found.");
            }
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must grater than zero.");
            }

            // NEW: Determine the correct price based on customerRegionCode
            // Prioritize exact match, then a default price if available (e.g., USD for international)
            var productPrice = product.ProductPrices?
                .FirstOrDefault(pp => pp.Region.Code.Equals(customerRegionCode, StringComparison.OrdinalIgnoreCase) &&
                                      pp.EffectiveDate <= DateTime.UtcNow && (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow));

            if (productPrice == null)
            {
                // Fallback: Try to find a default price (e.g., US/USD or a globally defined default)
                // You might want a more sophisticated fallback logic here (e.g., nearest region, global default)
                productPrice = product.ProductPrices?
                    .FirstOrDefault(pp => pp.Region.Code == "US" && pp.EffectiveDate <= DateTime.UtcNow && (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow));

                if (productPrice == null)
                {
                    throw new InvalidOperationException($"No valid price found for product {productId} in region {customerRegionCode} or a fallback region.");
                }
                Console.WriteLine($"Warning: Using fallback price for product {productId} from region {productPrice.Region.Code}.");
            }

            var unitPrice = productPrice.Price;

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice // Use the region-specific price
                };
                cart.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
            }
            cart.LastUpdatedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return cart;
        }
        /// <summary>
        /// Updates the quantity of a product in the shopping cart.
        /// </summary>
        public async Task<Cart> UpdateCartItemQuantityAsync(string sessionId, int productId, int quantity, Guid? userId = null)
        {
            var cart = await GetOrCreateCartAsync(sessionId, userId);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem == null)
            {
                throw new ArgumentException("Product not found in cart.");
            }

            if (quantity <= 0)
            {
                cart.CartItems.Remove(cartItem); // Remove if quantity is 0 or less
            }
            else
            {
                cartItem.Quantity = quantity;
            }
            cart.LastUpdatedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return cart;
        }
        /// <summary>
        /// Removes a product from the shopping cart.
        /// </summary>
        public async Task<Cart> RemoveFromCartAsync(string sessionId, int productId, Guid? userId = null)
        {
            var cart = await GetOrCreateCartAsync(sessionId, userId);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cart.CartItems.Remove(cartItem);
                cart.LastUpdatedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            return cart;
        }
        /// <summary>
        /// Clears all items from the shopping cart.
        /// </summary>
        public async Task ClearCartAsync(string sessionId, Guid? userId = null)
        {
            var cart = await GetOrCreateCartAsync(sessionId, userId);
            _context.CartItems.RemoveRange(cart.CartItems);
            cart.LastUpdatedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Gets the current items in a shopping cart.
        /// </summary>
        public async Task<List<CartItem>> GetCartItemsAsync(string sessionId, Guid? userId = null)
        {
            var cart = await GetOrCreateCartAsync(sessionId, userId);
            return cart.CartItems.ToList();
        }
    }
}
