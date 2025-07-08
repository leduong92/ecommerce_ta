using eCommerce.Application.Interfaces;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eCommerce.Application.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ShoppingCartService> _logger;
        public ShoppingCartService(AppDbContext context
            , ILogger<ShoppingCartService> logger)
        {
            _context = context;
            _logger = logger;
        }
        /// <summary>
        /// Gets an existing shopping cart or creates a new one for a given session/user.
        /// </summary>
        public async Task<Cart> GetOrCreateCartAsync(Guid userId)
        {

            var cart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product) // Eagerly load product details
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new Cart()
                {
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
        public async Task<Cart> AddToCartAsync(string sessionId, int productId, int quantity, string customerRegionCode, Guid userId)
        {
            var cart = await GetOrCreateCartAsync(userId);
            var product = await _context.Products
                .Include(p => p.Prices)!
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
            var productPrice = product.Prices?
                .FirstOrDefault(pp => pp.Region.Code.Equals(customerRegionCode, StringComparison.OrdinalIgnoreCase) &&
                                      pp.EffectiveDate <= DateTime.UtcNow && (pp.ExpirationDate == null || pp.ExpirationDate >= DateTime.UtcNow));

            if (productPrice == null)
            {
                // Fallback: Try to find a default price (e.g., US/USD or a globally defined default)
                // You might want a more sophisticated fallback logic here (e.g., nearest region, global default)
                productPrice = product.Prices?
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
                var newItem = new CartItem()
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = unitPrice // Use the region-specific price
                };
                cart.CartItems.Add(newItem);
            }
            else
            {
                cartItem.Quantity += quantity;
                _context.CartItems.Update(cartItem);
            }
            cart.LastUpdatedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Added/updated product {productId} for user {userId}. Quantity: {quantity}");
            return cart;
        }
        /// <summary>
        /// Updates the quantity of a product in the shopping cart.
        /// </summary>
        public async Task<Cart> UpdateCartItemQuantityAsync(string sessionId, int productId, int quantity, Guid userId)
        {
            var cart = await GetOrCreateCartAsync(userId);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem == null)
            {
                //throw new ArgumentException("Product not found in cart.");
                return null;
            }

            if (quantity <= 0)
            {
                cart.CartItems.Remove(cartItem); // Remove if quantity is 0 or less
                _context.CartItems.Remove(cartItem);
            }
            else
            {
                cartItem.Quantity = quantity;
                _context.CartItems.Update(cartItem);
            }
            cart.LastUpdatedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return cart;
        }
        /// <summary>
        /// Removes a product from the shopping cart.
        /// </summary>
        public async Task<Cart> RemoveFromCartAsync(string sessionId, int productId, Guid userId)
        {
            var cart = await GetOrCreateCartAsync(userId);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cart.CartItems.Remove(cartItem);
                _context.CartItems.Remove(cartItem);
                cart.LastUpdatedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            return cart;
        }
        /// <summary>
        /// Clears all items from the shopping cart.
        /// </summary>
        public async Task ClearCartAsync(string sessionId, Guid userId)
        {
            var cart = await GetOrCreateCartAsync(userId);
            if (cart != null)
            {
                _context.CartItems.RemoveRange(cart.CartItems);
                cart.LastUpdatedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            else
            {
                _logger.LogWarning($"Attempted to clear non-existent cart for user {userId}.");
            }
        }
        /// <summary>
        /// Gets the current items in a shopping cart.
        /// </summary>
        public async Task<List<CartItem>> GetCartItemsAsync(string sessionId, Guid userId)
        {
            var cart = await GetOrCreateCartAsync(userId);
            return cart.CartItems.ToList();
        }
        public async Task<int> GetCartItemCountAsync(Guid? userId)
        {
            var cart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == userId);
            return cart?.CartItems.Sum(item => item.Quantity) ?? 0;
        }
        // NEW: Phương thức hợp nhất giỏ hàng
        public async Task MergeCartsAsync(Guid? anonymousUserId, Guid? authenticatedUserId)
        {

            var anonymousCart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == anonymousUserId);
            var authenticatedCart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == authenticatedUserId);

            if (anonymousCart == null && authenticatedCart == null)
            {
                _logger.LogInformation("No carts to merge.");
                return;
            }

            // Nếu người dùng đã đăng nhập chưa có giỏ hàng, chỉ cần chuyển giỏ hàng ẩn danh cho họ
            if (authenticatedCart == null && anonymousCart != null)
            {
                anonymousCart.UserId = authenticatedUserId;
                anonymousCart.LastUpdatedDate = DateTime.UtcNow;
                _context.Carts.Update(anonymousCart);
                _logger.LogInformation($"Moved anonymous cart {anonymousCart.Id} to authenticated user {authenticatedUserId}.");
            }
            // Nếu người dùng đã đăng nhập đã có giỏ hàng, và người dùng ẩn danh cũng có giỏ hàng, thì hợp nhất
            else if (authenticatedCart != null && anonymousCart != null)
            {
                foreach (var anonymousItem in anonymousCart.CartItems.ToList()) // ToList() to avoid modification issues during iteration
                {
                    var existingAuthItem = authenticatedCart.CartItems.FirstOrDefault(ai => ai.ProductId == anonymousItem.ProductId);

                    if (existingAuthItem != null)
                    {
                        // Hợp nhất số lượng
                        existingAuthItem.Quantity += anonymousItem.Quantity;
                        _context.CartItems.Update(existingAuthItem);
                    }
                    else
                    {
                        // Thêm mặt hàng mới từ giỏ hàng ẩn danh vào giỏ hàng đã đăng nhập
                        anonymousItem.CartId = authenticatedCart.Id; // Thay đổi CartId của item
                        authenticatedCart.CartItems.Add(anonymousItem);
                        _context.CartItems.Update(anonymousItem); // Cập nhật để EF biết nó đã thay đổi CartId
                    }
                }

                // Xóa giỏ hàng ẩn danh sau khi hợp nhất
                _context.Carts.Remove(anonymousCart);
                _logger.LogInformation($"Merged anonymous cart {anonymousCart.Id} into authenticated cart {authenticatedCart.Id}.");
            }

            _context.Carts.Update(authenticatedCart);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Cart merge completed for user {authenticatedUserId}.");
        }
    }
}
