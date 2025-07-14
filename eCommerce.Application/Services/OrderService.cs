using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;
        private readonly ICartService _cartService;
        private readonly ShippingCalculatorService _shippingCalculator;

        public OrderService(AppDbContext context
            , ICartService cartService
            , ShippingCalculatorService shippingCalculator)
        {
            _context = context;
            _cartService = cartService;
            _shippingCalculator = shippingCalculator;
        }
        /// <summary>
        /// Processes a checkout request: calculates shipping, allocates inventory, and creates an order.
        /// </summary>
        /// <param name="checkoutRequest">DTO containing all checkout details.</param>
        /// <returns>The created Order object or null if processing fails.</returns>
        public async Task<ApiResponse<Order?>> ProcessCheckoutAsync(CheckoutRequest checkoutRequest)
        {
            // 1. Retrieve cart items
            var cartItems = (await _cartService.GetCartItemsAsync(checkoutRequest.UserId.Value, checkoutRequest.AnonymousId)).Data;
            if (!cartItems.Any())
            {
                return ApiResponse<Order?>.Failure("Error: Cart is empty.");
            }
            // Prepare order details for shipping calculation
            var orderItemDetails = cartItems.Select(ci => new OrderItemDetailsDto
            {
                ProductId = ci.ProductId,
                Quantity = ci.Quantity
            }).ToList();

            decimal subtotal = cartItems.Sum(ci => ci.TotalPrice);

            // 2. Calculate shipping options based on cart contents and destination
            var shippingOptions = (await _shippingCalculator.CalculateShippingRates(
                checkoutRequest.ShippingCountryCode,
                checkoutRequest.ShippingStateProvince,
                checkoutRequest.ShippingZipCode,
                checkoutRequest.ShippingLatitude,
                checkoutRequest.ShippingLongitude,
                orderItemDetails,
                subtotal, // Pass subtotal as total order value for shipping rules
                checkoutRequest.ShippingFloorNumber,
                checkoutRequest.ShippingIsRuralArea
            )).Data;

            if (!shippingOptions.Any())
            {
                return ApiResponse<Order?>.Failure("Error: No shipping options available for this order and destination.");
            }

            // 3. Select the chosen shipping option (e.g., lowest cost, or based on user's selected ServiceLevelName)
            // For simplicity, let's select the lowest cost option here. In a real app, user selects.
            var chosenOption = shippingOptions
                .FirstOrDefault(opt => opt.ServiceLevelName == checkoutRequest.ChosenShippingServiceLevelName) ??
                shippingOptions.OrderBy(opt => opt.TotalCost).First(); // Fallback to cheapest

            if (chosenOption == null)
            {
                return ApiResponse<Order?>.Failure("Error: Chosen shipping service level not found among available options.");
            }

            // 4.Validate and Allocate Inventory


            int maxRetries = 3;
            for (int i = 0; i < maxRetries; i++)
            {
                // This needs to be done within a transaction to ensure atomicity.
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        // Re-fetch the fulfilling warehouse with its inventory items, and lock it if possible (depends on DB/Concurrency setup)
                        // Lấy lại các InventoryItem từ DB trong cùng transaction và với khóa nếu có thể
                        // .Include(w => w.InventoryItems) -> Nạp InventoryItems.
                        // Đối với mức độ cô lập cao (Serializable/Repeatable Read) hoặc sử dụng Row-Level Locking
                        // (ví dụ: `WITH (UPDLOCK)` trong SQL Server nếu dùng Raw SQL hoặc Configure Locking thông qua EF Core)
                        // sẽ giúp ngăn chặn các giao dịch khác sửa đổi InventoryItem cùng lúc.
                        var fulfillingWarehouse = await _context.Warehouses
                                                        .Include(w => w.InventoryItems)
                                                        .ThenInclude(ii => ii.Product)
                                                        .FirstOrDefaultAsync(w => w.Id == chosenOption.OriginWarehouse.Id);

                        if (fulfillingWarehouse == null)
                        {
                            return ApiResponse<Order?>.Failure($"Fulfilling warehouse with ID {chosenOption.OriginWarehouse.Id} not found.");
                        }

                        // Check and reserve inventory
                        // Vòng lặp qua các sản phẩm trong giỏ hàng để kiểm tra và phân bổ tồn kho
                        foreach (var cartItem in cartItems)
                        {
                            var inventoryItem = fulfillingWarehouse.InventoryItems
                                .FirstOrDefault(ii => ii.ProductId == cartItem.ProductId);

                            // Kiểm tra tồn kho có sẵn (on hand - reserved)
                            if (inventoryItem == null || inventoryItem.AvailableQuantity < cartItem.Quantity) // AvailableQuantity = QuantityOnHand - QuantityReserved
                            {
                                return ApiResponse<Order?>.Failure($"Insufficient stock for product {cartItem.ProductName} at {fulfillingWarehouse.Name}. Available: {inventoryItem?.AvailableQuantity ?? 0}, Requested: {cartItem.Quantity}");
                            }
                            // Phân bổ (dự trữ) tồn kho bằng cách tăng QuantityReserved
                            inventoryItem.QuantityReserved += cartItem.Quantity;
                        }
                        // Lưu thay đổi vào database ngay LẬP TỨC TRONG TRANSACTION
                        // Điều này đảm bảo rằng các thay đổi về QuantityReserved được ghi vào DB
                        // trước khi các bước tiếp theo được thực hiện, và bị khóa bởi transaction hiện tại.
                        await _context.SaveChangesAsync(); // Save inventory changes within the transaction

                        // 5. Create the Order
                        var order = new Order
                        {
                            UserId = checkoutRequest.UserId.Value,
                            OrderDate = DateTime.UtcNow,
                            Status = OrderStatus.PendingPayment, // Or Processing, if payment is handled later
                            Subtotal = subtotal,
                            ShippingCost = chosenOption.TotalCost,
                            TotalAmount = subtotal + chosenOption.TotalCost,

                            ShippingFirstName = checkoutRequest.ShippingFirstName,
                            ShippingLastName = checkoutRequest.ShippingLastName,
                            ShippingAddress1 = checkoutRequest.ShippingAddress1,
                            ShippingAddress2 = checkoutRequest.ShippingAddress2,
                            ShippingCity = checkoutRequest.ShippingCity,
                            ShippingStateProvince = checkoutRequest.ShippingStateProvince,
                            ShippingZipCode = checkoutRequest.ShippingZipCode,
                            ShippingCountryCode = checkoutRequest.ShippingCountryCode,
                            ShippingLatitude = checkoutRequest.ShippingLatitude,
                            ShippingLongitude = checkoutRequest.ShippingLongitude,
                            ShippingPhoneNumber = checkoutRequest.ShippingPhoneNumber,
                            ShippingFloorNumber = checkoutRequest.ShippingFloorNumber,
                            ShippingIsRuralArea = checkoutRequest.ShippingIsRuralArea,

                            ChosenShippingServiceLevelName = chosenOption.ServiceLevelName,
                            ChosenShippingDeliveryType = chosenOption.DeliveryType,
                            ChosenShippingEstimatedDaysMin = chosenOption.EstimatedDeliveryDaysMin,
                            ChosenShippingEstimatedDaysMax = chosenOption.EstimatedDeliveryDaysMax,
                            ChosenShippingOriginWarehouseName = chosenOption.OriginWarehouse.Name,
                            ChosenShippingRouteDescription = chosenOption.RouteDescription,
                            FulfillingWarehouseId = chosenOption.OriginWarehouse.Id
                        };

                        foreach (var cartItem in cartItems)
                        {
                            order.OrderItems.Add(new OrderItem
                            {
                                ProductId = cartItem.ProductId,
                                Quantity = cartItem.Quantity,
                                UnitPrice = cartItem.UnitPrice,
                                TotalPrice = cartItem.TotalPrice
                            });
                        }

                        _context.Orders.Add(order);
                        await _context.SaveChangesAsync();

                        // 6. Clear the shopping cart after successful order creation
                        await _cartService.ClearCartAsync(checkoutRequest.UserId.Value, checkoutRequest.AnonymousId); // Pass RequestUserId if applicable

                        await transaction.CommitAsync(); // Commit all changes if everything is successful
                        Console.WriteLine($"Order {order.Id} created successfully. Total: {order.TotalAmount:C}. Shipping from {order.ChosenShippingOriginWarehouseName}.");
                        return ApiResponse<Order>.Success(order);
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine($"Concurrency conflict detected during checkout. Retrying ({i + 1}/{maxRetries})... Error: {ex.Message}");

                        // Reload the entity's current values from the database to get the latest RowVersion
                        // This prepares the context for the next retry attempt with fresh data.

                        foreach (var entry in ex.Entries)
                        {
                            await entry.ReloadAsync();
                        }
                        if (i == maxRetries - 1)// If this was the last retry attempt
                        {
                            // Re-throw or return null to indicate failure after all retries
                            //return null;
                            return ApiResponse<Order?>.Failure($"Maximum retries reached for concurrency conflict.");
                        }
                        // Continue to next iteration for retry
                    }
                    catch (InvalidOperationException ex)
                    {
                        await transaction.RollbackAsync();
                        return ApiResponse<Order?>.Failure($"Inventory issue during checkout: {ex.Message}");
                        //return null;
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync(); // Rollback all changes on error
                        // Log the exception details (ex.ToString()) for debugging
                        return ApiResponse<Order?>.Failure($"Error during checkout process: {ex.Message}");
                        //return null;
                    }
                }
            }
            //return null; // Should only be reached if all retries fail
            return ApiResponse<Order?>.Failure($"Should only be reached if all retries fail");
        }
        /// <summary>
        /// Updates the status of an order.
        /// </summary>
        public async Task<ApiResponse<bool>> UpdateOrderStatusAsync(int orderId, OrderStatus newStatus)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                return ApiResponse<bool>.Failure($"Order with Id=${orderId} not found");
            }

            order.Status = newStatus;
            await _context.SaveChangesAsync();
            return ApiResponse<bool>.Success(true);
        }

        /// <summary>
        /// Gets an order by its ID, including its items and fulfilling warehouse.
        /// </summary>
        public async Task<ApiResponse<Order?>> GetOrderByIdAsync(int orderId)
        {
            var result = await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Include(o => o.FulfillingWarehouse)
                .FirstOrDefaultAsync(o => o.Id == orderId);
            return ApiResponse<Order>.Success(result);
        }
        /// <summary>
        /// Confirms shipment and updates inventory. This typically happens after the order is picked and packed.
        /// </summary>
        public async Task<ApiResponse<bool>> ConfirmShipmentAndUpdateInventoryAsync(int orderId)
        {
            int maxRetries = 3;
            for (int i = 0; i < maxRetries; i++)
            {
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var order = await _context.Orders
                            .Include(o => o.OrderItems)
                            .Include(o => o.FulfillingWarehouse) // Ensure warehouse is loaded
                            .FirstOrDefaultAsync(o => o.Id == orderId);

                        if (order == null || order.Status != OrderStatus.Processing)
                        {
                            return ApiResponse<bool>.Failure($"Order {orderId} not found or not in Processing status.");
                        }

                        if (order.FulfillingWarehouse == null)
                        {
                            return ApiResponse<bool>.Failure($"Order {orderId} does not have a fulfilling warehouse assigned.");
                        }

                        // Load inventory items that are specific to this order's products for the warehouse
                        // Ensure we get the latest row version for these inventory items
                        var productIdsInOrder = order.OrderItems.Select(oi => oi.ProductId).ToList();

                        var warehouseInventory = await _context.InventoryItems
                                                   .Where(ii => ii.WarehouseId == order.FulfillingWarehouseId && productIdsInOrder.Contains(ii.ProductId))
                                                   .ToListAsync(); // This fetches items with their current RowVersion

                        foreach (var orderItem in order.OrderItems)
                        {
                            var inventoryItem = warehouseInventory.FirstOrDefault(ii => ii.ProductId == orderItem.ProductId);

                            if (inventoryItem == null || inventoryItem.QuantityReserved < orderItem.Quantity)
                            {
                                return ApiResponse<bool>.Failure($"Inconsistent inventory for product {orderItem.Product.Name} in order {orderId}. Reserved: {inventoryItem?.QuantityReserved ?? 0}, Shipped: {orderItem.Quantity}");
                            }

                            // Reduce both reserved and on-hand quantities
                            // Giảm cả QuantityReserved (vì hàng đã được chuyển đi) và QuantityOnHand (hàng đã ra khỏi kho vật lý)
                            inventoryItem.QuantityReserved -= orderItem.Quantity;
                            inventoryItem.QuantityOnHand -= orderItem.Quantity;
                        }

                        order.Status = OrderStatus.Shipped; // Cập nhật trạng thái đơn hàng
                        order.OrderDate = DateTime.UtcNow; // Update shipment date

                        // SaveChangesAsync() here triggers concurrency check
                        await _context.SaveChangesAsync();
                        await transaction.CommitAsync();
                        Console.WriteLine($"Order {orderId} shipped and inventory updated successfully.");
                        return ApiResponse<bool>.Success(true);
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        await transaction.RollbackAsync();
                        Console.WriteLine($"Concurrency conflict detected during shipment confirmation. Retrying ({i + 1}/{maxRetries})... Error: {ex.Message}");
                        foreach (var entry in ex.Entries)
                        {
                            await entry.ReloadAsync(); // Reload to get latest data for retry
                        }
                        if (i == maxRetries - 1)
                        {
                            return ApiResponse<bool>.Failure("Maximum retries reached for concurrency conflict on shipment.");
                        }
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return ApiResponse<bool>.Failure($"Error confirming shipment for order {orderId}: {ex.Message}");
                    }
                }
            }
             return ApiResponse<bool>.Failure("Failure ConfirmShipmentAndUpdateInventoryAsync");
        }
    }
}
