using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torentos.Server.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Games", "games" },
                    { 2, "Movies", "movies" },
                    { 3, "Music", "music" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Blu-ray" },
                    { 2, "VHS" },
                    { 3, "MP3" },
                    { 4, "M4A" },
                    { 5, "Playstation" },
                    { 6, "PC" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is League of Legends?League of Legends is a team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory.", "images/LeagueOfLegends.png", false, false, 0m, "League Of Legends", null },
                    { 2, 2, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1600), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cars 2 is an animated movie that explains the life of all cars.", "images/Cars2.png", false, false, 0m, "Cars 2", null },
                    { 3, 3, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1603), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..", "images/ACDC.png", false, false, 0m, "AC-DC", null },
                    { 4, 1, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As a massively multiplayer online game, World of Warcraft enables thousands of players from across the globe to come together online – undertaking grand quests and heroic exploits in a land of fantastic adventure", "images/worldofwarcraft.png", false, false, 0m, "World Of Warcraft", null },
                    { 5, 2, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "After thirty years, Maverick is still pushing the envelope as a top naval aviator, but must confront ghosts of his past when he leads TOP GUN's elite graduates on a mission that demands the ultimate sacrifice from those chosen to fly it.", "images/TopGunMaverick.png", false, false, 0m, "Top Gun: Maverick", null },
                    { 6, 3, new DateTime(2022, 9, 7, 15, 46, 50, 982, DateTimeKind.Local).AddTicks(1610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "You know the album, the one with the zipper on it. Sticky Fingers represents the best-selling Rolling Stones album of all time as it celebrated its 50th anniversary in 2021.", "images/RollingStones.png", false, false, 0m, "The Rolling Stones - Sticky Fingers", null }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 6, 0m, 15m },
                    { 2, 1, 0m, 40m },
                    { 3, 6, 0m, 0.370m },
                    { 4, 6, 0m, 60m },
                    { 5, 2, 0m, 2m },
                    { 6, 4, 0m, 0.248m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
