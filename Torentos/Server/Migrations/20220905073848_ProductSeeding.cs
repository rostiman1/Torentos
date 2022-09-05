using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torentos.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title", "Type" },
                values: new object[] { 1, new DateTime(2022, 9, 5, 10, 38, 48, 176, DateTimeKind.Local).AddTicks(4747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is League of Legends?League of Legends is a team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory.", "images/LeagueOfLegends.png", false, false, 9.99m, "League Of Legends", "images/VideoGame.png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title", "Type" },
                values: new object[] { 2, new DateTime(2022, 9, 5, 10, 38, 48, 176, DateTimeKind.Local).AddTicks(4821), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cars 2 is an animated movie that explains the life of all cars.", "images/Cars2.png", false, false, 5.40m, "Cars 2", "images/Movie.png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title", "Type" },
                values: new object[] { 3, new DateTime(2022, 9, 5, 10, 38, 48, 176, DateTimeKind.Local).AddTicks(4824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..", "images/ACDC.png", false, false, 2.30m, "AC-DC", "images/Music.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
