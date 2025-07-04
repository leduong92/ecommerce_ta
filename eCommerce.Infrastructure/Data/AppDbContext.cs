using eCommerce.Domain.Entities;
using eCommerce.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace eCommerce.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<
        ApplicationUser,
        ApplicationRole,
        Guid,
        ApplicationUserClaim,
        ApplicationUserRole,
        ApplicationUserLogin,
        ApplicationRoleClaim,
        ApplicationUserToken>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Collection> Collections { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Care> Cares { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<LifeStyle> LifeStyles { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductVariantOptionValue> ProductVariantOptionValues { get; set; }
        public DbSet<ProductCare> ProductCares { get; set; }
        public DbSet<ProductFabric> ProductFabrics { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialCategory> MaterialCategories { get; set; }
        public DbSet<UPHFabric> UPHFabrics { get; set; }
        public DbSet<UPHColor> UPHColors { get; set; }
        public DbSet<UPHPattern> UPHPatterns { get; set; }
        public DbSet<UPHContent> UPHContents { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ShippingZone> ShippingZones { get; set; }
        public DbSet<ShippingZoneDetail> ShippingZoneDetails { get; set; }
        public DbSet<ShippingServiceLevel> ShippingServiceLevels { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductShippingProfile> ProductShippingProfiles { get; set; }
        public DbSet<GlobalShippingLane> GlobalShippingLanes { get; set; }
        public DbSet<ShippingRateRule> ShippingRateRules { get; set; }
        public DbSet<ShippingRateTier> ShippingRateTiers { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ApplicationUserLogin>()
                        .HasKey(l => new { l.LoginProvider, l.ProviderKey });
            modelBuilder.Entity<ApplicationUserToken>()
                        .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            modelBuilder.Entity<ApplicationUserRole>()
                        .HasKey(r => new { r.UserId, r.RoleId });
            modelBuilder.Entity<ApplicationUserLogin>()
                        .HasKey(x => x.UserId);

            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
    }
}
