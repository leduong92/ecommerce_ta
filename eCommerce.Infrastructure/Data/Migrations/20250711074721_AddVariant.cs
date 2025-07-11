using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Products_ProductId",
                table: "InventoryItems");

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.AddColumn<decimal>(
                name: "CustomPrice",
                table: "UPHFabrics",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustom",
                table: "UPHFabrics",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<bool>(
                name: "IsUpholstered",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                name: "Finishs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finishs", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductVariantFabrics",
                columns: table => new
                {
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantFabrics", x => new { x.ProductVariantId, x.FabricId });
                    table.ForeignKey(
                        name: "FK_ProductVariantFabrics_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariantFabrics_UPHFabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "UPHFabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantFinishs",
                columns: table => new
                {
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    FinishId = table.Column<int>(type: "int", nullable: false),
                    PriceAdjustment = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantFinishs", x => new { x.ProductVariantId, x.FinishId });
                    table.ForeignKey(
                        name: "FK_ProductVariantFinishs_Finishs_FinishId",
                        column: x => x.FinishId,
                        principalTable: "Finishs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariantFinishs_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantFabricImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantFabricImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantFabricImages_ProductVariantFabrics_ProductVariantId_FabricId",
                        columns: x => new { x.ProductVariantId, x.FabricId },
                        principalTable: "ProductVariantFabrics",
                        principalColumns: new[] { "ProductVariantId", "FabricId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantFinishImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    FinishId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UpdateddAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantFinishImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantFinishImages_ProductVariantFinishs_ProductVariantId_FinishId",
                        columns: x => new { x.ProductVariantId, x.FinishId },
                        principalTable: "ProductVariantFinishs",
                        principalColumns: new[] { "ProductVariantId", "FinishId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.InsertData(
                table: "Finishs",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "MAT-WAL", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9121), null, null, true, "Matte Walnut", null, null },
                    { 2, "GL-OAK", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9123), null, null, true, "Glossy Oak", null, null }
                });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8823), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8827), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8829), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8831), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8833), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8834), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8836), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "IsActive", "IsDefault", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, "en", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9063), null, true, true, "English - EN", null, null },
                    { 2, "vi", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9065), null, true, false, "Vietnamese - VN", null, null },
                    { 3, "zh", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9066), null, true, false, "中文 (简体) - ZH", null, null }
                });

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9788), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9791), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9792), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt", "Value" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9494), null, true, null, null, "60x30x80" });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt", "Value" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9496), null, true, null, null, "80x40x100" });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt", "Value" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9497), null, true, null, null, "100x50x120" });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9463), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 430, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.InsertData(
                table: "ProductRegionAvailabilitys",
                columns: new[] { "Id", "AvailableFrom", "AvailableTo", "CreatedAt", "CreatedBy", "IsActive", "IsAvailable", "ProductId", "RegionId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9732), null, true, false, 1, 1, null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9734), null, true, false, 1, 2, null, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9734), null, true, false, 1, 3, null, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9735), null, true, false, 1, 4, null, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9736), null, true, false, 1, 5, null, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9737), null, true, false, 1, 6, null, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9738), null, true, false, 1, 7, null, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9738), null, true, false, 2, 1, null, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9739), null, true, false, 2, 2, null, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9740), null, true, false, 2, 3, null, null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9741), null, true, false, 2, 4, null, null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9742), null, true, false, 3, 1, null, null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9743), null, true, false, 3, 2, null, null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9743), null, true, false, 3, 3, null, null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9744), null, true, false, 3, 4, null, null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9745), null, true, false, 3, 5, null, null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9748), null, true, false, 3, 6, null, null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9748), null, true, false, 3, 7, null, null }
                });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9819), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Name", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9858), null, true, "Cocktail Table (Freight/Parcel)", null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9859), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9405), null, true, "TA84011.1CIR", null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9409), null, true, "TA83011.1CIR", null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9410), null, true, "TA82011.1CIR", null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9411), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9413), null, true, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "PriceAdjustment", "ProductId", "Sku", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9414), null, true, 79.99m, 2, "MAR-OAK-180", null, null },
                    { 7, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9416), null, true, 89.99m, 2, "MAR-OAK-220", null, null },
                    { 8, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9417), null, true, 94.99m, 2, "MAR-WAL-220", null, null },
                    { 10, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9418), null, true, 99.99m, 1, "VCF1798", null, null },
                    { 20, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9420), null, true, 299.99m, 3, "6005-491", null, null },
                    { 21, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9421), null, true, 349.99m, 3, "6005-490", null, null },
                    { 22, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9423), null, true, 399.99m, 3, "6005-492", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl", "IsUpholstered" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9684), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA54027.C301_main_1.jpg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl", "IsUpholstered" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9695), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA51059.C301_main_1.jpg", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl", "IsUpholstered" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9698), "https://theodorealexander.sirv.com/ProductphotoCrop/TA8/TA84012.C306_main_1.jpg", false });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8569), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8574), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8575), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8577), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8578), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8579), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8581), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8582), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8583), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8585), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8586), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8587), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8588), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8589), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8591), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8593), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8594), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8595), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8597), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8598), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "d1916e56-87d8-432c-8148-a3a00a8e78e1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "a06ecfd0-0184-46c1-be0b-d79d53923517");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8866), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8873), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8875), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8877), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8776), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8780), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8782), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8783), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8785), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8786), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8788), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8732), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8735), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8736), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8737), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8738), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8739), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8740), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8741), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8648), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8654), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8655), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8656), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8657), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8658), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8659), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8660), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8661), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8662), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8663), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 7, 47, 20, 428, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.InsertData(
                table: "UPHFabrics",
                columns: new[] { "Id", "Application", "Category", "CategoryTrim", "CleaningCode", "Color", "ColorCode", "Content1", "Content2", "Content3", "Content4", "Content5", "Content6", "CreatedAt", "CreatedBy", "CustomPrice", "Durability", "Fabric", "Grade", "GradeTrim", "GradeVn", "Hrepeat", "ImageUrl", "InStock", "IsActive", "IsCustom", "IsEnabledOnWeb", "Name", "Pattern", "PatternCode", "Pfp", "QtyOnHand", "Rlc", "Rubs", "Sampled", "Um", "UpdatedBy", "UpdateddAt", "Vrepeat", "Width" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9163), null, null, null, "1020-01", null, null, null, null, null, false, true, false, false, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9167), null, null, null, "1020-28", null, null, null, null, null, false, true, false, false, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9168), null, 199.99m, null, "1025-01", null, null, null, null, null, false, true, true, false, null, null, null, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bad98221-bcfd-48ea-9537-b28b88e14e31", "AQAAAAIAAYagAAAAEMMCay+azg6s0zXazevRvQhq4A3lGrqHpxzXzm4ACYG5XMFlpv3fNOd2fwMlTVSGJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c22231d-6ccb-4eeb-93f9-9f2943f23f43", "AQAAAAIAAYagAAAAEAmTfd4Fr23mVXh8Np+XLsaRdkVqZP+0T+000aL/gyCGsq+Qa0QDYcXG/ylSrEoKBQ==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1000 Logistics Way", "", "Los Angeles", "US", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8910), true, 34.052199999999999, -118.2437, "US West Coast Hub", 1, null, "CA", "90001" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "50 Cong Hoa", "", "Ho Chi Minh City", "VN", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8915), true, 10.762622, 106.660172, "Vietnam Central Depot", 2, "SG", "70000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Distribution Park", "", "Birmingham", "GB", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8917), true, 52.486199999999997, -1.8904000000000001, "UK Midlands Distribution", 3, null, "ENG", "B1 1AA" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address1", "Address2", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Tuas Link", "", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8919), true, 1.3521000000000001, 103.8198, "Singapore Main Warehouse", 4, "", "638596" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "888 Logistics Road", "", "Shanghai", "CN", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8921), true, 31.230399999999999, 121.47369999999999, "China Shanghai Logistics", 5, "SH", "200000" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address1", "Address2", "City", "CountryCode", "CreatedAt", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "StateProvince", "ZipCode" },
                values: new object[] { "1 Kremlin St", "", "Moscow", "RU", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8923), true, 55.755800000000001, 37.6173, "Russia Moscow Hub", 6, "", "101000" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address1", "Address2", "City", "ContactPhone", "CountryCode", "CreatedAt", "CreatedBy", "Description", "Email", "IsActive", "IsPrimaryWarehouseForRegion", "Latitude", "Longitude", "Name", "RegionId", "ShippingZoneId", "StateProvince", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { 7, "1 Sudirman Rd", "", "Jakarta", null, "ID", new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(8925), null, null, null, true, true, -6.2088000000000001, 106.8456, "Indonesia Jakarta Depot", 7, null, "JK", null, null, "10220" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 13, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9621), null, "/images/mar_oak_180_1.jpg", true, true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 14, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9622), null, "/images/mar_oak_180_2.jpg", true, 6, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 15, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9623), null, "/images/mar_oak_220_1.jpg", true, true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 16, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9624), null, "/images/mar_oak_220_2.jpg", true, 7, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 17, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9625), null, "/images/mar_wal_220_1.jpg", true, true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 18, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9626), null, "/images/mar_wal_220_2.jpg", true, 8, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 101, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9626), null, "/images/dresser_60.jpg", true, true, 20, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 102, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9627), null, "/images/dresser_61.jpg", true, 20, 0, null, null },
                    { 103, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9628), null, "/images/dresser_62.jpg", true, 20, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 104, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9629), null, "/images/dresser_80.jpg", true, true, 21, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 105, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9630), null, "/images/dresser_100.jpg", true, 21, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "SortOrder", "UpdatedBy", "UpdateddAt" },
                values: new object[] { 106, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9631), null, "/images/dresser_200.jpg", true, true, 22, 0, null, null });

            migrationBuilder.InsertData(
                table: "ProductVariantFabrics",
                columns: new[] { "FabricId", "ProductVariantId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantFinishs",
                columns: new[] { "FinishId", "ProductVariantId", "PriceAdjustment" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantOptionValues",
                columns: new[] { "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 4, 20 },
                    { 5, 21 },
                    { 6, 22 }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantFabricImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "FabricId", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9311), null, 1, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/8-200.jpg", true, true, 1, null, null },
                    { 2, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9313), null, 1, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/9-225.jpg", true, false, 1, null, null },
                    { 3, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9315), null, 3, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/9-246.jpg", true, true, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantFinishImages",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "FinishId", "ImageUrl", "IsActive", "IsPrimary", "ProductVariantId", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9368), null, 1, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/Athenaeum.jpg", true, true, 1, null, null },
                    { 2, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9371), null, 1, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/Cadet.jpg", true, false, 1, null, null },
                    { 3, new DateTime(2025, 7, 11, 7, 47, 20, 429, DateTimeKind.Utc).AddTicks(9372), null, 2, "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/9020-72.jpg", true, true, 1, null, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantFabricImages_ProductVariantId_FabricId",
                table: "ProductVariantFabricImages",
                columns: new[] { "ProductVariantId", "FabricId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantFabrics_FabricId",
                table: "ProductVariantFabrics",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantFinishImages_ProductVariantId_FinishId",
                table: "ProductVariantFinishImages",
                columns: new[] { "ProductVariantId", "FinishId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantFinishs_FinishId",
                table: "ProductVariantFinishs",
                column: "FinishId");

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

            migrationBuilder.DropTable(
                name: "ProductVariantFabricImages");

            migrationBuilder.DropTable(
                name: "ProductVariantFinishImages");

            migrationBuilder.DropTable(
                name: "ProductVariantFabrics");

            migrationBuilder.DropTable(
                name: "ProductVariantFinishs");

            migrationBuilder.DropTable(
                name: "Finishs");

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
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "ProductVariantOptionValues",
                keyColumns: new[] { "ProductOptionValueId", "ProductVariantId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7);

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

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "IsPrimaryWarehouseForRegion",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "CustomPrice",
                table: "UPHFabrics");

            migrationBuilder.DropColumn(
                name: "IsCustom",
                table: "UPHFabrics");

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
                name: "IsUpholstered",
                table: "Products");

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
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: "36x12x40");

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: "42x16x48");

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Value",
                value: "48x18x52");

            migrationBuilder.InsertData(
                table: "ProductOptions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Color" });

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
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Sku" },
                values: new object[] { false, "BLK-36" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Sku" },
                values: new object[] { false, "BLK-42" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Sku" },
                values: new object[] { false, "WHT-36" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: false);

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

            migrationBuilder.InsertData(
                table: "ProductOptionValues",
                columns: new[] { "Id", "ProductOptionId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Deep Black" },
                    { 2, 1, "White" },
                    { 3, 1, "Oak" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariantOptionValues",
                columns: new[] { "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                });

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
