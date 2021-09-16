using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWebShopStream.Migrations
{
    public partial class db4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "52c52ebe-362a-4168-9d84-a3b586cb4983");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8012f46-35b6-422a-80e1-2a663b6d276e", "AQAAAAEAACcQAAAAEKEffKZOc5VJiM0NtdYV5co43mzRx5xch8GNlvUIVckgTFaMmG476sgUc3r5QFw5BA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 51, 40, 888, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 51, 40, 889, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 51, 40, 889, DateTimeKind.Utc).AddTicks(1224));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "ea0c7bef-4ae1-4ce4-b925-85ccd1faba40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d347776f-5701-4e92-8c63-29f337539641", "AQAAAAEAACcQAAAAEFfEx2SKMjsqhF8wcJL3IG0bz3nslQcwfhwnAKHPLVycao0U5F4jVYRcsZ0PBJQWEw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 41, 5, 632, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 41, 5, 632, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 41, 5, 632, DateTimeKind.Utc).AddTicks(8342));
        }
    }
}
