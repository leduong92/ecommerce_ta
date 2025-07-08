using eCommerce.Application.Interface;
using eCommerce.Application.Services;
using eCommerce.Shared.Common;
using eCommerce.Web.Services;
using eCommerce.Web.Services.IService;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using System.Globalization;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var supportedCultures = new[]
{
    new CultureInfo("en"),
    new CultureInfo("vi"),
    new CultureInfo("zh"),
};

builder.Services.AddLocalization(opt => opt.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedUICultures = supportedCultures;
    options.SupportedCultures = supportedCultures;
    options.FallBackToParentCultures = true;
    options.FallBackToParentUICultures = true;
});

builder.Services.AddControllersWithViews()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization();

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"] ?? throw new InvalidOperationException("ApiBaseUrl is not configured."));
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
});

SD.ApiBaseUrl = builder.Configuration["ApiBaseUrl"];

builder.Services.AddScoped<ITokenProvider, TokenProvider>();
builder.Services.AddScoped<IBaseApiClient, BaseApiClient>();
builder.Services.AddScoped<ILanguageApiClient, LanguageApiClient>();
builder.Services.AddScoped<IRegionApiClient, RegionApiClient>();
builder.Services.AddScoped<IProductApiClient, ProductApiClient>();

// Configure Session
builder.Services.AddDistributedMemoryCache(); // Required for session state
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set a short timeout for testing
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Make session cookie essential
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

var options = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en"), // Default to English
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};
options.RequestCultureProviders.Insert(0, new RouteDataRequestCultureProvider
{
    RouteDataStringKey = "culture",
    UIRouteDataStringKey = "culture"
});
options.RequestCultureProviders.Add(new CookieRequestCultureProvider());
options.RequestCultureProviders.Add(new AcceptLanguageHeaderRequestCultureProvider()); // Fallback to browser language
app.UseRequestLocalization(options);

app.UseSession(); // IMPORTANT: Must be before UseAuthorization and MapControllers
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}",
    constraints: new { culture = "en|vi|zh" });

app.Run();
