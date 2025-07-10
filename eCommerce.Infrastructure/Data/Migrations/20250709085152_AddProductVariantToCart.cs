using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductVariantToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Warehouses",
                newName: "Address2");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedDate",
                table: "Carts",
                newName: "LastModifiedDate");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Warehouses",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Warehouses",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Warehouses",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimaryWarehouseForRegion",
                table: "Warehouses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHPatterns",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHPatterns",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHFabrics",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHFabrics",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHContents",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHContents",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHColours",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHColours",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Styles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Styles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShippingZones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ShippingZones",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ShippingZones",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ShippingZones",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ShippingZones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShippingZoneDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ShippingZoneDetails",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ShippingZoneDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ShippingZoneDetails",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ShippingZoneDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShippingServiceLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ShippingServiceLevels",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ShippingServiceLevels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ShippingServiceLevels",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ShippingServiceLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ShippingRateTiers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ShippingRateTiers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ShippingRateTiers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ShippingRateTiers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ShippingRateTiers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ShippingRateRules",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ShippingRateRules",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Rooms",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Rooms",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Regions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Regions",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Regions",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "Regions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductVariants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductVariants",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductVariants",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductVariants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductTypes",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductTypes",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTranslations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductTranslations",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductTranslations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductTranslations",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductTranslations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductShippingProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductShippingProfiles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductShippingProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductShippingProfiles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductShippingProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Products",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductPrices",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductPrices",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductOptionValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductOptionValues",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductOptionValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductOptionValues",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductOptionValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductOptions",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductOptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductOptions",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductImages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductImages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductFabrics",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductFabrics",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductCategories",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductCategories",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductCares",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductCares",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Payments",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Payments",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Orders",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrderItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "OrderItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "OrderItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Materials",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Materials",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MaterialCategories",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MaterialCategories",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "LifeStyles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "LifeStyles",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Languages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Languages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "InventoryItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InventoryItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "GlobalShippingLanes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "GlobalShippingLanes",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "GlobalShippingLanes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "GlobalShippingLanes",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "GlobalShippingLanes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Coupons",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Coupons",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Collections",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Collections",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "CollectionImages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CollectionImages",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnonymousId",
                table: "Carts",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Carts",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FulfillingWarehouseId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Carts",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "Carts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CartItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CartItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CartItems",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CartItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegionCode",
                table: "CartItems",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CartItems",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "CartItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Cares",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cares",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductRegionAvailabilitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRegionAvailabilitys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRegionAvailabilitys_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRegionAvailabilitys_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 563, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8457), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8461), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8463), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8465), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8466), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8468), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8470), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "IsActive", "IsDefault", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "en", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8718), null, true, true, "English - EN", null, null },
                    { 2, "vi", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8720), null, true, false, "Vietnamese - VN", null, null },
                    { 3, "zh", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8721), null, true, false, "中文 (简体) - ZH", null, null }
                });

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9344), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9347), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9348), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8795), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8797), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8798), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8800), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8802), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8802), null, true, null, null });

            migrationBuilder.InsertData(
                table: "ProductOptionValues",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ProductOptionId", "UpdatedBy", "UpdateddAt", "Value" },
                values: new object[,]
                {
                    { 7, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8799), null, true, 1, null, null, "Walnut" },
                    { 8, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8804), null, true, 2, null, null, "180x100x75" },
                    { 9, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8809), null, true, 2, null, null, "220x100x75" }
                });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8762), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8763), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.InsertData(
                table: "ProductRegionAvailabilitys",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "CreatedAt", "CreatedBy", "IsActive", "IsAvailable", "ProductId", "RegionId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9204), null, true, false, 1, 1, null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9206), null, true, false, 1, 2, null, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9207), null, true, false, 1, 3, null, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9208), null, true, false, 1, 4, null, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9209), null, true, false, 1, 5, null, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9210), null, true, false, 1, 6, null, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9211), null, true, false, 1, 7, null, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9212), null, true, false, 2, 1, null, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9294), null, true, false, 2, 2, null, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9295), null, true, false, 2, 3, null, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9296), null, true, false, 2, 4, null, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9297), null, true, false, 3, 1, null, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9298), null, true, false, 3, 2, null, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9299), null, true, false, 3, 3, null, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9300), null, true, false, 3, 4, null, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9300), null, true, false, 3, 5, null, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9301), null, true, false, 3, 6, null, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9302), null, true, false, 3, 7, null, null }
                });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9382), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9386), null, true, "Cocktail Table (Freight/Parcel)", null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9388), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8921), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8926), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8928), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8929), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8930), null, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "PriceAdjustment", "ProductId", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8931), null, false, 79.99m, 2, "MAR-OAK-180", null, null },
                    { 7, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8932), null, false, 89.99m, 2, "MAR-OAK-220", null, null },
                    { 8, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8933), null, false, 94.99m, 2, "MAR-WAL-220", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9147), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA54027.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9157), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA51059.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9161), "https://theodorealexander.sirv.com/ProductphotoCrop/TA8/TA84012.C306_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8189), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8194), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8195), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8197), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8198), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8199), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8200), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8203), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8204), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8205), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8206), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8208), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8209), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8210), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8212), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8213), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8214), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8216), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8217), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8218), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "44dabade-8a6a-4805-851b-33eba05a5eab");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "c4ddc98b-3966-4319-89a5-5b2a3a40baf4");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8505), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8513), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8516), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8518), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8408), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8412), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8414), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8417), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8419), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8421), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8422), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8320), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8322), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8323), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8324), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8362), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8364), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8365), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8366), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8268), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8271), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8272), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8274), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8275), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8276), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8277), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8278), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8279), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8280), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8281), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 8, 51, 50, 564, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac4a0101-3e17-48af-bb70-5a00f4dc09d6", "AQAAAAIAAYagAAAAEMDOsYMdU2GkWtv0PpnKrfunlsR4I6IijZTz9iaDQaGKeOmBpMzm0I4vshinMyM03w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3be0fec2-9ae8-42fb-94ac-37fec9dfecb8", "AQAAAAIAAYagAAAAEPsjoVn78ilH9OZh9HJ5fjxe5b6XpozQSFkvUUw9R6EPw10NpXDL20MwJwL7Zw/qMw==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1000 Logistics Way", "", "Los Angeles", "US", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8559), true, 34.052199999999999, -118.2437, "US West Coast Hub", 1, null, "CA", "90001" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "50 Cong Hoa", "", "Ho Chi Minh City", "VN", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8565), true, 10.762622, 106.660172, "Vietnam Central Depot", 2, "SG", "70000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Distribution Park", "", "Birmingham", "GB", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8567), true, 52.486199999999997, -1.8904000000000001, "UK Midlands Distribution", 3, null, "ENG", "B1 1AA" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address1", "Address2", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Tuas Link", "", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8569), true, 1.3521000000000001, 103.8198, "Singapore Main Warehouse", 4, "", "638596" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "888 Logistics Road", "", "Shanghai", "CN", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8571), true, 31.230399999999999, 121.47369999999999, "China Shanghai Logistics", 5, "SH", "200000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Kremlin St", "", "Moscow", "RU", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8573), true, 55.755800000000001, 37.6173, "Russia Moscow Hub", 6, "", "101000" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address1", "Address2", "City", "ContactPhone", "CountryCode", "CreatedAt", "CreatedBy", "Description", "Email", "IsActive", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { 7, "1 Sudirman Rd", "", "Jakarta", null, "ID", new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(8575), null, null, null, true, true, -6.2088000000000001, 106.8456, "Indonesia Jakarta Depot", 7, null, "JK", null, null, "10220" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 13, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9092), null, "/images/mar_oak_180_1.jpg", true, true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 14, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9093), null, "/images/mar_oak_180_2.jpg", true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 15, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9094), null, "/images/mar_oak_220_1.jpg", true, true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 16, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9095), null, "/images/mar_oak_220_2.jpg", true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 17, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9096), null, "/images/mar_wal_220_1.jpg", true, true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 18, new DateTime(2025, 7, 9, 8, 51, 50, 565, DateTimeKind.Utc).AddTicks(9097), null, "/images/mar_wal_220_2.jpg", true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariantOptionValues",
                columns: new[] { "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 3, 6 },
                    { 8, 6 },
                    { 3, 7 },
                    { 9, 7 },
                    { 7, 8 },
                    { 9, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductVariantId",
                table: "CartItems",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRegionAvailabilitys_ProductId_RegionId",
                table: "ProductRegionAvailabilitys",
                columns: new[] { "ProductId", "RegionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRegionAvailabilitys_RegionId",
                table: "ProductRegionAvailabilitys",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ProductVariants_ProductVariantId",
                table: "CartItems",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ProductVariants_ProductVariantId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems");

            migrationBuilder.DropTable(
                name: "ProductRegionAvailabilitys");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductVariantId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "IsPrimaryWarehouseForRegion",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShippingZones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ShippingZones");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ShippingZones");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ShippingZones");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ShippingZones");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShippingZoneDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ShippingZoneDetails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ShippingZoneDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ShippingZoneDetails");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ShippingZoneDetails");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShippingServiceLevels");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ShippingServiceLevels");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ShippingServiceLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ShippingServiceLevels");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ShippingServiceLevels");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShippingRateTiers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ShippingRateTiers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ShippingRateTiers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ShippingRateTiers");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ShippingRateTiers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductShippingProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductShippingProfiles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductShippingProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductShippingProfiles");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductShippingProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductOptionValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductOptionValues");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductOptionValues");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductOptionValues");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductOptionValues");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "GlobalShippingLanes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "GlobalShippingLanes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "GlobalShippingLanes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GlobalShippingLanes");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "GlobalShippingLanes");

            migrationBuilder.DropColumn(
                name: "AnonymousId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "FulfillingWarehouseId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ProductVariantId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "RegionCode",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "Warehouses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Carts",
                newName: "LastUpdatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Warehouses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHPatterns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHPatterns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHFabrics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHFabrics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHContents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHContents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "UPHColours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UPHColours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Styles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Styles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ShippingRateRules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ShippingRateRules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductPrices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductPrices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductFabrics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductFabrics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ProductCares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductCares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "MaterialCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "MaterialCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "LifeStyles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "LifeStyles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "InventoryItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InventoryItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "CollectionImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CollectionImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Carts",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Cares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 275, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "Name",
                value: "Coffee Table (Freight/Parcel)");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9693), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9706), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9709), "" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "e2b1d49c-5d68-40c6-ad68-6538b12a3654");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "d11dae21-2338-4205-8a08-7203735d3749");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 2, 28, 46, 273, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f2baec9-3256-4456-a96f-14058e4c17a5", "AQAAAAIAAYagAAAAEPicv1lN25LRpEvgcvHegRpoA6peGQtTWYhKlGPpL7FlkALRLs6dspDD1SvVz4/o8g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a7b49c3-069c-443c-be6b-c7d4729698c0", "AQAAAAIAAYagAAAAEOcDxtgao4mEe40nI87UAvGAblTt7s+K+ALXt5BeuzCPAj5lAWlRvoWK+TEx++u69w==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CountryCode", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "123 ABC St", "Ho Chi Minh City", "VN", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9254), 10.762622, 106.660172, "Ho Chi Minh City Main Warehouse (VN)", null, 104, "Ho Chi Minh City", "70000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CountryCode", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "789 Export Zone", "Shenzhen", "CN", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9261), 22.543099000000002, 114.057868, "Shenzhen Export Hub (CN)", null, "Guangdong", "518000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CountryCode", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "789 LA Blvd", "Los Angeles", "US", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9262), 34.052235000000003, -118.243683, "Los Angeles Fulfillment Center (US)", null, 103, "CA", "90001" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 SG Trade Ln", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9265), 1.29027, 103.85195899999999, "Singapore Global Hub (SG)", null, "Singapore", "01000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CountryCode", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "2 RU Logistics Pk", "Moscow", "RU", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9266), 55.755825000000002, 37.617297999999998, "Moscow Distribution Center (RU)", null, "Moscow Oblast", "101000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CountryCode", "CreatedAt", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "3 ID Industrial Ctr", "Jakarta", "ID", new DateTime(2025, 7, 4, 2, 28, 46, 274, DateTimeKind.Utc).AddTicks(9268), -6.2087630000000003, 106.84559900000001, "Jakarta Warehouse (ID)", null, "Jakarta", "10000" });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
