using eCommerce.Application.Interfaces;
using eCommerce.Application.Services;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Register services
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("ApiSettings:JwtOptions"));
builder.Services.AddScoped<ShippingCalculatorService>();
builder.Services.AddScoped<WarehouseService>();
builder.Services.AddScoped<ICartService, CartService>(); // NEW
builder.Services.AddScoped<IOrderService, OrderService>(); // NEW
builder.Services.AddScoped<IProductService, ProductService>(); // NEW
builder.Services.AddScoped<ILanguageService, LanguageService>(); // NEW
builder.Services.AddScoped<IRegionService, RegionService>(); // NEW

// Configure Cookie Authentication (if you're using this for API auth, common for monolithic apps)
// If you're using JWT/Bearer tokens, this part will be different.
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "eCommerceAuthCookie"; // Name your authentication cookie
        options.ExpireTimeSpan = TimeSpan.FromDays(30);
        options.SlidingExpiration = true;
        options.LoginPath = "/api/Auth/Login"; // This won't be hit directly by browser for API
        options.LogoutPath = "/api/Auth/Logout";
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
        options.Cookie.SameSite = SameSiteMode.Lax; // Important for cross-site requests if your client is on different domain/port
    });
builder.Services.AddAuthorization();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("https://localhost:7142") // Replace with your MVC client URL
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()); // Allow cookies/credentials
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin"); // Use CORS policy

app.UseAuthentication(); // Must be before UseAuthorization
app.UseAuthorization();

app.MapControllers();

app.Run();
