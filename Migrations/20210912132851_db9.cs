using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWebShopStream.Migrations
{
    public partial class db9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "71de9ac1-4b1b-46bb-b446-2ea63c810c62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7f31db5-0958-4115-a791-6742ea224f43", "AQAAAAEAACcQAAAAEPhcfAdtaUFc95FSYe029hgJDG39UlGm8VseuneZmU4H4CuAOy0w5lnYp9MlJhu4+A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 28, 49, 554, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 28, 49, 555, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 28, 49, 555, DateTimeKind.Utc).AddTicks(1839));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "7c266b12-f84a-4663-9ec6-483278174978");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f1104ce-484d-4af1-93b7-d0a626ebdf61", "AQAAAAEAACcQAAAAEJrepjQMFYNUnZ6601+clwzcmw2Hgd6uhpCFX7mjt2uIJbvzg3a20L0tmbPIZD2aPw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 25, 10, 148, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 25, 10, 148, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 25, 10, 148, DateTimeKind.Utc).AddTicks(7070));
        }
    }
}
