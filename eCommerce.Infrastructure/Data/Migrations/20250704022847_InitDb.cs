using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContentTitle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContentBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentImageS7 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IamgeUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CollectionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ImageType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsDescription = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsLogo = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsCarousel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LifeStyleId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false),
                    MinAmount = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LifeStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsBulky = table.Column<bool>(type: "bit", nullable: false),
                    RequiresAssembly = table.Column<bool>(type: "bit", nullable: false),
                    IsFragile = table.Column<bool>(type: "bit", nullable: false),
                    DefaultDimensionalFactor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductShippingProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    IsBulky = table.Column<bool>(type: "bit", nullable: false),
                    RequiresPallet = table.Column<bool>(type: "bit", nullable: false),
                    RequiresSpecialEquipment = table.Column<bool>(type: "bit", nullable: false),
                    DefaultDimensionalFactor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShippingProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingServiceLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedDeliveryDaysMin = table.Column<int>(type: "int", nullable: false),
                    EstimatedDeliveryDaysMax = table.Column<int>(type: "int", nullable: false),
                    DeliveryType = table.Column<int>(type: "int", nullable: false),
                    IncludesAssembly = table.Column<bool>(type: "bit", nullable: false),
                    RequiresSpecialHandling = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingServiceLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPHColours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colour = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    CodeHex = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPHColours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPHContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPHContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPHFabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabric = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Content1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Content6 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sampled = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PatternCode = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Vrepeat = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Hrepeat = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Width = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CleaningCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Application = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Durability = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Enable = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabledOnWeb = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Rlc = table.Column<bool>(type: "bit", nullable: true),
                    GradeTrim = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CategoryTrim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rubs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QtyOnHand = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Um = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Pfp = table.Column<bool>(type: "bit", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeVn = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPHFabrics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPHPatterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pattern = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Patterncode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPHPatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_MaterialCategories_MaterialCategoryId",
                        column: x => x.MaterialCategoryId,
                        principalTable: "MaterialCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductOptionId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptionValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptionValues_ProductOptions_ProductOptionId",
                        column: x => x.ProductOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingZones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingZones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingZones_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    FabricCode = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    Desccription = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UPHFabricId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFabrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFabrics_UPHFabrics_UPHFabricId",
                        column: x => x.UPHFabricId,
                        principalTable: "UPHFabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GlobalShippingLanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    OriginShippingZoneId = table.Column<int>(type: "int", nullable: false),
                    DestinationShippingZoneId = table.Column<int>(type: "int", nullable: false),
                    PrimaryCarrierPartner = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    TransitMode = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    EstimatedTransitDaysMin = table.Column<int>(type: "int", nullable: false),
                    EstimatedTransitDaysMax = table.Column<int>(type: "int", nullable: false),
                    SupportsConsolidation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalShippingLanes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GlobalShippingLanes_ShippingZones_DestinationShippingZoneId",
                        column: x => x.DestinationShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GlobalShippingLanes_ShippingZones_OriginShippingZoneId",
                        column: x => x.OriginShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingZoneDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingZoneId = table.Column<int>(type: "int", nullable: false),
                    DetailType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingZoneDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingZoneDetails_ShippingZones_ShippingZoneId",
                        column: x => x.ShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    City = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    StateProvince = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Longitude = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ShippingZoneId = table.Column<int>(type: "int", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Warehouses_ShippingZones_ShippingZoneId",
                        column: x => x.ShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ExtendedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    DefaultImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Depth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetWeightLbs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossWeightLbs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxHeight = table.Column<int>(type: "int", nullable: true),
                    QuantityMultiplier = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    LifeStyleId = table.Column<int>(type: "int", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductShippingProfileId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_LifeStyles_LifeStyleId",
                        column: x => x.LifeStyleId,
                        principalTable: "LifeStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductShippingProfiles_ProductShippingProfileId",
                        column: x => x.ProductShippingProfileId,
                        principalTable: "ProductShippingProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingRateRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OriginShippingZoneId = table.Column<int>(type: "int", nullable: false),
                    DestinationShippingZoneId = table.Column<int>(type: "int", nullable: false),
                    ShippingServiceLevelId = table.Column<int>(type: "int", nullable: false),
                    ProductShippingProfileId = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    GlobalShippingLaneId = table.Column<int>(type: "int", nullable: true),
                    BaseRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RatePerKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RatePerCbm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RatePerItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinApplicableWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxApplicableWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinApplicableCbm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxApplicableCbm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinItemsInOrder = table.Column<int>(type: "int", nullable: false),
                    MaxItemsInOrder = table.Column<int>(type: "int", nullable: false),
                    MaxWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinWeightKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinOrderValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxOrderValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFreeShippingThreshold = table.Column<bool>(type: "bit", nullable: false),
                    FreeShippingMinOrderValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FlatSurcharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercentageSurcharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurchargeReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplyFloorSurcharge = table.Column<bool>(type: "bit", nullable: false),
                    MinFloorForSurcharge = table.Column<int>(type: "int", nullable: false),
                    SurchargePerFloor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinOrderWeightOrVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxOrderWeightOrVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsRuralAreaSurcharge = table.Column<bool>(type: "bit", nullable: false),
                    RuralAreaSurchargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingRateRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_GlobalShippingLanes_GlobalShippingLaneId",
                        column: x => x.GlobalShippingLaneId,
                        principalTable: "GlobalShippingLanes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_ProductShippingProfiles_ProductShippingProfileId",
                        column: x => x.ProductShippingProfileId,
                        principalTable: "ProductShippingProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_ShippingServiceLevels_ShippingServiceLevelId",
                        column: x => x.ShippingServiceLevelId,
                        principalTable: "ShippingServiceLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_ShippingZones_DestinationShippingZoneId",
                        column: x => x.DestinationShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShippingRateRules_ShippingZones_OriginShippingZoneId",
                        column: x => x.OriginShippingZoneId,
                        principalTable: "ShippingZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 18, nullable: false),
                    ShippingFirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ShippingLastName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ShippingAddress1 = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ShippingAddress2 = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ShippingCity = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ShippingStateProvince = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ShippingZipCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ShippingCountryCode = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    ShippingLatitude = table.Column<double>(type: "float", nullable: false),
                    ShippingLongitude = table.Column<double>(type: "float", nullable: false),
                    ShippingPhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ShippingFloorNumber = table.Column<int>(type: "int", nullable: false),
                    ShippingIsRuralArea = table.Column<bool>(type: "bit", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChosenShippingServiceLevelName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ChosenShippingDeliveryType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ChosenShippingEstimatedDaysMin = table.Column<int>(type: "int", nullable: false),
                    ChosenShippingEstimatedDaysMax = table.Column<int>(type: "int", nullable: false),
                    ChosenShippingOriginWarehouseName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ChosenShippingRouteDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    FulfillingWarehouseId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Warehouses_FulfillingWarehouseId",
                        column: x => x.FulfillingWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false),
                    QuantityReserved = table.Column<int>(type: "int", nullable: false),
                    MinimumStockLevel = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItems_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCares",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCares", x => new { x.CareId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductCares_Cares_CareId",
                        column: x => x.CareId,
                        principalTable: "Cares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCares_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Currency = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeyword = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => new { x.ProductId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PriceAdjustment = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingRateTiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingRateRuleId = table.Column<int>(type: "int", nullable: false),
                    MinValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TierUnit = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    RatePerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FixedTierCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingRateTiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingRateTiers_ShippingRateRules_ShippingRateRuleId",
                        column: x => x.ShippingRateRuleId,
                        principalTable: "ShippingRateRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantOptionValues",
                columns: table => new
                {
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    ProductOptionValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantOptionValues", x => new { x.ProductVariantId, x.ProductOptionValueId });
                    table.ForeignKey(
                        name: "FK_ProductVariantOptionValues_ProductOptionValues_ProductOptionValueId",
                        column: x => x.ProductOptionValueId,
                        principalTable: "ProductOptionValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariantOptionValues_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cares",
                columns: new[] { "Id", "ContentBody", "ContentImageS7", "ContentTitle", "CreatedAt", "CreatedBy", "DisplayName", "IamgeUrl", "IsActive", "Name", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "<p>Frequently dust exposed surfaces with a clean, damp natural cloth. Dry the surface with another clean, dry cloth. Infrequently polish your furniture (a few times a year at most) with a non-silicon-base furniture polish made by a reputable manufacturer, taking care to follow the instructions. Bear in mind that one manufacturer’s furniture care products should never be used in combination with another. Product formulations are unique to each manufacturer and are made to blend with another, so using different polishes may cause build-up that can appear cloudy or dull over time, and/or feel sticky to the touch. Always polish or dust with a motion that follows the grain of the wood to avoid scratching the surface, and allow polish to dry completely before replacing any objects on the surface.</p>", "Wood", "Wood", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8444), null, "Wood", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Wood", 10, null, null },
                    { 2, "<p>Theodore Alexander artists painstakingly create our hand-painted finishes using meticulous brushstrokes and age-old techniques. You can use a good quality furniture polish to maintain and preserve the unique artwork. Take care not to use abrasive cloths or polishes that may scratch a hand-painted finish.</p><ul><li>• Eglomisé – Eglomisé is a hand-made, centuries-old process that creates a stunning reflective surface. Regularly dust with a feather duster and wipe clean with a damp, lint-free cloth.</li><li>• Argento – The Argento finish from Theodore Alexander is the result of an exclusive finishing process. From time to time, wipe clean with a soft, damp cloth, taking care not to over-wet the surface.</li></ul>", "Artistry", "Artistry", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8473), null, "Artistry", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Artistry", 10, null, null },
                    { 3, "<p>Remove all loose cushions. Loosen dirt with a hand-held dusting brush while using a vacuum brush attachment to remove dust. Vacuum all surfaces of the furniture: back, sides, arms, skirt (if applicable) and the platform beneath the cushions. Vacuum both sides of the loose cushions.</p><p>When necessary, you can use commercially available cleaners on Theodore Alexander upholstery. Be sure to test on an inconspicuous area first. For day-to-day cleaning use a soft clean damp cloth.</p>", "Upholstery", "Upholstery", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8493), null, "Upholstery", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Upholstery", 10, null, null },
                    { 4, "<p>Leather is a naturally hard-wearing and versatile material that will gain a characteristic and pleasing patina over time. Leather will show natural marks with wrinkles, scars, scratches and bites which are all normal. It is these characteristics that differentiate real hide from synthetic or re-constituted coverings. Take care not to expose your leather or hide product to continuous direct sunlight as this might  lead to fading.</p><p>For accidental spills, try to wipe up immediately and don’t allow the stain to dry. Light stains can be removed with a diluted solution of a neutral soap in lukewarm water, but be careful not to soak the leather or hide. Occasionally, pencil marks and other light marks can be removed by rubbing the area lightly with an eraser. If your leather or hide is heavily soiled, we recommend professional cleaning.</p>", "Leather", "Leather", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8568), null, "Leather", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Leather", 10, null, null },
                    { 5, "<p>Theodore Alexander lampshades are meticulously handmade by skilled craftspeople. Most shades simply require a light dusting with a feather duster or soft brush to remove dust. Vacuum using smooth, light strokes with the small bristle attachment found on most vacuum cleaners, or gently wipe with a soft, clean cloth.</p>", "Lampshades", "Lampshades", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8587), null, "Lampshades", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Lampshades", 10, null, null },
                    { 6, "<p>The plain brass and etched tops and panels used on Theodore Alexander furniture require particular care during use and cleaning. Each panel has a rich patina created by a process of natural oxidization that leads to the deep colouration. Having been created by natural elements, etched brass is particularly sensitive to certain compounds and liquids, particularly those with abrasive or acidic bases. This includes wine, spirits and some furniture creams.</p><p>We recommend you take precautions to avoid spills and scratches by using coasters and placemats. Should a spill occur it must be wiped up immediately with a soft, clean cloth. Scratches may be touched up using a dark coloured shoe wax. </p><p>Over time you may see some colouration changes in the finish, such as a soft mottling. This is perfectly natural as the oxidization process continues and will in no way detract from the beauty of the item. </p><p>For everyday cleaning we recommend that you use only a soft, natural fibre cloth and a small amount of oil soap. </p>", "Etched Brass", "Etched Brass", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8607), null, "Etched Brass", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Etched Brass", 10, null, null },
                    { 7, "Each piece of brass inlay is carefully inset by hand by a Theodore Alexander artisan. Simply wipe clean using a soft, damp cloth and a gentle hand.", "Brass Inlay", "Brass Inlay", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8626), null, "Brass Inlay", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Brass Inlay", 10, null, null },
                    { 8, "Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on iron as this may cause rusting.", "Iron", "Iron", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8643), null, "Iron", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Iron", 10, null, null },
                    { 9, "Brass artworks are hand cast in our own foundry, using age-old techniques. Occasional application of an inert wax that does not contain a cleansing agent will preserve the patina of the metal. Avoid using abrasive cloths or polishes that may damage the surface.", "Brass", "Brass", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8663), null, "Brass", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Brass", 10, null, null },
                    { 10, "<p>Warm water and a soft, lint-free cloth are ideal for routine cleaning. Wipe in the direction of the polish lines and dry with a towel or cloth to prevent water spots. Stainless steel cleaner cloths can help minimize scratching, remove stains and polish stainless steel surfaces nicely. Be sure to test in an inconspicuous spot.</p>", "Stainless Steel", "Stainless Steel", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8682), null, "Stainless Steel", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Stainless Steel", 10, null, null },
                    { 11, "Rub piece with a non-abrasive nickel-plate cleanser and a clean, dry cloth. Buff gently with smooth strokes to restore lustre.", "Nickel Plate", "Nickel Plate", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8700), null, "Nickel Plate", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Nickel Plate", 10, null, null },
                    { 12, "<p>Coasters should be used under all glasses, particularly those with alcohol or citrus content. Avoid placing hot items directly on the stone surface. Trivets or mats should be used under hot dishes and placemats under china, ceramics, silver or other objects that could scratch the surface. For calcareous (chalky) stones, many common foods and drinks that contain acids will etch or dull the surface.</p><ul><li>Clean stone surfaces with a few drops of neutral cleaner, stone soap, or a mild liquid dishwashing detergent and warm water. Use a clean soft cloth for best results. Excessive cleaner or soap could leave a film and cause streaks. Do not use products that contain lemon, vinegar, or other acids or bleach on marble or limestone. The surface should be thoroughly rinsed after washing with the soap solution and dried with a soft cloth. Avoid the use of scouring powders or creams; these abrasives will scratch the surface.</li></ul>", "Stone", "Stone", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8719), null, "Nickel Plate", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Stone", 10, null, null },
                    { 13, "A light dusting with a soft brush is all that is needed to clean bone, horn and antler objects. Bone and horn that are in good condition (that is with a smooth, glossy surface) and have no applied decoration can be cleaned with a little water and a soft, clean cloth. Dry the object immediately with another cloth.", "Bone / Horn", "Bone / Horn", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8737), null, "Bone / Horn", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Bone / Horn", 10, null, null },
                    { 14, "<p>Theodore Alexander artists painstakingly create our hand-painted finishes using meticulous brushstrokes and age-old techniques. You can use a good quality furniture polish to maintain and preserve the unique artwork. Take care not to use abrasive cloths or polishes that may scratch a hand-painted finish.</p><ul><li>• Eglomisé – Eglomisé is a hand-made, centuries-old process that creates a stunning reflective surface. Regularly dust with a feather duster and wipe clean with a damp, lint-free cloth.</li><li>• Argento – The Argento finish from Theodore Alexander is the result of an exclusive finishing process. From time to time, wipe clean with a soft, damp cloth, taking care not to over-wet the surface.</li></ul>", "Hand Painting Eglomisé", "Hand Painting Eglomisé", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8755), null, "Hand Painting Eglomisé", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Hand Painting Eglomisé", 10, null, null },
                    { 15, "Hand-blown glass is created by artisans and each piece is unique. There will be variations in shape and form that are illustrative of the hand-made nature of each piece. Hand-blown glass tends to be more delicate than mass-produced glass and we recommend gentle cleaning with a damp, soft cloth to maintain the lustre and beauty of the original piece.", "Glass", "Glass", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8774), null, "Glass", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Glass", 10, null, null },
                    { 16, "Once a week, dust exposed surfaces with a clean and moist cotton cloth. Then dry the surface with a clean and dry cloth. Once a month, polish your furniture with a non-silicone good quality paste wax made by a reputable manufacturer, taking care to follow the instructions. Always polish or dust with a motion that follows the grain of the wood to avoid scratching the surface, and allow polish to dry completely before replacing any objects on the surface. For greasy stains or waxy build-up use a diluted dish detergent which should be wiped on with a clean cloth and removed with another. The whole affected surface should be waxed after this process to maintain consistency in protection.", "Crotch", "Crotch", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8792), null, "Crotch", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Crotch", 10, null, null },
                    { 17, "<p>Dust with a soft, damp cloth or chamois. Dry or gritty cloths may cause surface scratches and create a static electric charge on the surface. Clean Acrylic with a solution of mild soap or detergent and lukewarm water. Use a clean soft cloth, applying only light pressure. Rinse with clean water and dry by blotting with a damp cloth or chamois. DO NOT USE: Window cleaning sprays, kitchen scouring compounds or solvents such as acetone, gasoline, benzene, alcohol, carbon tetrachloride, or lacquer thinner. These can scratch the surface and/or weaken it causing small surface cracks called, “crazing.”</p>", "Acrylic", "Acrylic", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8810), null, "Acrylic", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Acrylic", 10, null, null },
                    { 18, "<p>Coasters should be used under all glasses, particularly those with alcohol or citrus content. Avoid placing hot items directly on the surface. Trivets or mats should be used under hot dishes and placemats under china, ceramics, silver or other objects that could scratch the surface. Many common foods and drinks that contain acids can etch or dull the surface.</p><ul><li>Clean surfaces with a few drops of neutral cleaner, or a mild liquid dishwashing detergent and warm water. Use a clean soft cloth for best results. Excessive cleaner or soap could leave a film and cause streaks. Thoroughly wipe surface with a water dampened soft cloth to remove any remaining soap. Avoid the use of scouring powders or creams; these abrasives will scratch the surface. Do not use products that contain lemon, vinegar, or other acids or bleach.</li></ul>", "COMPOSITE", "COMPOSITE", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8829), null, "COMPOSITE", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "COMPOSITE", 10, null, null },
                    { 19, "<p>Clean with a damp, clean cloth. Avoid using cleansers with a highly acidic base or ones that are extremely abrasive. Cleaners formulated with bleach can also damage eggshell pieces, particularly those with a polished or coated finish.</p>", "Eggshell", "Eggshell", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8848), null, "Eggshell", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Eggshell", 10, null, null },
                    { 20, "<p>Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on aluminum as this may cause tarnishing.</p>", "Aluminium", "Aluminium", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8867), null, "Aluminium", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Aluminium", 10, null, null },
                    { 21, "<p>Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on steel as this may cause rusting.</p>", "Steel", "Steel", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8884), null, "Steel", "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg", true, "Steel", 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4186), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/1.jpg", true, 10, null, null },
                    { 2, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4214), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/2.jpg", true, 20, null, null },
                    { 3, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4237), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/3.jpg", true, 30, null, null },
                    { 4, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4259), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/4.jpg", true, 40, null, null },
                    { 5, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4282), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/5.jpg", true, 50, null, null },
                    { 6, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4305), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/6.jpg", true, 60, null, null },
                    { 7, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4328), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/7.jpg", true, 70, null, null },
                    { 8, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4351), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/8.jpg", true, 80, null, null },
                    { 9, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4374), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/9.jpg", true, 90, null, null },
                    { 10, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4398), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/10.jpg", true, 100, null, null },
                    { 11, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4421), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/11.jpg", true, 110, null, null },
                    { 12, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4448), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/12.jpg", true, 120, null, null },
                    { 13, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4471), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/13.jpg", true, 130, null, null },
                    { 14, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4493), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/14.jpg", true, 140, null, null },
                    { 15, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4515), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/15.jpg", true, 150, null, null },
                    { 16, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4581), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/16.jpg", true, 160, null, null },
                    { 17, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4604), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/17.jpg", true, 170, null, null },
                    { 18, 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4634), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/18.jpg", true, 180, null, null },
                    { 19, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4658), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/1.jpg", true, 10, null, null },
                    { 20, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4682), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/2.jpg", true, 20, null, null },
                    { 21, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4705), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/3.jpg", true, 30, null, null },
                    { 22, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4727), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/4.jpg", true, 40, null, null },
                    { 23, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4750), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/5.jpg", true, 50, null, null },
                    { 24, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4772), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/6.jpg", true, 60, null, null },
                    { 25, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4794), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/7.jpg", true, 70, null, null },
                    { 26, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4816), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/8.jpg", true, 80, null, null },
                    { 27, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4838), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/9.jpg", true, 90, null, null },
                    { 28, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4860), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/10.jpg", true, 100, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageType", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 29, 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4883), null, 1, "https://theodorealexander.sirv.com/Videos/Althorp%20for%20website_Collection%20banner_with_captions.mp4", true, 110, null, null });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 30, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4906), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/1.jpg", true, 10, null, null },
                    { 31, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4929), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/2.jpg", true, 20, null, null },
                    { 32, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4951), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/3.jpg", true, 30, null, null },
                    { 33, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4973), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/4.jpg", true, 40, null, null },
                    { 34, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4997), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/5.jpg", true, 50, null, null },
                    { 35, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5019), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/6.jpg", true, 60, null, null },
                    { 36, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5042), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/7.jpg", true, 70, null, null },
                    { 37, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5064), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/8.jpg", true, 80, null, null },
                    { 38, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5087), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/9.jpg", true, 90, null, null },
                    { 39, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5163), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/10.jpg", true, 100, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageType", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 40, 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5187), null, 1, "https://theodorealexander.sirv.com/Videos/Althorp%20for%20website_Collection%20banner_with_captions.mp4", true, 110, null, null });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 41, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5210), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/1.jpg", true, 10, null, null },
                    { 42, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5232), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/2.jpg", true, 20, null, null },
                    { 43, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5254), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/3.jpg", true, 30, null, null },
                    { 44, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5277), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/4.jpg", true, 40, null, null },
                    { 45, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5300), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/5.jpg", true, 50, null, null },
                    { 46, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5323), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/6.jpg", true, 60, null, null },
                    { 47, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5345), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/7.jpg", true, 70, null, null },
                    { 48, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5368), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/8.jpg", true, 80, null, null },
                    { 49, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5392), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/9.jpg", true, 90, null, null },
                    { 50, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5414), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/10.jpg", true, 100, null, null },
                    { 51, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5436), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/11.jpg", true, 110, null, null },
                    { 52, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5457), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/12.jpg", true, 120, null, null },
                    { 53, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5480), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/13.jpg", true, 130, null, null },
                    { 54, 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5502), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/14.jpg", true, 140, null, null },
                    { 55, 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5525), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/1.jpg", true, 10, null, null },
                    { 56, 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5548), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/2.jpg", true, 20, null, null },
                    { 57, 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5570), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/3.jpg", true, 30, null, null },
                    { 58, 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5593), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/4.jpg", true, 40, null, null },
                    { 59, 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5615), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/5.jpg", true, 50, null, null },
                    { 60, 6, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5637), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/brooksby/1.jpg", true, 10, null, null },
                    { 61, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5659), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/1.jpg", true, 10, null, null },
                    { 62, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5682), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/2.jpg", true, 20, null, null },
                    { 63, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5705), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/3.jpg", true, 30, null, null },
                    { 64, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5868), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/4.jpg", true, 40, null, null },
                    { 65, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5891), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/5.jpg", true, 50, null, null },
                    { 66, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5916), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/6.jpg", true, 60, null, null },
                    { 67, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5939), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/7.jpg", true, 70, null, null },
                    { 68, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5962), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/8.jpg", true, 80, null, null },
                    { 69, 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5984), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/9.jpg", true, 90, null, null },
                    { 70, 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6006), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/1.jpg", true, 10, null, null },
                    { 71, 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6029), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/2.jpg", true, 20, null, null },
                    { 72, 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6051), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/3.jpg", true, 30, null, null },
                    { 73, 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6073), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/4.jpg", true, 40, null, null },
                    { 74, 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6094), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/5.jpg", true, 50, null, null },
                    { 75, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6117), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/1.jpg", true, 10, null, null },
                    { 76, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6140), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/2.jpg", true, 20, null, null },
                    { 77, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6162), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/3.jpg", true, 30, null, null },
                    { 78, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6186), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/4.jpg", true, 40, null, null },
                    { 79, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6209), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/5.jpg", true, 50, null, null },
                    { 80, 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6231), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/6.jpg", true, 60, null, null },
                    { 81, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6254), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/1.jpg", true, 10, null, null },
                    { 82, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6276), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/2.jpg", true, 20, null, null },
                    { 83, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6300), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/3.jpg", true, 30, null, null },
                    { 84, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6322), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/4.jpg", true, 40, null, null },
                    { 85, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6344), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/5.jpg", true, 50, null, null },
                    { 86, 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6472), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/6.jpg", true, 60, null, null },
                    { 87, 12, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6497), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/horizon/1.jpg", true, 10, null, null },
                    { 88, 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6520), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/1.jpg", true, 10, null, null },
                    { 89, 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6543), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/2.jpg", true, 20, null, null },
                    { 90, 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6565), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/3.jpg", true, 30, null, null },
                    { 91, 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6588), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/4.jpg", true, 40, null, null },
                    { 92, 15, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6610), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/judith-leiber-couture/1.jpg", true, 10, null, null },
                    { 93, 15, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6632), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/judith-leiber-couture/2.jpg", true, 20, null, null },
                    { 94, 16, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6655), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/1.jpg", true, 10, null, null },
                    { 95, 16, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6676), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/2.jpg", true, 20, null, null },
                    { 96, 16, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6698), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/3.jpg", true, 30, null, null },
                    { 97, 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6720), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/1.jpg", true, 10, null, null },
                    { 98, 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6745), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/2.jpg", true, 20, null, null },
                    { 99, 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6767), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/3.jpg", true, 30, null, null },
                    { 100, 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6791), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/4.jpg", true, 40, null, null },
                    { 101, 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6813), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/5.jpg", true, 50, null, null },
                    { 102, 18, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6836), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/luna/1.jpg", true, 10, null, null },
                    { 103, 19, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6859), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/1.jpg", true, 10, null, null },
                    { 104, 19, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6883), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/2.jpg", true, 20, null, null },
                    { 105, 19, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6905), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/3.jpg", true, 30, null, null },
                    { 106, 20, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6929), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/montauk/1.jpg", true, 10, null, null },
                    { 107, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6952), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/1.jpg", true, 10, null, null },
                    { 108, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6974), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/2.jpg", true, 20, null, null },
                    { 109, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6997), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/3.jpg", true, 30, null, null },
                    { 110, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7020), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/4.jpg", true, 40, null, null },
                    { 111, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7042), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/5.jpg", true, 50, null, null },
                    { 112, 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7121), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/6.jpg", true, 60, null, null },
                    { 113, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7144), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/1.jpg", true, 10, null, null },
                    { 114, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7166), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/2.jpg", true, 20, null, null },
                    { 115, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7189), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/3.jpg", true, 30, null, null },
                    { 116, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7211), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/4.jpg", true, 40, null, null },
                    { 117, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7234), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/5.jpg", true, 50, null, null },
                    { 118, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7256), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/6.jpg", true, 60, null, null },
                    { 119, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7279), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/7.jpg", true, 70, null, null },
                    { 120, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7303), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/8.jpg", true, 80, null, null },
                    { 121, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7324), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/9.jpg", true, 90, null, null },
                    { 122, 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7343), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/10.jpg", true, 100, null, null },
                    { 123, 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7364), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/1.jpg", true, 10, null, null },
                    { 124, 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7384), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/2.jpg", true, 20, null, null },
                    { 125, 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7407), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/3.jpg", true, 30, null, null },
                    { 126, 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7427), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/4.jpg", true, 40, null, null },
                    { 127, 25, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7446), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/1.jpg", true, 10, null, null },
                    { 128, 25, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7466), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/2.jpg", true, 20, null, null },
                    { 129, 25, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7485), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/3.jpg", true, 30, null, null },
                    { 130, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7508), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/1.jpg", true, 10, null, null },
                    { 131, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7569), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/2.jpg", true, 20, null, null },
                    { 132, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7591), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/3.jpg", true, 30, null, null },
                    { 133, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7610), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/4.jpg", true, 40, null, null },
                    { 134, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7629), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/5.jpg", true, 50, null, null },
                    { 135, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7648), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/6.jpg", true, 60, null, null },
                    { 136, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7668), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/7.jpg", true, 70, null, null },
                    { 137, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7689), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/8.jpg", true, 80, null, null },
                    { 138, 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7709), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/9.jpg", true, 90, null, null },
                    { 139, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7727), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/1.jpg", true, 10, null, null },
                    { 140, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7749), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/2.jpg", true, 20, null, null },
                    { 141, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7769), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/3.jpg", true, 30, null, null },
                    { 142, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7788), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/4.jpg", true, 40, null, null },
                    { 143, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7809), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/5.jpg", true, 50, null, null },
                    { 144, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7828), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/6.jpg", true, 60, null, null },
                    { 145, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7860), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/7.jpg", true, 70, null, null },
                    { 146, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7880), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/8.jpg", true, 80, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageType", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 147, 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7898), null, 1, "https://theodorealexander.sirv.com/Videos/spencer.mp4", true, 1, null, null });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 148, 29, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7917), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-st-james/1.jpg", true, 10, null, null },
                    { 149, 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7937), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/1.jpg", true, 10, null, null },
                    { 150, 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7958), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/2.jpg", true, 20, null, null },
                    { 151, 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7978), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/3.jpg", true, 30, null, null },
                    { 152, 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7999), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/4.jpg", true, 40, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageType", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 153, 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8027), null, 1, "https://theodorealexander.sirv.com/Videos/Stephen_Church_with_caption.mp4", true, 1, null, null });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 154, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8046), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/1.jpg", true, 10, null, null },
                    { 155, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8065), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/2.jpg", true, 20, null, null },
                    { 156, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8135), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/3.jpg", true, 30, null, null },
                    { 157, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8158), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/4.jpg", true, 40, null, null },
                    { 158, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8179), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/5.jpg", true, 50, null, null },
                    { 159, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8198), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/6.jpg", true, 60, null, null },
                    { 160, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8227), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/7.jpg", true, 70, null, null },
                    { 161, 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8246), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/8.jpg", true, 80, null, null },
                    { 162, 33, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8265), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-originals/1.jpg", true, 10, null, null },
                    { 163, 33, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8294), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-originals/2.jpg", true, 20, null, null },
                    { 164, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8313), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/1.jpg", true, 10, null, null },
                    { 165, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8334), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/2.jpg", true, 20, null, null },
                    { 166, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8353), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/3.jpg", true, 30, null, null },
                    { 167, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8382), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/4.jpg", true, 40, null, null },
                    { 168, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8402), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/5.jpg", true, 50, null, null },
                    { 169, 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8421), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/6.jpg", true, 60, null, null },
                    { 170, 35, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8440), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/1.jpg", true, 10, null, null },
                    { 171, 35, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8469), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/2.jpg", true, 20, null, null },
                    { 172, 35, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8489), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/3.jpg", true, 30, null, null }
                });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageType", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 173, 36, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8507), null, 1, "https://theodorealexander.sirv.com/Videos/TA_Upholstery_Factory_120423_1080p_Final_Lowres.mp4", true, 10, null, null });

            migrationBuilder.InsertData(
                table: "CollectionImages",
                columns: new[] { "Id", "CollectionId", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 174, 36, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8527), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/upholstery/1.jpg", true, 20, null, null },
                    { 175, 37, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8556), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/accessories/1.jpg", true, 10, null, null },
                    { 176, 38, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8576), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/urbane/1.jpg", true, 10, null, null },
                    { 177, 38, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8596), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/urbane/2.jpg", true, 20, null, null },
                    { 178, 39, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8624), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/art-by-ta/1.jpg", true, 10, null, null },
                    { 179, 40, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8654), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-illuminations/1.jpg", true, 10, null, null },
                    { 180, 40, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8673), null, "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-illuminations/2.jpg", true, 20, null, null }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsCarousel", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1100), null, "From New York City to Hangzhou, China, Alexa Hampton’s project portfolio encompasses luxe, beautifully layered urban apartments, expansive town and country residences, private airplanes, and yachts. Regularly named to Architectural Digest’s AD100 and House Beautiful’s Top Designer list as well as Elle Décor’s A-List, Hampton translates the classical principles of good design and decoration into some of today’s most elegant, enduring, and functional domestic landscapes.", true, true, null, null, "Alexa Hampton", "the-alexa-hampton-collection", 10, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1158), null, "The Iconic Collection makes careful use of rich materials and elevated forms for a discerning aesthetic that emphasizes luxury and eclectic refinement. Bronze outlines, asymmetric surfaces, sumptuous tufting, and bold, textural bases are beautifully concluded in an Icon Bronze finish.", true, true, null, null, "Althorp Living History", "althorp-living-history", 20, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1191), null, "The histories of the Spencer Family’s Heritage and Althorp are so tightly entwined that they would be impossible to unravel and separate. These Spencer ancestors were able to indulge their tastes – to commission art, furniture, and all the finer things in life. You can see the Spencer touch in every corner of Althorp – this historic house that my family has called “home” for over 500 years, and which for the past decade, has been given unprecedented care and attention.", true, true, null, null, "Althorp - Victory Oak", "althorp--victory-oak", 30, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1220), null, "A modern view of transitional luxe, Balboa creates an air of timeless elegance that blends seamlessly with today’s contemporary style. Simplistic forms and clean architectural lines, influenced by the works of George Hepplewhite, are paired with reeded carvings as a nod to the French Provincial aesthetic. Oak wood in a Coastal Grey finish is complemented with reeding and Dark Nickel.", true, true, null, null, "Balboa", "balboa", 40, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1253), null, "Organic modern forms are boldly reimagined in Breeze. Across the collection, a striking elegance is conveyed through faceted angles, beveled profiles, sunburst veneers, and unique Dark Sterling hardware. Using a handcrafted wire-brushed pine, each piece is then perfectly finished in a light and subdued Sea Salt. ", true, true, null, null, "Breeze", "breeze-collection", 50, null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1284), null, "In the Brooksby Collection, classical forms enjoy a refined simplicity across hand-carved motifs, saber legs, and traditional European silhouettes. Beautifully crafted from mahogany and cerejeira veneer for a distinguished elegance. ", true, true, null, null, "Brooksby", "brooksby", 60, null, null }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 7, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1346), null, "The Castle Bromwich collection exudes a polished sophistication in pieces that carefully reflect a classical influence. Gracefully showcasing the refined elegance of traditional forms, antiqued mahogany is exquisitely shaped with pedestal bases, turnings, and scroll carvings. ", true, null, null, "Castle Bromwich", "castle-bromwich", 70, null, null });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsCarousel", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1384), null, "Drawing inspiration from organic silhouettes and centered by the beauty of ash, a refined minimalism brings attention toward highly textural forms, rich grains, and porous stones. Perfectly hand-finished in a choice of Dune or Earth. ", true, true, null, null, "Catalina", "catalina", 80, null, null },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3017), null, "The Dorchester Collection is an accomplished reimagining of early 20th century design. Pairing decorative ornamentation with masterfully sculpted forms, handcrafted silhouettes lend themselves to a refined and sumptuous presence across swooping curves, tapered lines, and modern profiles.", true, true, null, null, "Dorchester", "dorchester", 90, null, null },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3116), null, "The Echoes Collection is a material story of oak wood, intricate parquetry and hand-cast aluminum, plus distressed leather and Belgian linens with widely spaced nailhead to soften the look. Our specially calibrated industrial chic finishes are weathered and dry, but full of tactile appeal and vivacity.", true, true, null, null, "Echoes", "the-echoes-collection", 100, null, null },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3149), null, "The Essence collection is composed from an alluring blend of rich materials and imaginative forms. Tasteful, softened lines are gracefully juxtaposed by organic shapes and highly textural silhouettes. Compellingly crafted from white oak and hand-finished in a choice of Blonde or Opal. ", true, true, null, null, "Essence", "essence-collection", 110, null, null },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3239), null, "The gracefully rounded forms of  the Horizon collection paired with  the fine reeded details of these oak  designs provide airy silhouettes that  are ideal for laid back contemporary  living. The Horizon collection is  offered in a light Day finish ensuring  a sleek finish, clean lines, versatility  and elegance to spare.", true, true, null, null, "Horizon", "horizon", 120, null, null },
                    { 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3350), null, "Luxurious upholstered pieces pair elegantly with rich maple veneers and contrasting metal accents in Theodore Alexander’s Hudson Collection. A curated assortment of exquisite designs, the feeling of Art Deco luxury follows muted burl finished in exquisite maple grey with polished stainless-steel accents. From contrasting maple drawers to white marble tops, the Hudson Collection places an emphasis on sleek and modern sophistication. Finished in Pebble Grey with stainless steel hardware.", true, true, null, null, "Hudson", "hudson-collection", 130, null, null }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 14, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3374), null, "Luxurious materials and unparalleled craftsmanship form a bold complexity in the Isola collection. Pieces enjoy a varied aesthetic that centers on geometric shapes in the form of chevron relief, nested squares, and asymmetrical patterns. Finished in a choice of Gowan or Charteris. ", true, null, null, "Isola", "the-isola-collection", 140, null, null });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsCarousel", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 15, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3392), null, "Immerse yourself in the opulent world of Judith Leiber Couture with our inaugural collection, a showcase of indulgent sophistication that pays homage to the iconic aesthetic of the revered fashion designer. Each piece is a creative masterpiece, adorned with resplendent details such as mother-of-pearl encrusted inlays, meticulously hand-painted details, and polished brass accents. Presented in the exquisite Mink or Martini oak finishes, these luxurious statement pieces, mirroring the essence of the brand’s iconic handbags, are tailored to individuals who embrace an elegant approach to life.", true, true, null, null, "Judith Leiber Couture", "judith-leiber-couture", 150, null, null },
                    { 16, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3411), null, "The Kesden Collection tells a story that begins with the depth and richness of Theodore Alexander’s veneers and ends with clean and transitional lines that promote gorgeous finishes and metal accents. The Kesden Collection possesses a feeling of effortless sophistication. With graceful silhouettes and gentle figures, Kesden is a harmonious blend of organic, sculpted bamboo forms and contrasting marbles, metals and veneers. From exquisite legs in bronze to Tamo ash burl tops, each piece serves as functional art for the home.", true, true, null, null, "Kesden", "kesden-collection", 160, null, null },
                    { 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3430), null, "A modern view of transitional luxe, Lido creates an air of timeless elegance that blends seamlessly with today’s contemporary style. Simplistic forms and clean architectural lines, influenced by the works of George Hepplewhite, are paired with reeded carvings as a nod to the French Provincial aesthetic. Figured Prima Vera and Beech, featured in our dark Bistre finish, is complimented by a beautifully honed Crema Marfil marble stone top. Lido’s custom forged hardware adds an alluring air of sophistication in a dark rubbed bronze finish, echoing the reeding details throughout.", true, true, null, null, "LIDO", "lido-collection", 170, null, null },
                    { 18, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3477), null, "A tease between understated glamor  and coastal ease, the Luna collection’s  gentle round edges and stylish  silhouettes infuse contemporary comfort  in two colorways: dark Palmer and  light Cascade. This collection’s suite of  thoughtfully designed oak furnishings  adapts to a wide range of settings from  seaside estate to bustling city lofts and  everything in between.", true, true, null, null, "Luna", "luna", 180, null, null },
                    { 19, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3498), null, "Taking cues from sophistication of  simplicity, the Maxwell collection’s pared  down shapes make way for its textural  shagreen surfaces. Available in Obsidian  and Cashmere finishes, this handsome  collection of oak furnishings is versatile  and sculptural while delivering an elevated  and modern air to the spaces they inhabit.", true, true, null, null, "Maxwell", "maxwell", 190, null, null },
                    { 20, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3546), null, "The Montauk collection is a seamlessly  crafted ensemble of transitional  wooden case goods that effortlessly  blends contemporary design with  timeless elegance. The finishes  options enhance the organic appeal  of this offering, while the clean lines  and subtle detailing lend a modern  touch to the furniture. Available in  a bold Jetty and soft Lighthouse  colorway this collection’s chameleon  ability to morph between aesthetics  solidifies its heirloom qualities that will  stand the test of time.", true, true, null, null, "Montauk", "montauk", 200, null, null }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 21, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3565), null, "Morning Room", true, null, null, "Morning Room", "morning-room", 210, null, null });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsCarousel", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3583), null, "Refined and minimal, a feeling of subdued elegance surrounds the NOVA collection. Pleasing details of hand-carved starburst and herringbone parquetry, rustic oak, and verde bronzed hardware add to the quiet simplicity. Beautifully finished in a choice of Dawn or Dusk. ", true, true, null, null, "NOVA", "nova-collection", 220, null, null },
                    { 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3616), null, "Inspired by an appreciation of Art Deco and Streamline Moderne, the sketches of Paul Maitland-Smith are reimagined in Origins. Long, low profiles, limited ornamentation, and attenuated forms embody the spirit of the collection, while the pieces themselves offer a sense of forward movement that can be both seen and felt.", true, true, null, null, "Origins", "origins", 230, null, null },
                    { 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3635), null, "Elevated by a carefully sculpted minimalism, the Repose collection beautifully plays sinuous curves against distinctly shaped forms in a relaxed palette of soothing neutrals. Wire-brushed white oak is elegantly finished in a choice of Charcoal Oak or Grey Oak. ", true, true, null, null, "Repose", "repose", 240, null, null },
                    { 25, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3652), null, "The Rome collection is expanded  beyond tables this spring,  translating its organic, slender  framework into wood. The warmth  of the oak paired with graceful  curves creates sculptural pieces that  are offered in a rich Nera finish.", true, true, null, null, "Rome", "rome", 250, null, null },
                    { 26, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3693), null, "Seated", true, true, null, null, "Seated", "seated", 260, null, null },
                    { 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3804), null, "A contemporary reinterpretation of designs from the 18th and 19th centuries, the Sloane Collection is a refined homage to the American Federal era and its English influences. Artisanal craftsmanship brings to life the balanced forms and pleasing silhouettes, while resplendent materials elegantly complete the pieces.", true, true, null, null, "Sloane", "sloane", 270, null, null },
                    { 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3823), null, "Marrying styles of Lord Spencer’s London home  with the exquisite capabilities of Theodore  Alexander’s craftsmanship, the Spencer London  collection brings fresh perspective to elegant  metro living. A consistent thread of chic,  mixed metal inlays are seen throughout the  furniture forms, bringing England’s rich history  to a current day contemporary style. Crafted  in figured sycamore, maple, and khaya crotch  wood, these designs have been painstakingly  fine tuned to offer a tailored product that is  uncompromising, timeless and approachable.", true, true, null, null, "Spencer London", "spencer-london", 280, null, null },
                    { 29, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3841), null, "A striking capsule collection, Spencer St. James is made of oak and adorned with crocodile-embossed leather, creating textural, statement-making experiences within the home. Available in a light Argento finish or a dark Onyx finish, the Spencer St. James collection blends contemporary flair with exquisite creativity and luxury details. These focal points elevate modern living spaces, whether hosting guests around sleek occasional tables or pouring spirits from its low-profile bar that has a colorful element of surprise inside.", true, true, null, null, "Spencer ST. James", "spencer-st-james", 290, null, null },
                    { 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3864), null, "Stephen Church is a Master Cabinetmaker who designs as well as crafts fine furniture following the tradition of English 18th century cabinet makers from Adam and Chippendale to Hepplewhite and Sheraton. Today those traditions are maintained with pride by a selected team of craftsmen working at Theodore Alexander.", true, true, null, null, "Stephen Church", "the-stephen-church-collection", 300, null, null },
                    { 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3890), null, "The Iconic Collection makes careful use of rich materials and elevated forms for a discerning aesthetic that emphasizes luxury and eclectic refinement. Bronze outlines, asymmetric surfaces, sumptuous tufting, and bold, textural bases are beautifully concluded in an Icon Bronze finish.", true, true, null, null, "Surrey", "surrey", 310, null, null }
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 32, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3908), null, "TA Artistry", true, null, null, "TA Artistry", "ta-artistry", 320, null, null });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "IsCarousel", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 33, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3927), null, "Rich, one-of-a-kind forms handcrafted in the finest materials and finishes. The TA Originals Collection brings artistic visions to life.", true, true, null, null, "TA Originals", "ta-originals", 330, null, null },
                    { 34, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3991), null, "TA Studio is an elegant, highly polished presentation of luxurious forms. Rich details of metallic accents, embossed shagreen leather wrappings, and superb finishes offer a sense of refinement atop designs composed from crisp angles, soft curves, and tapered silhouettes. ", true, true, null, null, "TA Studio", "ta-studio", 340, null, null },
                    { 35, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4011), null, "Inspired by the “Golden Age” of French Decorative Art, the Tavel collection gracefully echoes the intricate details and masterful craftsmanship of the late 18th century. Hand-carved motifs, saber legs, molded cornices, and serpentine drawers are exquisitely formed from beech, walnut, and oak woods. Finished in a refined selection of Avesta, Nora, and Elsa.", true, true, null, null, "Tavel", "the-tavel-collection", 350, null, null },
                    { 36, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4029), null, "The Theodore Alexander brand is synonymous with innovative designs that speak to today's lifestyles in ways that excite and entice. Theodore Alexander Upholstery is created with uncompromising standards and attention to detail.", true, true, null, null, "Upholstery", "upholstery", 360, null, null },
                    { 37, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4048), null, "Introducing a symphony of form and function that  harmoniously blends diverse materials to elevate your  living spaces. From elegant bookends to captivating  sculptures, each piece in this collection is meticulously  crafted to enhance your home decor.", true, true, null, null, "Accessories", "accessories", 370, null, null },
                    { 38, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4067), null, "Embracing a contemporary, casual aesthetic, the Urbane collection is a fashion forward collection made of wire-brushed pine. The legs are designed to create an eye-catching floating appearance, while its long, slender hardware is inspired by the texture of lizard skin. The Urbane collection debuts in two refined finishes: Campfire and Sundew. From bedrooms to dining rooms, each piece delivers a minimalist charm and artisanal warmth.", true, true, null, null, "Urbane", "urbane", 380, null, null },
                    { 39, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4085), null, "Introducing ART by TA, an exclusive collection of unique, curated wall art that adds a finishing touch to every space.", true, true, null, null, "Art by TA", "art-by-ta", 390, null, null },
                    { 40, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4103), null, "Introducing the “TA Illuminations” Lighting Collection by  Theodore Alexander – where artistry meets illumination.  This curated collection celebrates the interplay of  materials, styles, and sizes, creating a symphony of light  that transforms any space into a captivating haven.", true, true, null, null, "TA Illuminations", "ta-illuminations", 400, null, null },
                    { 41, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4122), null, "Defying style boundaries, the Floored Collection encompasses our carefully curated portfolio of designs, offerings rugs with a variety of dimensions to fit the aesthetic of any room.</br>Choosing a hand-woven or hand-knotted rug within our Stocked Collection allows for fulfillment along a convenient quick-ship timeline, perfect for projects with tight turnaround times. Love a Stocked design but need a custom size? Pieces within Floored’s Stocked program can also be crafted to suit alternative sizing requirements, extending the production timeline but offering the same gorgeous designs to perfectly fit unique spaces.</br>Bespoke spaces often call for custom-tailored floor coverings, and Floored’s Custom Collection provides solutions for rooms requiring that personal touch. Floored’s Custom Rugs are hand tufted and hand woven with Axminster and Hand Loomed constructions, offering an extensive assortment of options for color, pattern, style, sizing and more.", true, true, null, null, "Floored", "floored", 410, null, null },
                    { 42, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4140), null, "THEO by Theodore Alexander", true, true, null, null, "THEO by Theodore Alexander", "theo-by-theodore-alexander", 420, null, null }
                });

            migrationBuilder.InsertData(
                table: "LifeStyles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8919), null, "", "", true, null, null, "Classic", "classic", 10, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8942), null, "", "", true, null, null, "Transitional", "transitional", 20, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8961), null, "", "", true, null, null, "Rustic", "rustic", 30, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8989), null, "", "", true, null, null, "Modern", "modern", 40, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9008), null, "", "", true, null, null, "Casual", "casual", 50, null, null }
                });

            migrationBuilder.InsertData(
                table: "MaterialCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(124), null, true, "Metal", null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(145), null, true, "Upholstery Materials", null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(164), null, true, "Stone", null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(181), null, true, "Woods", null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(209), null, true, "Other Textures & Surface Treatments", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "DefaultDimensionalFactor", "Description", "IsBulky", "IsFragile", "Name", "RequiresAssembly" },
                values: new object[,]
                {
                    { 101, 6000.0, null, true, false, "Large Furniture", true },
                    { 102, 5000.0, null, true, false, "Medium Furniture", false },
                    { 103, 4000.0, null, false, true, "Decor Items", false }
                });

            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Color" },
                    { 2, "Size" }
                });

            migrationBuilder.InsertData(
                table: "ProductShippingProfiles",
                columns: new[] { "Id", "DefaultDimensionalFactor", "Description", "IsBulky", "Name", "RequiresPallet", "RequiresSpecialEquipment" },
                values: new object[,]
                {
                    { 201, 6000.0, "Requires freight shipping, often palletized", true, "Dining Table (Freight)", true, true },
                    { 202, 5000.0, "Can be shipped as large parcel or small freight", false, "Coffee Table (Freight/Parcel)", false, false },
                    { 203, 4000.0, "Small, non-bulky items, suitable for courier", false, "Standard Parcel", false, false }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Currency", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, "US", "USD", "North American Region", 37.090200000000003, -95.712900000000005, "United States" },
                    { 2, "VN", "VND", "Southeast Asia Region", 14.058299999999999, 108.27719999999999, "Vietnam" },
                    { 3, "GB", "GBP", "European Region", 55.378100000000003, -3.4359999999999999, "United Kingdom" },
                    { 4, "SG", "SGD", "Southeast Asia Hub", 1.3521000000000001, 103.8198, "Singapore" },
                    { 5, "CN", "CNY", "East Asia Region", 35.861699999999999, 104.19540000000001, "China" },
                    { 6, "RU", "RUB", "Eurasia Region", 61.524000000000001, 105.3188, "Russia" },
                    { 7, "ID", "IDR", "Southeast Asia Archipelago", -0.7893, 113.9213, "Indonesia" },
                    { 8, "CA", "CAD", "North American Region", 56.130400000000002, -106.3468, "Canada" },
                    { 9, "MX", "MXN", "North American Region", 23.634499999999999, -102.5528, "Mexico" },
                    { 10, "BR", "BRL", "South American Region", -14.234999999999999, -51.9253, "Brazil" },
                    { 11, "DE", "EUR", "European Region", 51.165700000000001, 10.451499999999999, "Germany" },
                    { 12, "IT", "EUR", "European Region", 41.871899999999997, 12.567399999999999, "Italy" },
                    { 13, "ES", "EUR", "European Region", 40.463700000000003, -3.7492000000000001, "Spain" },
                    { 14, "AU", "AUD", "Oceania Region", -25.2744, 133.77510000000001, "Australia" },
                    { 15, "JP", "JPY", "East Asia Region", 36.204799999999999, 138.25290000000001, "Japan" },
                    { 16, "IN", "INR", "South Asia Region", 20.593699999999998, 78.962900000000005, "India" },
                    { 17, "AE", "AED", "Middle East Region", 23.424099999999999, 53.847799999999999, "United Arab Emirates" },
                    { 18, "ZA", "ZAR", "African Regio", -30.5595, 22.9375, "South Africa" },
                    { 19, "KR", "KRW", "East Asia Region", 35.907800000000002, 127.76690000000001, "South Korea" },
                    { 20, "PH", "PHP", "Southeast Asia Region", 12.8797, 121.774, "Philippines" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"), "e2b1d49c-5d68-40c6-ad68-6538b12a3654", "Admin", "ADMIN" },
                    { new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"), "d11dae21-2338-4205-8a08-7203735d3749", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8707), null, "living", "https://ik.imagekit.io/9float9hy/Banner_for_Room/living-room/1.jpg", true, null, null, "Living", "living-room", 10, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8789), null, "dining", "https://ik.imagekit.io/9float9hy/Banner_for_Room/dining-room/1.jpg", true, null, null, "Dining", "dining-room", 20, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8808), null, "bedroom", "https://ik.imagekit.io/9float9hy/Banner_for_Room/bedroom/1.jpg", true, null, null, "Bed", "bedroom", 30, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8835), null, "office", "https://ik.imagekit.io/9float9hy/Banner_for_Room/office/1.jpg", true, null, null, "Office", "office", 40, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8853), null, "lighting", "https://ik.imagekit.io/9float9hy/Banner_for_Room/lighting/1.jpg", true, null, null, "Lighting", "lighting", 50, null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8872), null, "decor", "https://ik.imagekit.io/9float9hy/Banner_for_Room/decor/1.jpg", true, null, null, "Décor", "decor", 60, null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingServiceLevels",
                columns: new[] { "Id", "DeliveryType", "Description", "EstimatedDeliveryDaysMax", "EstimatedDeliveryDaysMin", "IncludesAssembly", "Name", "RequiresSpecialHandling" },
                values: new object[,]
                {
                    { 1, 0, "Bulk freight via ocean, port-to-port", 40, 25, false, "International Standard Ocean Freight", true },
                    { 2, 3, "Last-mile delivery, includes unboxing & assembly", 7, 3, true, "White Glove Delivery (Domestic)", false },
                    { 3, 0, "Faster air cargo, port-to-port", 14, 7, false, "International Air Freight (Expedited)", true },
                    { 4, 1, "Standard road freight within Vietnam", 5, 2, false, "Standard Domestic Freight (VN)", false },
                    { 5, 1, "Standard road freight within US", 10, 3, false, "Standard Domestic Freight (US)", false },
                    { 6, 3, "Local delivery with assembly in Indonesia", 5, 2, true, "Domestic White Glove (ID)", false },
                    { 7, 0, "Freight via rail, suitable for Eurasia", 25, 15, false, "International Rail Freight", true }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "IsActive", "MetaDescription", "MetaKeyword", "Name", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9043), null, "", "", true, null, null, "Formal Classic", "classic", 10, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9078), null, "", "", true, null, null, "Casual Classic", "casual-classic", 20, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9099), null, "", "", true, null, null, "Formal Transitional", "formal-transitional", 30, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9119), null, "", "", true, null, null, "Formal Traditional", "formal-traditional", 40, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9146), null, "", "", true, null, null, "Casual Transitional", "casual-transitional", 50, null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9166), null, "", "", true, null, null, "Casual Traditional", "casual-traditional", 60, null, null },
                    { 7, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9186), null, "", "", true, null, null, "Casual Rustic", "casual-rustic", 70, null, null },
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9204), null, "", "", true, null, null, "Formal Modern", "formal-modern", 80, null, null },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9232), null, "", "", true, null, null, "Casual Modern", "casual-modern", 90, null, null },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9251), null, "", "", true, null, null, "Formal Casual", "formal-casual", 100, null, null },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9269), null, "", "", true, null, null, "Casual", "casual", 110, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountNumber", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegionId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, "1f2baec9-3256-4456-a96f-14058e4c17a5", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "maileduong92@gmail.com", true, "Duong", "Mai", false, null, "maileduong92@gmail.com", "admin", "AQAAAAIAAYagAAAAEPicv1lN25LRpEvgcvHegRpoA6peGQtTWYhKlGPpL7FlkALRLs6dspDD1SvVz4/o8g==", null, false, 0, "", false, "admin" },
                    { new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"), 0, null, "7a7b49c3-069c-443c-be6b-c7d4729698c0", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer@gmail.com", true, "Duong", "Mai", false, null, "customer@gmail.com", "customer", "AQAAAAIAAYagAAAAEOcDxtgao4mEe40nI87UAvGAblTt7s+K+ALXt5BeuzCPAj5lAWlRvoWK+TEx++u69w==", null, false, 0, "", false, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "City", "ContactPhone", "CountryCode", "CreatedAt", "CreatedBy", "Description", "Email", "IsActive", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[,]
                {
                    { 2, "789 Export Zone", "Shenzhen", null, "CN", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9261), null, null, null, true, 22.543099000000002, 114.057868, "Shenzhen Export Hub (CN)", null, null, "Guangdong", null, null, "518000" },
                    { 4, "1 SG Trade Ln", "Singapore", null, "SG", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9265), null, null, null, true, 1.29027, 103.85195899999999, "Singapore Global Hub (SG)", null, null, "Singapore", null, null, "01000" },
                    { 5, "2 RU Logistics Pk", "Moscow", null, "RU", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9266), null, null, null, true, 55.755825000000002, 37.617297999999998, "Moscow Distribution Center (RU)", null, null, "Moscow Oblast", null, null, "101000" },
                    { 6, "3 ID Industrial Ctr", "Jakarta", null, "ID", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9268), null, null, null, true, -6.2087630000000003, 106.84559900000001, "Jakarta Warehouse (ID)", null, null, "Jakarta", null, null, "10000" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "MaterialCategoryId", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(238), null, true, 1, "Aluminium", null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(343), null, true, 1, "Brass", null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(361), null, true, 1, "Gilt Metal", null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(380), null, true, 1, "Iron", null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(406), null, true, 1, "Nickel Plated Brass", null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4647), null, true, 1, "Paktong", null, null },
                    { 7, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4679), null, true, 1, "Stainless Steel", null, null },
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4697), null, true, 1, "Steel", null, null },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4712), null, true, 1, "Zinc", null, null },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4731), null, true, 2, "Cow Hide ", null, null },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4747), null, true, 2, "Embossed Leather", null, null },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4763), null, true, 2, "Fabric", null, null },
                    { 13, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4779), null, true, 2, "Hair on Hide", null, null },
                    { 14, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4796), null, true, 2, "Leather", null, null },
                    { 15, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4812), null, true, 2, "Silk ", null, null },
                    { 16, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4828), null, true, 2, "Suede", null, null },
                    { 17, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4844), null, true, 2, "Upholstery", null, null },
                    { 18, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4860), null, true, 3, "Agate", null, null },
                    { 19, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4876), null, true, 3, "Alabaster", null, null },
                    { 20, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4892), null, true, 3, "Amethyst", null, null },
                    { 21, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4908), null, true, 3, "Carrara Marble", null, null },
                    { 22, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4924), null, true, 3, "Crystal", null, null },
                    { 23, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4940), null, true, 3, "Iron Pyrite", null, null },
                    { 24, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4956), null, true, 3, "Jade", null, null },
                    { 25, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4972), null, true, 3, "Lapis Lazuli", null, null },
                    { 26, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5074), null, true, 3, "Malachite", null, null },
                    { 27, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5091), null, true, 3, "Marble", null, null },
                    { 28, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5106), null, true, 3, "Onyx", null, null },
                    { 29, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5122), null, true, 3, "Quartz", null, null },
                    { 30, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5138), null, true, 3, "Red Jasper", null, null },
                    { 31, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5154), null, true, 3, "Soapstone", null, null },
                    { 32, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5170), null, true, 3, "Tiger Eye", null, null },
                    { 33, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5186), null, true, 3, "Travertine", null, null },
                    { 34, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5202), null, true, 3, "Turquoise Stone", null, null },
                    { 35, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5217), null, true, 3, "Variegated Black Marble", null, null },
                    { 36, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5232), null, true, 4, "Acacia", null, null },
                    { 37, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5247), null, true, 4, "Acacia Oyster Veneer", null, null },
                    { 38, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5262), null, true, 4, "Acacia Veneer", null, null },
                    { 39, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5277), null, true, 4, "Aged Oak Veneer", null, null },
                    { 40, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5294), null, true, 4, "Alder", null, null },
                    { 41, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5311), null, true, 4, "Amara Ebony Veneer", null, null },
                    { 42, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5326), null, true, 4, "Amara grained Veneer", null, null },
                    { 43, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5342), null, true, 4, "Amara Veneer", null, null },
                    { 44, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5358), null, true, 4, "Amarello Veneer", null, null },
                    { 45, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5373), null, true, 4, "Amboyna Burl", null, null },
                    { 46, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5390), null, true, 4, "Amboyna Burl Veneer", null, null },
                    { 47, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5408), null, true, 4, "Amotique Veneer", null, null },
                    { 48, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5425), null, true, 4, "Anagre Veneer", null, null },
                    { 49, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5440), null, true, 4, "Argentinean Walnut Veneer", null, null },
                    { 50, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5497), null, true, 4, "Ash Burl Veneer", null, null },
                    { 51, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5513), null, true, 4, "Ash Crown Veneer", null, null },
                    { 52, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5530), null, true, 4, "Ash Veneer", null, null },
                    { 53, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5546), null, true, 4, "Bamboo", null, null },
                    { 54, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5562), null, true, 4, "Beech", null, null },
                    { 55, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5578), null, true, 4, "Birds Eye Maple Veneer", null, null },
                    { 56, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5595), null, true, 4, "Block Anegre", null, null },
                    { 57, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5611), null, true, 4, "Bocote Veneer", null, null },
                    { 58, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5626), null, true, 4, "Brown Oak Burl", null, null },
                    { 59, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5642), null, true, 4, "Bubinga Veneer", null, null },
                    { 60, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5657), null, true, 4, "Cerejeira Veneer", null, null },
                    { 61, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5673), null, true, 4, "Cerejeria Veneer", null, null },
                    { 62, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5694), null, true, 4, "Cherry", null, null },
                    { 63, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5709), null, true, 4, "Cherry Crown Veneer", null, null },
                    { 64, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5725), null, true, 4, "Cherry Veneer", null, null },
                    { 65, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5741), null, true, 4, "Cherry Wood", null, null },
                    { 66, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5757), null, true, 4, "Chestnut Burl", null, null },
                    { 67, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5775), null, true, 4, "Chestnut Burl Veneer", null, null },
                    { 68, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5792), null, true, 4, "Chestnut Veneer", null, null },
                    { 69, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5808), null, true, 4, "Curly Maple Veneer", null, null },
                    { 70, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5824), null, true, 4, "Dragonwood", null, null },
                    { 71, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5840), null, true, 4, "Ebony Veneer", null, null },
                    { 72, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5896), null, true, 4, "Elm Burl Veneer", null, null },
                    { 73, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5913), null, true, 4, "Engineered Ebony Veneer", null, null },
                    { 74, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5929), null, true, 4, "Etimoe Veneer", null, null },
                    { 75, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5946), null, true, 4, "Fiddle Back Maple Veneer", null, null },
                    { 76, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5963), null, true, 4, "Fiddle Back Sycamore Veneer", null, null },
                    { 77, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5980), null, true, 4, "Figured Anegre Veneer", null, null },
                    { 78, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5996), null, true, 4, "Figured Ash Veneer", null, null },
                    { 79, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6012), null, true, 4, "Figured Birch", null, null },
                    { 80, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6028), null, true, 4, "Figured Etimoe Veneer", null, null },
                    { 81, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6045), null, true, 4, "Figured Eucalyptus Veneer", null, null },
                    { 82, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6061), null, true, 4, "Figured Makore", null, null },
                    { 83, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6078), null, true, 4, "Figured Ofram", null, null },
                    { 84, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6094), null, true, 4, "Figured Ofram Veneer", null, null },
                    { 85, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6109), null, true, 4, "Figured Sycamore Veneer", null, null },
                    { 86, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6125), null, true, 4, "Figured Walnut Veneer", null, null },
                    { 87, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6141), null, true, 4, "Flame Bubinga Veneer", null, null },
                    { 88, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6156), null, true, 4, "Flame Figured Veneer", null, null },
                    { 89, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6173), null, true, 4, "Flame Mahogany", null, null },
                    { 90, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6188), null, true, 4, "Flame Mahogany Veneer", null, null },
                    { 91, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6204), null, true, 4, "Flame Veneer", null, null },
                    { 92, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6220), null, true, 4, "Flame Walnut", null, null },
                    { 93, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6235), null, true, 4, "Flame Walnut Veneer", null, null },
                    { 94, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6251), null, true, 4, "Fumed Figured Eucalyptus Veneer", null, null },
                    { 95, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6268), null, true, 4, "Fumed Mahogany Veneer", null, null },
                    { 96, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6284), null, true, 4, "Golden Madrone Burl Veneer", null, null },
                    { 97, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6299), null, true, 4, "Golden Madrone Veneer", null, null },
                    { 98, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6357), null, true, 4, "Granadillo Veneer", null, null },
                    { 99, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6372), null, true, 4, "Grey Vine Veneer", null, null },
                    { 100, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6387), null, true, 4, "Hickory Veneer", null, null },
                    { 101, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6402), null, true, 4, "Hyedua Veneer", null, null },
                    { 102, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6419), null, true, 4, "Imbuya Burl Veneer", null, null },
                    { 103, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6435), null, true, 4, "Imbuya Veneer", null, null },
                    { 104, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6450), null, true, 4, "Karelian Birch Veneer", null, null },
                    { 105, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6466), null, true, 4, "Khaya", null, null },
                    { 106, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6481), null, true, 4, "Khaya Crotch Veneer", null, null },
                    { 107, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6496), null, true, 4, "Khaya Veneer", null, null },
                    { 108, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6512), null, true, 4, "Lacewood Veneer", null, null },
                    { 109, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6527), null, true, 4, "Lati Veneer", null, null },
                    { 110, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6543), null, true, 4, "Laurel Burl Veneer", null, null },
                    { 111, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6558), null, true, 4, "Layered Hardwood", null, null },
                    { 112, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6574), null, true, 4, "Lenga", null, null },
                    { 113, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6589), null, true, 4, "Louro Preto Veneer", null, null },
                    { 114, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6605), null, true, 4, "Macassar Ebony Veneer", null, null },
                    { 115, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6621), null, true, 4, "Madrone Burl Veneer", null, null },
                    { 116, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6637), null, true, 4, "Mahogany", null, null },
                    { 117, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6651), null, true, 4, "Mahogany Swirl", null, null },
                    { 118, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6668), null, true, 4, "Mahogany Veneer", null, null },
                    { 119, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6684), null, true, 4, "Maple", null, null },
                    { 120, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6704), null, true, 4, "Maple Burl Veneer", null, null },
                    { 121, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6719), null, true, 4, "Maple Veneer", null, null },
                    { 122, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6735), null, true, 4, "Marbled Sapele", null, null },
                    { 123, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6791), null, true, 4, "Morado Veneer", null, null },
                    { 124, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6808), null, true, 4, "Movingue", null, null },
                    { 125, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6824), null, true, 4, "Movingue Veneer", null, null },
                    { 126, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6840), null, true, 4, "Oak", null, null },
                    { 127, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6855), null, true, 4, "Oak Burl Veneer", null, null },
                    { 128, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6870), null, true, 4, "Oak Heart Veneer", null, null },
                    { 129, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6886), null, true, 4, "Oak Veneer", null, null },
                    { 130, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6903), null, true, 4, "Ofram Veneer", null, null },
                    { 131, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6920), null, true, 4, "Okoume Veneer/Mop Inlay", null, null },
                    { 132, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6936), null, true, 4, "Okumé Crotch Veneer", null, null },
                    { 133, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6953), null, true, 4, "Okumé Veneer", null, null },
                    { 134, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6973), null, true, 4, "Olive Ash Burl Veneer", null, null },
                    { 135, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6988), null, true, 4, "Olive Ash Swirl Veneer", null, null },
                    { 136, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7004), null, true, 4, "Oyster Veneer", null, null },
                    { 137, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7020), null, true, 4, "Pacific walnut", null, null },
                    { 138, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7036), null, true, 4, "Pacific Walnut Veneer", null, null },
                    { 139, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7052), null, true, 4, "Paldao Veneer", null, null },
                    { 140, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7068), null, true, 4, "Parawood", null, null },
                    { 141, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7084), null, true, 4, "Parchment", null, null },
                    { 142, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7138), null, true, 4, "Pepperwood Burl Veneer", null, null },
                    { 143, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7155), null, true, 4, "Perota Veneer", null, null },
                    { 144, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7171), null, true, 4, "Pine", null, null },
                    { 145, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7186), null, true, 4, "Pippy Oak Veneer", null, null },
                    { 146, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7202), null, true, 4, "Pollard Burl Veneer", null, null },
                    { 147, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7218), null, true, 4, "Pollard Oak Burl", null, null },
                    { 148, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7234), null, true, 4, "Pollard Oak Veneer", null, null },
                    { 149, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7250), null, true, 4, "Poplar", null, null },
                    { 150, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7266), null, true, 4, "Poplar Burl Veneer", null, null },
                    { 151, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7283), null, true, 4, "Primavera Veneer", null, null },
                    { 152, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7299), null, true, 4, "Quartered Etimoe Veneer", null, null },
                    { 153, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7317), null, true, 4, "Reclaimed Oak Veneer", null, null },
                    { 154, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7333), null, true, 4, "Redwood Burl Veneer", null, null },
                    { 155, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7350), null, true, 4, "Rosewood Veneer", null, null },
                    { 156, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7365), null, true, 4, "Santo Domingo Veneer", null, null },
                    { 157, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7382), null, true, 4, "Sapele", null, null },
                    { 158, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7398), null, true, 4, "Satinwood Veneer", null, null },
                    { 159, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7414), null, true, 4, "Simulated Amara Veneer", null, null },
                    { 160, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7429), null, true, 4, "Simulated Ebony Veneer", null, null },
                    { 161, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7446), null, true, 4, "Solid Babool", null, null },
                    { 162, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7463), null, true, 4, "Solid Wood", null, null },
                    { 163, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7479), null, true, 4, "Sucupira Veneer", null, null },
                    { 164, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7494), null, true, 4, "Swirl Mahogany Veneer", null, null },
                    { 165, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7511), null, true, 4, "Swirl Walnut Veneer", null, null },
                    { 166, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7527), null, true, 4, "Sycamore Veneer", null, null },
                    { 167, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7547), null, true, 4, "Tamo Ash Veneer", null, null },
                    { 168, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7588), null, true, 4, "Tamo Veneer", null, null },
                    { 169, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7605), null, true, 4, "Tiger Maple Veneer", null, null },
                    { 170, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7621), null, true, 4, "Tulip", null, null },
                    { 171, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7638), null, true, 4, "Tulip Wood", null, null },
                    { 172, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7654), null, true, 4, "Tulipifera", null, null },
                    { 173, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7669), null, true, 4, "Veneer", null, null },
                    { 174, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7685), null, true, 4, "Walnut", null, null },
                    { 175, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7701), null, true, 4, "Walnut Burl Veneer", null, null },
                    { 176, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7716), null, true, 4, "Walnut Crown Veneer", null, null },
                    { 177, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7732), null, true, 4, "Walnut Grained Veneer", null, null },
                    { 178, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7748), null, true, 4, "Walnut Veneer", null, null },
                    { 179, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7764), null, true, 4, "Waterfall Bubinga Veneer", null, null },
                    { 180, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7780), null, true, 4, "Wenge Veneer", null, null },
                    { 181, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7796), null, true, 4, "Wood", null, null },
                    { 182, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7812), null, true, 4, "Woven Cane", null, null },
                    { 183, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7827), null, true, 4, "Woven Rattan", null, null },
                    { 184, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7843), null, true, 4, "Yew Burl Veneer", null, null },
                    { 185, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7859), null, true, 4, "Yew Veneer", null, null },
                    { 186, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7875), null, true, 4, "Zebrano Veneer", null, null },
                    { 187, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7890), null, true, 5, "Acrylic", null, null },
                    { 188, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7906), null, true, 5, "Bone", null, null },
                    { 189, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7922), null, true, 5, "Buffalo Horn", null, null },
                    { 190, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7938), null, true, 5, "Cane", null, null },
                    { 191, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7955), null, true, 5, "Canvas", null, null },
                    { 192, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7971), null, true, 5, "Ceramic", null, null },
                    { 193, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8072), null, true, 5, "Composite", null, null },
                    { 194, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8089), null, true, 5, "Découpage", null, null },
                    { 195, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8105), null, true, 5, "Eggshell", null, null },
                    { 196, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8122), null, true, 5, "Faux Bone", null, null },
                    { 197, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8138), null, true, 5, "Faux Horn", null, null },
                    { 198, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8154), null, true, 5, "Faux Shagreen", null, null },
                    { 199, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8171), null, true, 5, "Felt", null, null },
                    { 200, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8187), null, true, 5, "Fiberglass", null, null },
                    { 201, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8202), null, true, 5, "Glass", null, null },
                    { 202, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8218), null, true, 5, "Horn", null, null },
                    { 203, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8234), null, true, 5, "Kalahari", null, null },
                    { 204, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8250), null, true, 5, "Komodo", null, null },
                    { 205, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8267), null, true, 5, "Lacquer", null, null },
                    { 206, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8282), null, true, 5, "Mirror", null, null },
                    { 207, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8298), null, true, 5, "Mother of Pearl", null, null },
                    { 208, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8314), null, true, 5, "Paper", null, null },
                    { 209, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8330), null, true, 5, "Penshell", null, null },
                    { 210, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8346), null, true, 5, "Rush", null, null },
                    { 211, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8362), null, true, 5, "Shagreen", null, null },
                    { 212, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8378), null, true, 5, "Shagreen Embossed Leather", null, null },
                    { 213, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8394), null, true, 5, "Velvet", null, null },
                    { 214, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8410), null, true, 5, "Zebra Dyed Cow Hide", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductOptionValues",
                columns: new[] { "Id", "ProductOptionId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Deep Black" },
                    { 2, 1, "White" },
                    { 3, 1, "Oak" },
                    { 4, 2, "36x12x40" },
                    { 5, 2, "42x16x48" },
                    { 6, 2, "48x18x52" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "ImageUrl", "IsActive", "MetaDescription", "MetaKeyword", "Name", "RoomId", "Slug", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9350), null, "", "", true, null, null, "Bookcases & Etageres", 1, "bookcases--etageres", 100, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9384), null, "", "", true, null, null, "Desks & Bureauxs", 1, "Desks--Bureauxs", 200, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9403), null, "", "", true, null, null, "Desk Chairs", 1, "desk-chairs", 300, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9421), null, "", "", true, null, null, "Round Dining Tables", 2, "round-dining-tables", 400, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9438), null, "", "", true, null, null, "Rectangular & Oval Dining Table", 2, "rectangular--oval-dining-table", 500, null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9456), null, "", "", true, null, null, "Bar Carts & Cabinets", 2, "bar-carts--cabinets", 600, null, null },
                    { 7, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9483), null, "", "", true, null, null, "Bar & Counter Stools", 2, "bar--counter-stools", 700, null, null },
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9500), null, "", "", true, null, null, "Bar & Pub Tables", 2, "bar--pub-tables", 800, null, null },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9519), null, "", "", true, null, null, "China & Curio Cabinets", 2, "china--curio-cabinets", 900, null, null },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9537), null, "", "", true, null, null, "Dining Chairs", 2, "dining-chairs", 1000, null, null },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9561), null, "", "", true, null, null, "Sideboards & Buffets", 2, "sideboards--buffets", 1100, null, null },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9578), null, "", "", true, null, null, "Free Standing Accessories", 3, "free-standing-accessories", 1200, null, null },
                    { 13, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9596), null, "", "", true, null, null, "Mirrors", 3, "mirrors", 1300, null, null },
                    { 14, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9613), null, "", "", true, null, null, "Table Top Accessories", 3, "table-top-accessories", 1400, null, null },
                    { 15, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9647), null, "", "", true, null, null, "Wall Art", 3, "wall-art", 1500, null, null },
                    { 16, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9664), null, "", "", true, null, null, "Ceiling Lighting", 4, "ceiling-lighting", 1600, null, null },
                    { 17, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9681), null, "", "", true, null, null, "Floor Lighting", 4, "floor-lighting", 1700, null, null },
                    { 18, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9699), null, "", "", true, null, null, "Table Lighting", 4, "table-lighting", 1800, null, null },
                    { 19, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9715), null, "", "", true, null, null, "Storage", 5, "storage", 1900, null, null },
                    { 20, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9742), null, "", "", true, null, null, "Beds", 5, "beds", 2000, null, null },
                    { 21, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9759), null, "", "", true, null, null, "Benches", 5, "benches", 2100, null, null },
                    { 22, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9802), null, "", "", true, null, null, "Dressers & Chests", 5, "dressers--chests", 2200, null, null },
                    { 23, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9832), null, "", "", true, null, null, "Nightstands", 5, "nightstands", 2300, null, null },
                    { 24, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9851), null, "", "", true, null, null, "Vanity Tables", 5, "vanity-tables", 2400, null, null },
                    { 25, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9868), null, "", "", true, null, null, "Media Cabinets", 6, "Media-Cabinets", 2500, null, null },
                    { 26, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9885), null, "", "", true, null, null, "Accent Chairs", 6, "accent-chairs", 2600, null, null },
                    { 27, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9918), null, "", "", true, null, null, "Accent Tables", 6, "accent-tables", 2700, null, null },
                    { 28, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9935), null, "", "", true, null, null, "Center Tables", 6, "center-tables", 2800, null, null },
                    { 29, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9952), null, "", "", true, null, null, "Cocktail Tables", 6, "cocktail-tables", 2900, null, null },
                    { 30, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9971), null, "", "", true, null, null, "Console Tables", 6, "console-tables", 3000, null, null },
                    { 31, new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9995), null, "", "", true, null, null, "Game Tables", 6, "game-tables", 3100, null, null },
                    { 32, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(13), null, "", "", true, null, null, "Ottomans & Stools", 6, "ottomans--stools", 3200, null, null },
                    { 33, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(29), null, "", "", true, null, null, "Sectionals", 6, "sectionals", 3300, null, null },
                    { 34, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(49), null, "", "", true, null, null, "Side Tables", 6, "side-tables", 3400, null, null },
                    { 35, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(76), null, "", "", true, null, null, "Sofas & Settees", 6, "sofas--settees", 3500, null, null },
                    { 36, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(93), null, "", "", true, null, null, "Storage Cabinets", 6, "storage-cabinets", 3600, null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingZones",
                columns: new[] { "Id", "Description", "Name", "RegionId" },
                values: new object[,]
                {
                    { 101, "Major export ports in Vietnam (HCM, Hai Phong)", "Vietnam Export Hub", 2 },
                    { 102, "Major import ports on US West Coast (LA, Long Beach, Seattle)", "US West Coast Freight Hub", 1 },
                    { 103, "Last-mile delivery area for Los Angeles County", "Los Angeles Metro Area", 1 },
                    { 104, "Southern provinces including Ho Chi Minh City", "Vietnam Southern Region", 2 },
                    { 105, "Northern provinces including Hanoi", "Vietnam Northern Region", 2 },
                    { 106, "Major import ports in United Kingdom", "UK Freight Hub", 3 },
                    { 107, "Last-mile delivery for London", "London Metro Area", 3 },
                    { 108, "Major export ports in China (Shenzhen, Shanghai)", "China Export Hub", 5 },
                    { 109, "Moscow and surrounding regions", "Russia Moscow Area", 6 },
                    { 110, "Jakarta and surrounding regions", "Indonesia Jakarta Area", 7 },
                    { 111, "Main island of Singapore", "Singapore Main Island", 4 }
                });

            migrationBuilder.InsertData(
                table: "GlobalShippingLanes",
                columns: new[] { "Id", "DestinationShippingZoneId", "EstimatedTransitDaysMax", "EstimatedTransitDaysMin", "Name", "OriginShippingZoneId", "PrimaryCarrierPartner", "SupportsConsolidation", "TransitMode" },
                values: new object[,]
                {
                    { 1, 102, 35, 20, "VN to US West Coast (Ocean)", 101, "Maersk", true, "Ocean" },
                    { 2, 102, 10, 5, "VN to US West Coast (Air)", 101, "FedEx Cargo", false, "Air Cargo" },
                    { 3, 106, 45, 28, "VN to UK (Ocean)", 101, "CMA CGM", true, "Ocean" },
                    { 4, 102, 30, 18, "CN to US West Coast (Ocean)", 108, "COSCO", true, "Ocean" },
                    { 5, 111, 7, 3, "VN to Singapore (Ocean)", 101, "PIL", true, "Ocean" },
                    { 6, 110, 5, 2, "Singapore to Indonesia (Ocean)", 111, "APL", true, "Ocean" },
                    { 7, 109, 25, 15, "CN to Russia (Rail Freight)", 108, "CR Express", true, "Rail" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalFeatures", "CollectionId", "CreatedAt", "CreatedBy", "DefaultImageUrl", "Depth", "Description", "ExtendedDescription", "GrossWeightKg", "GrossWeightLbs", "Height", "IsActive", "LifeStyleId", "MaxHeight", "MetaDescription", "MetaKeyword", "Name", "NetWeightKg", "NetWeightLbs", "ProductCategoryId", "ProductShippingProfileId", "QuantityMultiplier", "RoomId", "Sku", "Slug", "StyleId", "TypeId", "UpdatedBy", "UpdateddAt", "Width" },
                values: new object[,]
                {
                    { 1, "", 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9693), null, "", 162.6m, "", "", 0m, 0m, 76.2m, true, 4, 0, "", "", "Catalina Round Dining Table", 91m, 0m, 101, 201, 1, 2, "TA54027.C301", "catalina-round-dining-table-ta54027-c301", 9, 4, null, null, 162.6m },
                    { 2, "", 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9706), null, "", 71.1m, "", "", 0m, 0m, 41.9m, true, 4, 0, "", "", "Catalina Cocktail Table", 38m, 0m, 102, 202, 1, 1, "TA51059.C301", "catalina-cocktail-table-ta51059-c301", 9, 29, null, null, 122m },
                    { 3, "", 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9709), null, "", 30m, "", "", 0m, 0m, 20m, true, 4, 0, "", "", "Designer Vase", 2m, 0m, 103, 203, 1, 3, "TA84012.C306", "catalina-upholstered-california-king-bed-ta84012-c306", 9, 20, null, null, 20m }
                });

            migrationBuilder.InsertData(
                table: "ShippingRateRules",
                columns: new[] { "Id", "ApplyFloorSurcharge", "BaseRate", "CreatedAt", "CreatedBy", "Description", "DestinationShippingZoneId", "FlatSurcharge", "FreeShippingMinOrderValue", "GlobalShippingLaneId", "IsActive", "IsFreeShippingThreshold", "IsRuralAreaSurcharge", "MaxApplicableCbm", "MaxApplicableWeightKg", "MaxItemsInOrder", "MaxOrderValue", "MaxOrderWeightOrVolume", "MaxWeightKg", "MinApplicableCbm", "MinApplicableWeightKg", "MinFloorForSurcharge", "MinItemsInOrder", "MinOrderValue", "MinOrderWeightOrVolume", "MinWeightKg", "OriginShippingZoneId", "PercentageSurcharge", "ProductCategoryId", "ProductShippingProfileId", "RatePerCbm", "RatePerItem", "RatePerKg", "RuleName", "RuralAreaSurchargeAmount", "ShippingServiceLevelId", "SurchargePerFloor", "SurchargeReason", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1002, true, 250m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9356), null, null, 103, 0m, 0m, null, true, false, false, 0m, 0m, 0, 0m, 0m, 0m, 0m, 0m, 2, 0, 0m, 0m, 0m, 102, 0m, null, 201, 0m, 50m, 0m, "LA Metro White Glove Delivery - Large Furniture", 0m, 2, 25m, "Inside Delivery & Assembly", null, null },
                    { 1004, false, 0m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9362), null, null, 102, 0m, 5000m, null, true, true, false, 0m, 0m, 0, 0m, 0m, 0m, 0m, 0m, 0, 0, 0m, 0m, 0m, 101, 0m, null, null, 0m, 0m, 0m, "International Freight Free Shipping > $5000 (VN to US)", 0m, 1, 0m, null, null, null },
                    { 1005, false, 300000m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9365), null, null, 105, 0m, 0m, null, true, false, false, 5m, 0m, 0, 0m, 0m, 0m, 0.1m, 0m, 0, 0, 0m, 0m, 0m, 104, 0m, null, null, 100000m, 0m, 0m, "Domestic Freight VN South to North", 0m, 4, 0m, null, null, null },
                    { 1007, false, 100m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9371), null, null, 103, 0m, 0m, null, true, false, true, 0m, 500m, 0, 0m, 0m, 0m, 0m, 10m, 0, 0, 0m, 0m, 0m, 103, 0m, null, null, 0m, 0m, 0.5m, "Domestic US - From LA Hub (Standard)", 50m, 5, 0m, null, null, null },
                    { 1008, true, 200m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9380), null, null, 103, 0m, 0m, null, true, false, false, 0m, 0m, 0, 0m, 0m, 0m, 0m, 0m, 2, 0, 0m, 0m, 0m, 103, 0m, null, 201, 0m, 40m, 0m, "Domestic US - From LA Hub (White Glove)", 0m, 2, 20m, null, null, null },
                    { 1010, true, 100m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9385), null, null, 110, 0m, 0m, null, true, false, false, 0m, 0m, 0, 0m, 0m, 0m, 0m, 0m, 3, 0, 0m, 0m, 0m, 110, 0m, null, 201, 0m, 20m, 0m, "Domestic ID - From Jakarta (White Glove)", 0m, 6, 10m, null, null, null },
                    { 1012, false, 50m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9391), null, null, 109, 0m, 0m, null, true, false, true, 0m, 300m, 0, 0m, 0m, 0m, 0m, 5m, 0, 0, 0m, 0m, 0m, 109, 0m, null, null, 0m, 0m, 0.8m, "Domestic RU - From Moscow (Standard)", 30m, 5, 0m, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingZoneDetails",
                columns: new[] { "Id", "Description", "DetailType", "ShippingZoneId", "Value" },
                values: new object[,]
                {
                    { 1, "Los Angeles City (900xx zip codes)", 0, 103, "900" },
                    { 2, "TP.HCM", 1, 104, "Ho Chi Minh City" },
                    { 3, "Hà Nội", 1, 105, "Hanoi" },
                    { 4, "East Central London", 0, 107, "EC" },
                    { 5, "West End London", 0, 107, "W1" },
                    { 6, "Moscow and surrounding oblast", 1, 109, "Moscow Oblast" },
                    { 7, "Jakarta Province", 1, 110, "Jakarta" },
                    { 8, "All of Singapore", 2, 111, "SG" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "City", "ContactPhone", "CountryCode", "CreatedAt", "CreatedBy", "Description", "Email", "IsActive", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 ABC St", "Ho Chi Minh City", null, "VN", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9254), null, null, null, true, 10.762622, 106.660172, "Ho Chi Minh City Main Warehouse (VN)", null, 104, "Ho Chi Minh City", null, null, "70000" },
                    { 3, "789 LA Blvd", "Los Angeles", null, "US", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9262), null, null, null, true, 34.052235000000003, -118.243683, "Los Angeles Fulfillment Center (US)", null, 103, "CA", null, null, "90001" }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "LastUpdated", "MinimumStockLevel", "ProductId", "QuantityOnHand", "QuantityReserved", "UpdatedBy", "UpdateddAt", "WarehouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9805), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, 50, 10, null, null, 1 },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9808), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2, 100, 20, null, null, 1 },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9810), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 30, 5, null, null, 3 },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9812), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, 70, 15, null, null, 3 },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9814), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 15, 3, null, null, 4 },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9815), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, 40, 8, null, null, 4 },
                    { 7, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9817), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, 80, 15, null, null, 2 },
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9818), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2, 120, 25, null, null, 2 },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9819), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, 200, 50, null, null, 1 },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9821), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, 150, 30, null, null, 3 },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9822), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 10, 1, null, null, 5 },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9823), null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 25, 5, null, null, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Currency", "EffectiveDate", "ExpirationDate", "IsActive", "Price", "ProductId", "RegionId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9902), null, "USD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1800.00m, 1, 1, null, null },
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(65), null, "VND", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 38000000.00m, 1, 2, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(102), null, "GBP", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1500.00m, 1, 3, null, null },
                    { 4, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(108), null, "SGD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2500.00m, 1, 4, null, null },
                    { 5, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(113), null, "CNY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 13000.00m, 1, 5, null, null },
                    { 6, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(117), null, "RUB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 160000.00m, 1, 6, null, null },
                    { 7, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(122), null, "IDR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 28000000.00m, 1, 7, null, null },
                    { 8, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(126), null, "USD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 550.00m, 2, 1, null, null },
                    { 9, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(131), null, "VND", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 12000000.00m, 2, 2, null, null },
                    { 10, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(136), null, "GBP", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 450.00m, 2, 3, null, null },
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(158), null, "SGD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 700.00m, 2, 4, null, null },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(163), null, "CNY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3800.00m, 2, 5, null, null },
                    { 13, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(167), null, "RUB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 45000.00m, 2, 6, null, null },
                    { 14, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(172), null, "IDR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 8000000.00m, 2, 7, null, null },
                    { 15, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(176), null, "USD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 120.00m, 3, 1, null, null },
                    { 16, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(198), null, "VND", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2500000.00m, 3, 2, null, null },
                    { 17, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(202), null, "GBP", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 90.00m, 3, 3, null, null },
                    { 18, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(207), null, "SGD", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 160.00m, 3, 4, null, null },
                    { 19, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(212), null, "CNY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 800.00m, 3, 5, null, null },
                    { 20, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(216), null, "RUB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 9000.00m, 3, 6, null, null },
                    { 21, new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(221), null, "IDR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1500000.00m, 3, 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "IsActive", "PriceAdjustment", "ProductId", "Sku" },
                values: new object[,]
                {
                    { 1, false, 49.99m, 1, "BLK-36" },
                    { 2, false, 54.99m, 1, "BLK-42" },
                    { 3, false, 59.99m, 1, "WHT-36" },
                    { 4, false, 64.99m, 1, "OAK-42" },
                    { 5, false, 69.99m, 1, "OAK-52" }
                });

            migrationBuilder.InsertData(
                table: "ShippingRateRules",
                columns: new[] { "Id", "ApplyFloorSurcharge", "BaseRate", "CreatedAt", "CreatedBy", "Description", "DestinationShippingZoneId", "FlatSurcharge", "FreeShippingMinOrderValue", "GlobalShippingLaneId", "IsActive", "IsFreeShippingThreshold", "IsRuralAreaSurcharge", "MaxApplicableCbm", "MaxApplicableWeightKg", "MaxItemsInOrder", "MaxOrderValue", "MaxOrderWeightOrVolume", "MaxWeightKg", "MinApplicableCbm", "MinApplicableWeightKg", "MinFloorForSurcharge", "MinItemsInOrder", "MinOrderValue", "MinOrderWeightOrVolume", "MinWeightKg", "OriginShippingZoneId", "PercentageSurcharge", "ProductCategoryId", "ProductShippingProfileId", "RatePerCbm", "RatePerItem", "RatePerKg", "RuleName", "RuralAreaSurchargeAmount", "ShippingServiceLevelId", "SurchargePerFloor", "SurchargeReason", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1001, false, 500m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9344), null, null, 102, 50m, 0m, 1, true, false, false, 10m, 0m, 0, 4999m, 0m, 0m, 0.5m, 0m, 0, 0, 0m, 0m, 0m, 101, 0m, null, 201, 150m, 0m, 0m, "Ocean Freight VN to US - Large Furniture (Port-to-Port)", 0m, 1, 0m, "Customs Admin Fee", null, null },
                    { 1003, false, 1200m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9359), null, null, 102, 0m, 0m, 2, true, false, false, 0m, 500m, 0, 0m, 0m, 0m, 0m, 0m, 0, 0, 0m, 0m, 0m, 101, 0m, null, 201, 0m, 0m, 15m, "Air Freight VN to US - Large Furniture (Expedited)", 0m, 3, 0m, "Air Fuel Surcharge", null, null },
                    { 1006, false, 450m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9368), null, null, 102, 45m, 0m, 4, true, false, false, 10m, 0m, 0, 0m, 0m, 0m, 0.5m, 0m, 0, 0, 0m, 0m, 0m, 108, 0m, null, 201, 140m, 0m, 0m, "Ocean Freight CN to US - Large Furniture", 0m, 1, 0m, "Customs Handling CN", null, null },
                    { 1009, false, 150m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9382), null, null, 110, 0m, 0m, 6, true, false, false, 5m, 0m, 0, 0m, 0m, 0m, 0.1m, 0m, 0, 0, 0m, 0m, 0m, 111, 0m, null, 201, 50m, 0m, 0m, "Ocean Freight SG to ID", 0m, 1, 0m, null, null, null },
                    { 1011, false, 800m, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9388), null, null, 109, 100m, 0m, 7, true, false, false, 0m, 1000m, 0, 0m, 0m, 0m, 0m, 50m, 0, 0, 0m, 0m, 0m, 108, 0m, null, 201, 0m, 0m, 8m, "Rail Freight CN to Russia", 0m, 7, 0m, "Russia Customs", null, null }
                });

            migrationBuilder.InsertData(
                table: "ShippingRateTiers",
                columns: new[] { "Id", "FixedTierCost", "MaxValue", "MinValue", "RatePerUnit", "ShippingRateRuleId", "TierUnit" },
                values: new object[,]
                {
                    { 3, 0m, 100m, 10m, 0.7m, 1007, "Kg" },
                    { 4, 20m, 500m, 100.01m, 0.5m, 1007, "Kg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 1, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9638), null, "/images/blk_36_1.jpg", true, true, 1, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9641), null, "/images/blk_36_2.jpg", true, 1, 0, null, null },
                    { 3, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9642), null, "/images/blk_36_3.jpg", true, 1, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 4, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9644), null, "/images/blk_42_1.jpg", true, true, 2, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 5, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9645), null, "/images/blk_42_2.jpg", true, 2, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 6, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9646), null, "/images/wht_36_1.jpg", true, true, 3, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 7, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9647), null, "/images/wht_36_2.jpg", true, 3, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 8, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9648), null, "/images/oak_42_1.jpg", true, true, 4, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 9, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9649), null, "/images/oak_42_2.jpg", true, 4, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 10, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9650), null, "/images/oak_52_1.jpg", true, true, 5, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 11, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9651), null, "/images/oak_52_2.jpg", true, 5, 0, null, null },
                    { 12, new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9652), null, "/images/oak_52_3.jpg", true, 5, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantOptionValues",
                columns: new[] { "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 5, 2 },
                    { 2, 3 },
                    { 4, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 3, 5 },
                    { 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "ShippingRateTiers",
                columns: new[] { "Id", "FixedTierCost", "MaxValue", "MinValue", "RatePerUnit", "ShippingRateRuleId", "TierUnit" },
                values: new object[,]
                {
                    { 1, 0m, 100m, 0m, 20m, 1003, "Kg" },
                    { 2, 50m, 300m, 100.01m, 15m, 1003, "Kg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_IsActive",
                table: "Collections",
                column: "IsActive");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_Slug_IsActive",
                table: "Collections",
                columns: new[] { "Slug", "IsActive" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Description", "SortOrder", "MetaKeyword", "MetaDescription", "IsDescription", "IsLogo", "IsCarousel", "LifeStyleId" });

            migrationBuilder.CreateIndex(
                name: "IX_GlobalShippingLanes_DestinationShippingZoneId",
                table: "GlobalShippingLanes",
                column: "DestinationShippingZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalShippingLanes_OriginShippingZoneId",
                table: "GlobalShippingLanes",
                column: "OriginShippingZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_ProductId_WarehouseId",
                table: "InventoryItems",
                columns: new[] { "ProductId", "WarehouseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_WarehouseId",
                table: "InventoryItems",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeStyles_Slug_IsActive",
                table: "LifeStyles",
                columns: new[] { "Slug", "IsActive" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Description", "ImageUrl", "SortOrder", "MetaDescription", "MetaKeyword" });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialCategoryId",
                table: "Materials",
                column: "MaterialCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FulfillingWarehouseId",
                table: "Orders",
                column: "FulfillingWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCares_ProductId",
                table: "ProductCares",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFabrics_FabricCode_IsActive",
                table: "ProductFabrics",
                columns: new[] { "FabricCode", "IsActive" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFabrics_UPHFabricId",
                table: "ProductFabrics",
                column: "UPHFabricId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductVariantId",
                table: "ProductImages",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionValues_ProductOptionId",
                table: "ProductOptionValues",
                column: "ProductOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductId_RegionId_EffectiveDate",
                table: "ProductPrices",
                columns: new[] { "ProductId", "RegionId", "EffectiveDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_RegionId",
                table: "ProductPrices",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CollectionId",
                table: "Products",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LifeStyleId",
                table: "Products",
                column: "LifeStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductShippingProfileId",
                table: "Products",
                column: "ProductShippingProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RoomId",
                table: "Products",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StyleId",
                table: "Products",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_RoomId",
                table: "ProductTypes",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_Slug_IsActive",
                table: "ProductTypes",
                columns: new[] { "Slug", "IsActive" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Description", "ImageUrl", "SortOrder", "MetaDescription", "MetaKeyword" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantOptionValues_ProductOptionValueId",
                table: "ProductVariantOptionValues",
                column: "ProductOptionValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_Code",
                table: "Regions",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Slug_IsActive",
                table: "Rooms",
                columns: new[] { "Slug", "IsActive" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Description", "ImageUrl", "SortOrder", "MetaDescription", "MetaKeyword" });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_DestinationShippingZoneId",
                table: "ShippingRateRules",
                column: "DestinationShippingZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_GlobalShippingLaneId",
                table: "ShippingRateRules",
                column: "GlobalShippingLaneId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_OriginShippingZoneId_DestinationShippingZoneId_ShippingServiceLevelId_ProductShippingProfileId_IsActive",
                table: "ShippingRateRules",
                columns: new[] { "OriginShippingZoneId", "DestinationShippingZoneId", "ShippingServiceLevelId", "ProductShippingProfileId", "IsActive" });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_ProductCategoryId",
                table: "ShippingRateRules",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_ProductShippingProfileId",
                table: "ShippingRateRules",
                column: "ProductShippingProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateRules_ShippingServiceLevelId",
                table: "ShippingRateRules",
                column: "ShippingServiceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRateTiers_ShippingRateRuleId",
                table: "ShippingRateTiers",
                column: "ShippingRateRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingZoneDetails_DetailType_Value_ShippingZoneId",
                table: "ShippingZoneDetails",
                columns: new[] { "DetailType", "Value", "ShippingZoneId" });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingZoneDetails_ShippingZoneId",
                table: "ShippingZoneDetails",
                column: "ShippingZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingZones_RegionId",
                table: "ShippingZones",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_Slug_IsActive",
                table: "Styles",
                columns: new[] { "Slug", "IsActive" },
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Description", "ImageUrl", "SortOrder", "MetaDescription", "MetaKeyword" });

            migrationBuilder.CreateIndex(
                name: "IX_UPHColours_IsActive",
                table: "UPHColours",
                column: "IsActive",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Colour", "CodeHex", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_UPHContents_IsActive",
                table: "UPHContents",
                column: "IsActive",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Name", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_UPHPatterns_IsActive",
                table: "UPHPatterns",
                column: "IsActive",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "Pattern", "Patterncode" });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CountryCode_StateProvince_ZipCode",
                table: "Warehouses",
                columns: new[] { "CountryCode", "StateProvince", "ZipCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_Latitude_Longitude",
                table: "Warehouses",
                columns: new[] { "Latitude", "Longitude" });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_RegionId",
                table: "Warehouses",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_ShippingZoneId",
                table: "Warehouses",
                column: "ShippingZoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CollectionImages");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductCares");

            migrationBuilder.DropTable(
                name: "ProductFabrics");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "ProductVariantOptionValues");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ShippingRateTiers");

            migrationBuilder.DropTable(
                name: "ShippingZoneDetails");

            migrationBuilder.DropTable(
                name: "UPHColours");

            migrationBuilder.DropTable(
                name: "UPHContents");

            migrationBuilder.DropTable(
                name: "UPHPatterns");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "MaterialCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cares");

            migrationBuilder.DropTable(
                name: "UPHFabrics");

            migrationBuilder.DropTable(
                name: "ProductOptionValues");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ShippingRateRules");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "ProductOptions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "GlobalShippingLanes");

            migrationBuilder.DropTable(
                name: "ShippingServiceLevels");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "LifeStyles");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductShippingProfiles");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "ShippingZones");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
