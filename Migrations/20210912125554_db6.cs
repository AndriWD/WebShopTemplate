using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWebShopStream.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "7cfb72f0-4ba4-4699-8a8f-bc015b89b4fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71f3410c-7947-4755-8625-a945fae010ba", "AQAAAAEAACcQAAAAEBuGISTVPTkaauSRHySzfjie/NUeva8lLNG07J9966EonnJfWnAhhjHEK7ZxNgTS2w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 55, 53, 295, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 55, 53, 295, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 55, 53, 295, DateTimeKind.Utc).AddTicks(7325));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "c56c8e22-0b1a-4f7f-9043-b782d960b1cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03da0f4c-d966-49c1-b1ca-0a040bdf01ee", "AQAAAAEAACcQAAAAEINNlMgYs8CMNeqzOoTpmWF/1o1gMkoo88cH6RThGMxhDHLgqZaU4nC/bomB5zr+tw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 54, 15, 828, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 54, 15, 828, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 12, 54, 15, 828, DateTimeKind.Utc).AddTicks(6421));
        }
    }
}
