using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnynomousToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Carts");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductRegionAvailabilitys",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductRegionAvailabilitys",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductRegionAvailabilitys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ProductRegionAvailabilitys",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "ProductRegionAvailabilitys",
                type: "datetime2",
                nullable: true);

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
                type: "nvarchar(max)",
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
                type: "nvarchar(max)",
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

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 897, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2870), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2877), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2879), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2880), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2882), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2884), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2885), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3699), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3702), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3704), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3335), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3337), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3338), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3338), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3341), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3342), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3267), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3306), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3606), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3608), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3609), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3610), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3611), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3612), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3613), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3614), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3614), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3615), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3652), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3653), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3654), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3654), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3655), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3656), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3657), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3658), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3731), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3735), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3736), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3380), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3383), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3385), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3386), null, null, null });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3387), null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3549), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA54027.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3559), "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA51059.C301_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3564), "https://theodorealexander.sirv.com/ProductphotoCrop/TA8/TA84012.C306_main_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1899), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1904), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1906), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1907), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1909), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1910), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1911), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1912), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1914), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1915), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1916), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1917), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1919), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1920), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1921), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1922), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1924), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1925), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1926), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1928), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "1e41d6d6-cb90-4387-8488-bb43a7e91a04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "c00a133f-783c-40f1-a6e9-2c6c0592b00c");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2924), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2933), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2937), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2939), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2793), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2799), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2802), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2803), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2805), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2806), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2808), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2606), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2611), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2612), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2613), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2615), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2616), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2617), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2618), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1988), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(1990), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2364), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2379), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2380), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2381), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2382), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2383), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2384), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2385), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "CreatedBy", "IsActive", "UpdatedBy", "UpdateddAt" },
                values: new object[] { new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2385), null, true, null, null });

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 898, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "891a2b24-ea50-480e-82e8-04ad8a4adc10", "AQAAAAIAAYagAAAAEAUX4qD/dzmvUJfb/GoO8SF89T11+JwvgcAYRX6vn3/+l3i6Zh4CBk6TxZ11VLI2jA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71df2321-a977-4fcd-abb8-16c69b6cae20", "AQAAAAIAAYagAAAAEFNZWNebPQ3fdGAQZnkCha97dmYWFVIYVt34ILVCu1weZqOAm8ptVbCIhTNW7G1Zkw==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 9, 4, 18, 19, 899, DateTimeKind.Utc).AddTicks(3083));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "ProductRegionAvailabilitys");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductRegionAvailabilitys");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductRegionAvailabilitys");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductRegionAvailabilitys");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "ProductRegionAvailabilitys");

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
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 712, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1165), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1175), "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DefaultImageUrl" },
                values: new object[] { new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(1178), "" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "f9b54557-3e85-48f6-95b8-719b9f054562");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "922a7981-3ae5-4ccc-8aa5-8a31c83d4eeb");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 713, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec379ed5-c9dc-4a73-9bb1-5668bdcd59ec", "AQAAAAIAAYagAAAAENOiIEzYbqWgzhFGNGfTIoWSsjQBQlT/epO8y19iHU45m/uWXKivBnS2wgwpvZF2cw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96dd1fc2-3924-4d6b-b33f-462c2678c2b8", "AQAAAAIAAYagAAAAEANhYoMF/QcCDRFFEwOKAP85QwnPmZVWkIEv87gVIqUn8u7FgGF/TkhMerUqGNh2IQ==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 4, 6, 32, 41, 714, DateTimeKind.Utc).AddTicks(633));
        }
    }
}
