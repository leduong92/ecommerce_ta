using eCommerce.Application.Interface;
using eCommerce.Application.Services;
using eCommerce.Shared.Common;
using eCommerce.Web.Resources;
using Microservices.Web.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// --- START: Add Localization Services (NEW) ---
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources"); // Specify where .resx files are located

builder.Services.AddMvc()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix) // For shared resources and view-specific resources
    .AddDataAnnotationsLocalization(options => { // For validating data annotations based on locale
        options.DataAnnotationLocalizerProvider = (type, factory) =>
            factory.Create(typeof(SharedResources)); // Use SharedResources for Data Annotations
    });

// Configure the supported cultures
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new List<CultureInfo>
    {
        new CultureInfo("en-US"),
        new CultureInfo("vi-VN"),
        new CultureInfo("zh-CN")
        // Add more cultures here based on your Language model
    };

    options.DefaultRequestCulture = new RequestCulture("en-US"); // Default culture
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    // How to determine the culture:
    // 1. Query string (e.g., ?culture=vi-VN)
    // 2. Cookie (persistent across requests)
    // 3. Accept-Language header
    options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
    options.RequestCultureProviders.Insert(1, new CookieRequestCultureProvider());
    // The Accept-Language header provider is usually added by default and is typically last.
});

// Add services to the container.
builder.Services.AddControllersWithViews();
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

// --- START: Use Localization Middleware (NEW) ---
var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>()?.Value;
app.UseRequestLocalization(localizationOptions!);
// --- END: Use Localization Middleware ---

app.UseSession(); // IMPORTANT: Must be before UseAuthorization and MapControllers

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
