using eCommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using eCommerce.Web.Services.IService;
using Microsoft.Extensions.Localization;
using eCommerce.Shared.Common;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Azure;
using System.Drawing;
using eCommerce.Domain.Entities;

namespace eCommerce.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ProductController> _logger;
        private readonly IProductApiClient _productApiClient;
        private readonly string _apiBaseUrl;
        private readonly IStringLocalizer<SharedResources> _localizer;
        public ProductController(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<ProductController> logger
            , IProductApiClient productApiClient
            , IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _productApiClient = productApiClient;
            _apiBaseUrl = configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured.");
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id, string regionCode, int? color = null, int? size = null)
        {
            ViewBag.CurrentRegion = regionCode;

            //var client = _httpClientFactory.CreateClient("ApiClient");
            var latitude = HttpContext.Session.GetString("CustomerLatitude");
            var longitude = HttpContext.Session.GetString("CustomerLongitude");

            //string requestUrl = $"{_apiBaseUrl}Product/{id}/detail/{regionCode}";
            //if (!string.IsNullOrEmpty(latitude) && !string.IsNullOrEmpty(longitude))
            //{
            //    requestUrl += $"?latitude={latitude}&longitude={longitude}";
            //}

            //_logger.LogInformation($"Requesting product details from: {requestUrl}");

            //var response = await client.GetAsync(requestUrl);
            var response = await _productApiClient.GetProductDetail(id, regionCode, latitude, longitude, color, size);

            if (response.IsSuccess)
            {
                //var content = await response.Content.ReadAsStringAsync();
                //var product = JsonSerializer.Deserialize<ProductDetailDto>(content, new JsonSerializerOptions
                //{
                //    PropertyNameCaseInsensitive = true
                //});
                return View(response.Data);
            }
            else if (response.StatusCode == 404)
            {
                TempData["ErrorMessage"] = $"Product {id} not found or not available in region '{regionCode}'.";
                return RedirectToAction("Index", "Home", new { regionCode = regionCode });
            }
            else
            {
                TempData["ErrorMessage"] = $"Error fetching product details: {response.Message}";
                _logger.LogError($"Error fetching product details: {response.StatusCode} - {response.Message}");
                return RedirectToAction("Index", "Home", new { regionCode = regionCode });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToCartAsync(AddToCartRequestDto request)
        {
            var anonymousId = Request.Cookies[SD.AnonymousId];
            if (request.Quantity <= 0)
            {
                TempData["ErrorMessage"] = "Quantity must be positive.";
                return RedirectToAction("Detail", new { id = request.ProductId, regionCode = request.CustomerRegionCode });
            }

            var client = _httpClientFactory.CreateClient("ApiClient");
            var sessionId = HttpContext.Session.Id;
            if (string.IsNullOrEmpty(sessionId))
            {
                // Nếu chưa có Session, khởi tạo Session ID mới ( ASP.NET Core tự làm)
                // và thiết lập một giá trị bất kỳ để kích hoạt Session
                HttpContext.Session.SetString("Initialized", DateTime.UtcNow.ToString());
                sessionId = HttpContext.Session.Id;
            }

            // Use the AddToCartRequest DTO from the API project
            var requestData = new AddToCartRequestDto
            {
                AnonymousId = anonymousId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                CustomerRegionCode = request.CustomerRegionCode,
                VariantId = request.VariantId,
                SizeId = request.SizeId,
                FabricId = request.FabricId,
                FinishId = request.FinishId
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{_apiBaseUrl}Cart/add", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Product added to cart successfully!";
                return Json(new
                {
                    isSuccess = true,
                    message = "Added to cart",
                    redirectUrl = Url.Action("Index", "Cart")
                });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Error adding to cart: {response.StatusCode} - {errorContent}");
                TempData["ErrorMessage"] = $"Error adding product to cart: {errorContent}";
                return Json(new
                {
                    isSuccess = false,
                    message = "Failed",
                    redirectUrl = Url.Action("Index", "Product")
                });
            }
        }

        [HttpGet("{productId}/GetVariantPartial/{regionCode}")]
        public async Task<IActionResult> GetVariantPartial(int productId, string regionCode, int? sizeId, int? fabricId, int? finishId)
        {
            var data = await _productApiClient.GetProductDetail(productId, regionCode, null, null, sizeId, fabricId, finishId);
            if (data == null) return NotFound();
            return PartialView("_VariantOptionsPartial", data.Data);
        }
        [HttpGet("{productId}/GetVariantData")]
        public async Task<IActionResult> GetVariantData(int productId, int? sizeId, int? fabricId, int? finishId)
        {
            var data = await _productApiClient.GetVariantAsync(productId, sizeId, fabricId, finishId);
            return Json(data);
        }
    }
}
