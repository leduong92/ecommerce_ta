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
using Microsoft.Extensions.Logging;

namespace eCommerce.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthApiClient _authService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IShoppingCartService _cartService;
        private readonly ILogger<AuthController> _logger;
        public AuthController(
            IAuthApiClient authService
            , ITokenProvider tokenProvider
            , ILogger<AuthController> logger
            , IShoppingCartService cartService)
        {
            _authService = authService;
            _tokenProvider = tokenProvider;
            _cartService  = cartService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return LocalRedirect(returnUrl ?? "/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequestDto model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // Get the anonymous cart ID BEFORE successful login (from the browser's cookie)
                var anonymousCartCookieName = "AnonymousCartId";
                Guid? anonymousUserId = null;
                if (Guid.TryParse(Request.Cookies[anonymousCartCookieName], out Guid parsedAnonymousId))
                {
                    anonymousUserId = parsedAnonymousId;
                }

                // --- Replace this with your ACTUAL authentication logic ---
                // This is a PLACEHOLDER for demonstrating cart merge
                // In a real app, you would validate credentials against a database
                // or an Identity provider.
                Guid authenticatedUserId;
                if (model.Email == "test@example.com" && model.Password == "Password123!")
                {
                    authenticatedUserId = Guid.Parse("B0000000-0000-0000-0000-000000000001"); // Example GUID for authenticated user
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, authenticatedUserId.ToString()),
                        new Claim(ClaimTypes.Name, model.Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties { IsPersistent = model.RememberMe };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    _logger.LogInformation($"User {authenticatedUserId} (test@example.com) logged in successfully (placeholder).");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt (placeholder).");
                    return View(model);
                }
                // --- End of placeholder authentication logic ---

                // AFTER successful login, perform cart merge
                if (anonymousUserId.HasValue && anonymousUserId.Value != authenticatedUserId)
                {
                    try
                    {
                        await _cartService.MergeCartsAsync(anonymousUserId.Value, authenticatedUserId);
                        // Delete the anonymous cart cookie from the browser after successful merge
                        Response.Cookies.Delete(anonymousCartCookieName);
                        _logger.LogInformation($"Merged cart for anonymous user {anonymousUserId.Value} to authenticated user {authenticatedUserId}.");
                    }
                    catch (HttpRequestException ex)
                    {
                        _logger.LogError(ex, "Error during cart merge after login for user {AuthenticatedUserId}", authenticatedUserId);
                        // You might want to display a warning to the user, but don't prevent login
                        TempData["WarningMessage"] = "Could not merge your previous cart. Please check your items.";
                    }
                }

                return LocalRedirect(returnUrl ?? "/");
            }
            return View(model);
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

        // Register action - similar merge logic if you allow anonymous cart to be carried over on registration
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterationRequestDto model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text=SD.RoleAdmin,Value=SD.RoleAdmin},
                new SelectListItem{Text=SD.RoleCustomer,Value=SD.RoleCustomer},
            };

            ViewBag.RoleList = roleList;

            if (ModelState.IsValid)
            {
                var anonymousCartCookieName = "AnonymousCartId";
                Guid? anonymousUserId = null;
                if (Guid.TryParse(Request.Cookies[anonymousCartCookieName], out Guid parsedAnonymousId))
                {
                    anonymousUserId = parsedAnonymousId;
                }

                // --- Replace this with your ACTUAL registration logic ---
                Guid newlyRegisteredUserId;
                if (model.Email == "newuser@example.com" && model.Password == "Password123!")
                {
                    newlyRegisteredUserId = Guid.NewGuid(); // Generate new GUID for new user
                    // Simulate creating user and logging them in
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, newlyRegisteredUserId.ToString()),
                        new Claim(ClaimTypes.Name, model.Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties { IsPersistent = false };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    _logger.LogInformation($"User {newlyRegisteredUserId} (newuser@example.com) registered successfully (placeholder).");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid registration attempt (placeholder).");
                    return View(model);
                }
                // --- End of placeholder registration logic ---

                if (anonymousUserId.HasValue && anonymousUserId.Value != newlyRegisteredUserId)
                {
                    try
                    {
                        await _cartService.MergeCartsAsync(anonymousUserId.Value, newlyRegisteredUserId);
                        Response.Cookies.Delete(anonymousCartCookieName);
                        _logger.LogInformation($"Merged cart for anonymous user {anonymousUserId.Value} to newly registered user {newlyRegisteredUserId}.");
                    }
                    catch (HttpRequestException ex)
                    {
                        _logger.LogError(ex, "Error during cart merge after registration for user {NewlyRegisteredUserId}", newlyRegisteredUserId);
                        TempData["WarningMessage"] = "Could not merge your previous cart. Please check your items.";
                    }
                }

                return LocalRedirect(returnUrl ?? "/");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            _logger.LogInformation("User logged out.");
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
