using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSizeFabricFinishToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FabricId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinishId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Cares",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "CollectionImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Collections",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 782, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Finishs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "GlobalShippingLanes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "InventoryItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "LifeStyles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "ProductOptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "ProductOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ProductPrices",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ProductRegionAvailabilitys",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ProductShippingProfiles",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "ProductVariantFabricImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ProductVariantFinishImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Sku" },
                values: new object[] { new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9859), "TA83011.1CIS" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Sku" },
                values: new object[] { new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9860), "TA82011.1CIT" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 785, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                column: "ConcurrencyStamp",
                value: "fc01f27c-826e-4f4c-8079-7e758998d06d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                column: "ConcurrencyStamp",
                value: "e7d01870-2513-4cc0-866c-eb83ee9d6c80");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1001,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ShippingRateRules",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "ShippingRateTiers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ShippingServiceLevels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ShippingZoneDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ShippingZones",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 783, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "UPHFabrics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c9ce7f5-3f95-4684-9ce9-5a9970823dcf", "AQAAAAIAAYagAAAAEJXY3XgG3DnYsw0DLos0hIV0U2LUGkDKmcZCBDuwC6RYcFTuJ9IEh7sJZA146xtI6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4bd7-64c7-4b4c-8de8-924a35223ed0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a09f38c2-eca2-4e39-ba17-fbb85285b504", "AQAAAAIAAYagAAAAELquowe2RSQxtKpUOwqX0vHKFOShDDFPx71KofebSVslgu4J8bYHw6c4Dc9EzRENig==" });

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 7, 14, 2, 21, 39, 784, DateTimeKind.Utc).AddTicks(9262));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FabricId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "FinishId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "CartItems");

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
                columns: new[] { "CreatedAt", "Sku" },
                values: new object[] { new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6778), "TA83011.1CIR" });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Sku" },
                values: new object[] { new DateTime(2025, 7, 14, 1, 38, 35, 344, DateTimeKind.Utc).AddTicks(6780), "TA82011.1CIR" });

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
        }
    }
}
