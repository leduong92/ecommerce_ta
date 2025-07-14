using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductVariantCombineImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductVariantCombinationImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: true),
                    FinishId = table.Column<int>(type: "int", nullable: true),
                    ProductOptionValueId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantCombinationImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantCombinationImages_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 342, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.InsertData(
                table: "ProductVariantCombinationImages",
                columns: new[] { "Id", "FabricId", "FinishId", "ImageUrl", "IsPrimary", "ProductOptionValueId", "ProductVariantId" },
                values: new object[,]
                {
                    { 1, 1, 1, "/images/variant1_60_fab1020_finishMatte.jpg", true, 4, 1 },
                    { 2, 3, 2, "/images/variant1_60_fabCustom_finishGlossy.jpg", true, 4, 1 },
                    { 3, 1, 1, "/images/variant2_80_fab1020_finishMatte.jpg", true, 5, 2 }
                });

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "44f79df2-e652-4c39-b66f-73615e3825d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "f2ed1a7f-e899-4417-bdd1-b779933bcd4a");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 343, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "501e8969-4e03-4685-b0cd-d68cf850dbed", "AQAAAAIAAYagAAAAEBDGsMbiGo8En38a9D5jgfOD52Of6p/0tx0fIvbpGOLVI9lHvtIbBixre0FmMvTd0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "868a114c-f210-43bc-82a4-edc2d19c86d1", "AQAAAAIAAYagAAAAECk2ZXmA9lm28DrdJ7+uX6NWO5g3WyW60Y+UxpUy2WiNfPJz49mbJAeONZ58FyRUcQ==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantCombinationImages_ProductVariantId_FabricId_FinishId_ProductOptionValueId",
                table: "ProductVariantCombinationImages",
                columns: new[] { "ProductVariantId", "FabricId", "FinishId", "ProductOptionValueId" },
                unique: true,
                filter: "[FabricId] IS NOT NULL AND [FinishId] IS NOT NULL AND [ProductOptionValueId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariantCombinationImages");

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 909, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 911, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "46678ad9-06de-47b4-8f0a-65ef13df835f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "495c5170-bf52-4e3f-a10a-1c58529231a3");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3161dedb-f35d-41f5-bff6-64bdf64fbe1b", "AQAAAAIAAYagAAAAEEi3EBF+bq1fNyUaBTIKfubKwMzV0KglsquJRAANlaWO2qVOK4wNZnXoTYI3BoEO1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b600220-9d02-4327-a757-1d2111a35003", "AQAAAAIAAYagAAAAELoSiVoOYIOyFB8ddqqVY7riBrPTcjaiUKrhU7rzwBHW5ttMWLd4SIJHkvLKKDQjwQ==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 11, 8, 50, 5, 910, DateTimeKind.Utc).AddTicks(8783));
        }
    }
}
