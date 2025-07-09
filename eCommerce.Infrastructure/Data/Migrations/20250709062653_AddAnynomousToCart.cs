using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnynomousToCart : Migration
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
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5858), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5862), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5865), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5867), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5868), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5870), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5872), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "IsActive", "IsDefault", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "en", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6130), null, true, true, "English - EN", null, null },
                    { 2, "vi", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6133), null, true, false, "Vietnamese - VN", null, null },
                    { 3, "zh", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6134), null, true, false, "中文 (简体) - ZH", null, null }
                });

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6584), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6586), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6611), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6203), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6205), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6206), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6207), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6207), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6208), null, true, null, null });

            migrationBuilder.InsertData(
                table: "ProductOptionValues",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "ProductOptionId", "UpdatedBy", "UpdateddAt", "Value" },
                values: new object[,]
                {
                    { 7, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6209), null, true, 1, null, null, "Walnut" },
                    { 8, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6210), null, true, 1, null, null, "Oak" },
                    { 9, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6211), null, true, 2, null, null, "180x100x75" },
                    { 10, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6212), null, true, 2, null, null, "220x100x75" }
                });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6174), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6176), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.InsertData(
                table: "ProductRegionAvailabilitys",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "CreatedAt", "CreatedBy", "IsActive", "IsAvailable", "ProductId", "RegionId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6523), null, true, false, 1, 1, null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6526), null, true, false, 1, 2, null, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6528), null, true, false, 1, 3, null, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6529), null, true, false, 1, 4, null, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6530), null, true, false, 1, 5, null, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6530), null, true, false, 1, 6, null, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6532), null, true, false, 1, 7, null, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6532), null, true, false, 2, 1, null, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6533), null, true, false, 2, 2, null, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6534), null, true, false, 2, 3, null, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6535), null, true, false, 2, 4, null, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6536), null, true, false, 3, 1, null, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6537), null, true, false, 3, 2, null, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6537), null, true, false, 3, 3, null, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6538), null, true, false, 3, 4, null, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6539), null, true, false, 3, 5, null, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6540), null, true, false, 3, 6, null, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6541), null, true, false, 3, 7, null, null }
                });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6643), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6647), null, true, "Cocktail Table (Freight/Parcel)", null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6649), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6245), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6249), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6250), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6251), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6252), null, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "PriceAdjustment", "ProductId", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6254), null, false, 79.99m, 2, "MAR-OAK-180", null, null },
                    { 7, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6255), null, false, 89.99m, 2, "MAR-OAK-220", null, null },
                    { 8, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6256), null, false, 94.99m, 2, "MAR-WAL-220", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6474), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA54027.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6483), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA51059.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6487), "https://theodorealexander.sirv.com/ProductphotoCrop/TA8/TA84012.C306_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5579), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5583), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5585), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5586), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5588), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5589), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5590), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5592), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5593), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5594), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5596), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5597), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5598), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5600), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5601), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5603), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5604), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5605), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5606), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5608), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "eab558de-303d-452f-9334-6e4f66d07705");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "67b5d073-398c-4622-9449-e2244df76d36");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5907), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5915), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5920), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5922), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5770), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5774), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5777), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5778), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5780), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5781), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5783), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5725), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5727), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5728), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5730), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5731), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5732), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5733), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5734), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5671), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5674), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5675), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5677), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5678), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5679), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5680), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5681), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5682), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5683), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5684), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 6, 26, 52, 80, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e189488-da52-46da-9ddd-f7311346a60b", "AQAAAAIAAYagAAAAEAjcdFRJkuphsc5NsvbiG6QDa79IFgZHKNMuXy23Q+UyZ8CuTKn+PgWo1bIrCInozw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "075a8d03-8908-4106-8850-2237ffe937ac", "AQAAAAIAAYagAAAAEOwbavD5eDcXh8DkcmKmFhTQciWqFZfMxKPKox2Fo+ccsXvjS5+UPw5J0tH1rC16Sg==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1000 Logistics Way", "", "Los Angeles", "US", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5958), true, 34.052199999999999, -118.2437, "US West Coast Hub", 1, null, "CA", "90001" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "50 Cong Hoa", "", "Ho Chi Minh City", "VN", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5966), true, 10.762622, 106.660172, "Vietnam Central Depot", 2, "SG", "70000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Distribution Park", "", "Birmingham", "GB", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5968), true, 52.486199999999997, -1.8904000000000001, "UK Midlands Distribution", 3, null, "ENG", "B1 1AA" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address1", "Address2", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Tuas Link", "", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5970), true, 1.3521000000000001, 103.8198, "Singapore Main Warehouse", 4, "", "638596" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "888 Logistics Road", "", "Shanghai", "CN", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5972), true, 31.230399999999999, 121.47369999999999, "China Shanghai Logistics", 5, "SH", "200000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Kremlin St", "", "Moscow", "RU", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5974), true, 55.755800000000001, 37.6173, "Russia Moscow Hub", 6, "", "101000" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address1", "Address2", "City", "ContactPhone", "CountryCode", "CreatedAt", "CreatedBy", "Description", "Email", "IsActive", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { 7, "1 Sudirman Rd", "", "Jakarta", null, "ID", new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(5976), null, null, null, true, true, -6.2088000000000001, 106.8456, "Indonesia Jakarta Depot", 7, null, "JK", null, null, "10220" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 13, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6412), null, "/images/mar_oak_180_1.jpg", true, true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 14, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6413), null, "/images/mar_oak_180_2.jpg", true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 15, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6414), null, "/images/mar_oak_220_1.jpg", true, true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 16, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6415), null, "/images/mar_oak_220_2.jpg", true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 17, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6416), null, "/images/mar_wal_220_1.jpg", true, true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 18, new DateTime(2025, 7, 9, 6, 26, 52, 81, DateTimeKind.Utc).AddTicks(6416), null, "/images/mar_wal_220_2.jpg", true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariantOptionValues",
                columns: new[] { "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 8, 6 },
                    { 9, 6 },
                    { 8, 7 },
                    { 10, 7 },
                    { 7, 8 },
                    { 10, 8 }
                });

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
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems");

            migrationBuilder.DropTable(
                name: "ProductRegionAvailabilitys");

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
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 10, 8 });

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
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 10);

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
