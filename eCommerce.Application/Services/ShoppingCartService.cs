using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;
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
        public async Task<Cart> GetOrCreateCartAsync(Guid? userId, string? anonymousId)
        {

            var cart = await _context.Carts
                                    .Include(c => c.CartItems)
                                    .ThenInclude(ci => ci.Product) // Eagerly load product details
                                    .FirstOrDefaultAsync(c => c.UserId == userId || c.AnonymousId == anonymousId);

            if (cart == null)
            {
                cart = new Cart()
                {
                    UserId = userId,
                    AnonymousId = anonymousId,
                    CreatedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            return cart;
        }
        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        public async Task<Cart> AddToCartAsync(int productId, int quantity, string customerRegionCode, Guid userId, string? anonymousId, int variantId)
        {
            var cart = await GetOrCreateCartAsync(userId, anonymousId);

            var product = await _context.Products
                    .Include(p => p.InventoryItems)
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

            var exists = await _context.ProductVariants.AnyAsync(v => v.Id == variantId);
            if (!exists)
                throw new Exception("ProductVariant does not exist: " + variantId);

            var unitPrice = productPrice.Price;

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId && ci.ProductVariantId == variantId);
            if (cartItem == null)
            {
                var newItem = new CartItem()
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = quantity,
                    RegionCode = customerRegionCode,
                    Currency = productPrice.Currency,
                    ProductVariantId = variantId,
                    UnitPrice = unitPrice // Use the region-specific price
                };
                cart.CartItems.Add(newItem);
            }
            else
            {
                cartItem.Quantity += quantity;
                _context.CartItems.Update(cartItem);
            }
            cart.LastModifiedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            _logger.LogInformation($"Added/updated product {productId} for user {userId}. Quantity: {quantity}");
            return cart;
        }
        /// <summary>
        /// Updates the quantity of a product in the shopping cart.
        /// </summary>
        public async Task<Cart> UpdateCartItemQuantityAsync(int productId, int quantity, Guid userId, string? anonymousId)
        {
            var cart = await GetOrCreateCartAsync(userId, anonymousId);
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
            cart.LastModifiedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return cart;
        }
        /// <summary>
        /// Removes a product from the shopping cart.
        /// </summary>
        public async Task<Cart> RemoveFromCartAsync(int productId, Guid userId, string? anonymousId)
        {
       var cart = await GetOrCreateCartAsync(userId, anonymousId);

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem != null)
            {
                cart.CartItems.Remove(cartItem);
                _context.CartItems.Remove(cartItem);
                cart.LastModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
            return cart;
        }
        /// <summary>
        /// Clears all items from the shopping cart.
        /// </summary>
        public async Task ClearCartAsync(Guid userId, string? anonymousId)
        {
       var cart = await GetOrCreateCartAsync(userId, anonymousId);
            if (cart != null)
            {
                _context.CartItems.RemoveRange(cart.CartItems);
                cart.LastModifiedDate = DateTime.UtcNow;
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
        public async Task<ApiResponse<List<CartItemDto>>> GetCartItemsAsync(Guid userId, string? anonymousId)
        {
            var cart = await GetOrCreateCartAsync(userId, anonymousId);

            var items = await _context.CartItems
                        .Include(x => x.ProductVariant)
                            .ThenInclude(v => v.Product)
                        .Include(x => x.ProductVariant.Images)
                        .Include(x => x.ProductVariant.VariantOptionValues)
                            .ThenInclude(vov => vov.ProductOptionValue)
                                .ThenInclude(pov => pov.Option)
                        .Where(x => x.CartId == cart.Id)
                        .ToListAsync();

            var result = items.Select(x => new CartItemDto
            {
                ProductId = x.ProductVariant.ProductId,
                ProductName = x.ProductVariant.Product.Name,
                ProductVariantId = x.ProductVariantId,
                Sku = x.ProductVariant.Sku,
                Quantity = x.Quantity,
                Currency = x.Currency,
                UnitPrice = x.UnitPrice,
                TotalPrice = x.Quantity * x.UnitPrice,
                ImageUrl = x.ProductVariant.Images.FirstOrDefault(i => i.IsPrimary)?.ImageUrl,
                VariantSummary = string.Join(", ", x.ProductVariant.VariantOptionValues
            .Select(vov => $"{vov.ProductOptionValue.Option.Name}: {vov.ProductOptionValue.Value}"))
            }).ToList();

            return ApiResponse<List<CartItemDto>>.Success(result);
        }
        public async Task<int> GetCartItemCountAsync(Guid? userId)
        {
            var cart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == userId);
            return cart?.CartItems.Sum(item => item.Quantity) ?? 0;
        }
        // NEW: Phương thức hợp nhất giỏ hàng
        public async Task MergeCartsAsync(Guid? authenticatedUserId, string? anonymousUserId)
        {

            var anonymousCart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.AnonymousId == anonymousUserId);
            
            if (anonymousCart == null)
                return;

            var authenticatedCart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserId == authenticatedUserId);

            // Nếu người dùng đã đăng nhập chưa có giỏ hàng, chỉ cần chuyển giỏ hàng ẩn danh cho họ
            if (anonymousCart != null)
            {
                anonymousCart.UserId = authenticatedUserId;
                anonymousCart.AnonymousId = null;
                anonymousCart.LastModifiedDate = DateTime.UtcNow;
                _context.Carts.Update(anonymousCart);
            }
            // Nếu người dùng đã đăng nhập đã có giỏ hàng, và người dùng ẩn danh cũng có giỏ hàng, thì hợp nhất
            else
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
                        authenticatedCart.CartItems.Add(anonymousItem);
                        _context.CartItems.Update(anonymousItem); // Cập nhật để EF biết nó đã thay đổi CartId
                    }
                }

                // Xóa giỏ hàng ẩn danh sau khi hợp nhất
                _context.Carts.Remove(anonymousCart);
            }

            await _context.SaveChangesAsync();
        }
    }
}
