﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWebShopStream.Migrations
{
    public partial class db8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A1",
                column: "ConcurrencyStamp",
                value: "3abdad22-7b77-43fd-a9fc-a2c2c393db32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80AB7036-5D4A-11E6-9903-0050569977A2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c554e887-6ca8-4b22-9a89-164cd126d568", "AQAAAAEAACcQAAAAEBpEs2jAykCLGS6gPUhm3vB6sNnCEzkiNBi2SHnj7PiYdOj3uauNvCJABAUYT3ATEQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a3"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 20, 13, 828, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a4"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 20, 13, 829, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("80ab7036-5d4a-11e6-9903-0050569977a5"),
                column: "DateAded",
                value: new DateTime(2021, 9, 12, 13, 20, 13, 829, DateTimeKind.Utc).AddTicks(2291));
        }
    }
}
