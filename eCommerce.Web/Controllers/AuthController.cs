using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using eCommerce.Shared.Common;
using System.IdentityModel.Tokens.Jwt;
using eCommerce.Application.Interface;
using eCommerce.Application.Dtos;
using eCommerce.Web.Services.IService;
using eCommerce.Application.Interfaces;

namespace eCommerce.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthApiClient _authService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IShoppingCartService _shoppingCartService;

        public AuthController(
            IAuthApiClient authService
            , ITokenProvider tokenProvider
            , IShoppingCartService shoppingCartService)
        {
            _authService = authService;
            _tokenProvider = tokenProvider;
            _shoppingCartService = shoppingCartService;
        }
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return LocalRedirect(returnUrl ?? "/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequestDto obj, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            // Lấy ID giỏ hàng ẩn danh HIỆN TẠI TRƯỚC KHI ĐĂNG NHẬP
            var anonymousCartCookieName = "AnonymousCartId";
            var anonymousUserId = Request.Cookies[anonymousCartCookieName];

            string authenticatedUserId = "someAuthenticatedUserId";

            var responseDto = await _authService.LoginAsync(obj);
            if (responseDto != null && responseDto.IsSuccess)
            {
                var loginResponseDto = responseDto.Data;

                if (!string.IsNullOrEmpty(anonymousUserId) && anonymousUserId != authenticatedUserId)
                {
                    //await _shoppingCartService.MergeCartsAsync(anonymousUserId, authenticatedUserId);
                    // Xóa cookie giỏ hàng ẩn danh sau khi hợp nhất
                    Response.Cookies.Delete(anonymousCartCookieName);
                }

                await SignInUser(loginResponseDto);
                _tokenProvider.SetToken(loginResponseDto.Token);

                return LocalRedirect(returnUrl ?? "/");
            }
            else
            {
                TempData["error"] = responseDto.Message;
                return View(obj);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Register(string? returnUrl = null)
        {
            var regions = await _authService.GetRegionsAsync();
            ViewBag.Regions = regions.Data?.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Name
            }).ToList();

            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text=SD.RoleAdmin,Value=SD.RoleAdmin},
                new SelectListItem{Text=SD.RoleCustomer,Value=SD.RoleCustomer},
            };

            ViewBag.RoleList = roleList;
            return LocalRedirect(returnUrl ?? "/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterationRequestDto obj, string? returnUrl = null)
        {
            var anonymousCartCookieName = "AnonymousCartId";
            var anonymousUserId = Request.Cookies[anonymousCartCookieName];

            var result = await _authService.RegisterAsync(obj);

            if (result != null && result.IsSuccess)
            {
                if (string.IsNullOrEmpty(obj.Role))
                {
                    obj.Role = SD.RoleCustomer;
                }
                var  assingRole = await _authService.AssignRoleAsync(obj);
                if (assingRole != null && assingRole.IsSuccess)
                {
                    TempData["success"] = "Registration Successful";
                    return RedirectToAction(nameof(Login));
                }
                string authenticatedUserId = "someNewlyRegisteredUserId";
                if (!string.IsNullOrEmpty(anonymousUserId) && anonymousUserId != authenticatedUserId)
                {
                    //await _cartService.MergeCartsAsync(anonymousUserId, authenticatedUserId);
                    Response.Cookies.Delete(anonymousCartCookieName);
                }
                return LocalRedirect(returnUrl ?? "/");
            }
            else
            {
                TempData["error"] = result.Message;
            }

            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text=SD.RoleAdmin,Value=SD.RoleAdmin},
                new SelectListItem{Text=SD.RoleCustomer,Value=SD.RoleCustomer},
            };

            ViewBag.RoleList = roleList;
            return View(obj);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            _tokenProvider.ClearToken();
            return RedirectToAction("Index", "Home");
        }

        private async Task SignInUser(LoginResponseDto model)
        {
            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.ReadJwtToken(model.Token);

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Email,
                jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Email).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub,
                jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Sub).Value));
            identity.AddClaim(new Claim(JwtRegisteredClaimNames.Name,
                jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Name).Value));


            identity.AddClaim(new Claim(ClaimTypes.Name,
                jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Email).Value));
            identity.AddClaim(new Claim(ClaimTypes.Role,
                jwt.Claims.FirstOrDefault(u => u.Type == "role").Value));

            identity.AddClaim(new Claim("RegionId",
             jwt.Claims.FirstOrDefault(u => u.Type == "RegionId").Value));

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

    }
}
