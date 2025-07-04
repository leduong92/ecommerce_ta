using eCommerce.Application.Dtos;
using eCommerce.Application.Interfaces;
using eCommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // You might want to assign a UserId here if user is authenticated
            // For simplicity, we're passing it from the request for now.

            var order = await _orderService.ProcessCheckoutAsync(request);

            if (order == null)
            {
                return BadRequest("Failed to process checkout. Check server logs for details.");
            }

            return Ok(new { Message = "Order placed successfully!", OrderId = order.Id, TotalAmount = order.TotalAmount });
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrder(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return NotFound("Order not found.");
            }
            return Ok(order);
        }

        [HttpPut("{orderId}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, [FromBody] UpdateOrderStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!Enum.TryParse(request.NewStatus, true, out OrderStatus newStatus))
            {
                return BadRequest("Invalid order status provided.");
            }

            var success = await _orderService.UpdateOrderStatusAsync(orderId, newStatus);
            if (!success)
            {
                return NotFound("Order not found or update failed.");
            }
            return Ok(new { Message = $"Order {orderId} status updated to {newStatus}." });
        }

        [HttpPost("{orderId}/confirm-shipment")]
        public async Task<IActionResult> ConfirmShipment(int orderId)
        {
            var success = await _orderService.ConfirmShipmentAndUpdateInventoryAsync(orderId);
            if (!success)
            {
                return BadRequest("Failed to confirm shipment or update inventory. Check server logs.");
            }
            return Ok(new { Message = $"Order {orderId} shipment confirmed and inventory updated." });
        }
    }

}

