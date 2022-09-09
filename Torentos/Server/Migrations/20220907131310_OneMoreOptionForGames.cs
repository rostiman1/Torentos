using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torentos.Server.Migrations
{
    public partial class OneMoreOptionForGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[] { 1, 5, 0m, 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 16, 13, 10, 225, DateTimeKind.Local).AddTicks(6170));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1610));
        }
    }
}
