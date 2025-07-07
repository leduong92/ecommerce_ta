using eCommerce.Application.Interfaces;
using eCommerce.Application.Services;
using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Data;
using eCommerce.Shared.Common;
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
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>(); // NEW
builder.Services.AddScoped<IOrderService, OrderService>(); // NEW
builder.Services.AddScoped<IProductService, ProductService>(); // NEW
builder.Services.AddScoped<ILanguageService, LanguageService>(); // NEW
builder.Services.AddScoped<IRegionService, RegionService>(); // NEW

// Configure Session
builder.Services.AddDistributedMemoryCache(); // Required for session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set your session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Make the session cookie essential
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

app.UseSession(); // NEW

app.UseAuthorization();

app.MapControllers();

app.Run();
