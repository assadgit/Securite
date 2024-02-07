using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sec.Market.API.Migrations
{
    public partial class azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2024, 2, 5, 23, 1, 58, 927, DateTimeKind.Local).AddTicks(1746));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreation",
                value: new DateTime(2022, 9, 3, 18, 9, 13, 0, DateTimeKind.Local).AddTicks(8485));
        }
    }
}
