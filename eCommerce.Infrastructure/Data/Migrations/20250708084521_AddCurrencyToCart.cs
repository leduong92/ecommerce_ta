using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrencyToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CartItems",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 801, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 803, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 805, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "86ca802d-ffb1-49b2-b3dc-716a1b1f850a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "fc5357f0-d806-458a-a45b-a39265a5892e");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b99d729-e087-4065-9e83-04bbfb9fccba", "AQAAAAIAAYagAAAAEHJ41L5n9F0Qj8HCFyYIsNPF4V8zyp5mUn6ErHcH0S68xTIf3NW76A/95qGCq/55hA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "499844e2-ba55-484a-b926-c70aee6d09ac", "AQAAAAIAAYagAAAAEEumz33ksE4CEWyMOOzjow30le6aTpj5OWqBa2beQLx0pfEksHqYJE1Asz9jsa20Vg==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 45, 19, 804, DateTimeKind.Utc).AddTicks(9405));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 243, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "5029ac7c-f1f0-4f0f-8f45-4a26d9bd405b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "90a105f8-72e8-459d-a7ea-62bd4a55d589");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 241, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e492ee3-dd09-4b3e-9fc7-0572e0278304", "AQAAAAIAAYagAAAAEMOEaHpe2dknU71rQZtbbaGKkLl4RLtZPFwklZ3B+WSiZLyOjpf3sZfBP7QwMPc3AQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9569d28-065b-45d9-99b9-e4f785a46f34", "AQAAAAIAAYagAAAAEIseefZdYvCznY0ucDX+O9I1JYFYbjBOHb31UzqklSr61HuSS15vSDAwBOCnhEkGpw==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 8, 8, 32, 14, 242, DateTimeKind.Utc).AddTicks(9347));
        }
    }
}
