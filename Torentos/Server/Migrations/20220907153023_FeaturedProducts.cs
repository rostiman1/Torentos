using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torentos.Server.Migrations
{
    public partial class FeaturedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4786), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4829), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Featured" },
                values: new object[] { new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4831), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 18, 30, 23, 134, DateTimeKind.Local).AddTicks(4835));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

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
    }
}
