using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Torentos.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2837), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As a massively multiplayer online game, World of Warcraft enables thousands of players from across the globe to come together online – undertaking grand quests and heroic exploits in a land of fantastic adventure", "images/worldofwarcraft.png", false, false, 5.50m, "World Of Warcraft", "images/VideoGame.png" },
                    { 5, 2, new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "After thirty years, Maverick is still pushing the envelope as a top naval aviator, but must confront ghosts of his past when he leads TOP GUN's elite graduates on a mission that demands the ultimate sacrifice from those chosen to fly it.", "images/TopGunMaverick.png", false, false, 2.50m, "Top Gun: Maverick", "images/Movie.png" },
                    { 6, 3, new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "You know the album, the one with the zipper on it. Sticky Fingers represents the best-selling Rolling Stones album of all time as it celebrated its 50th anniversary in 2021.", "images/RollingStones.png", false, false, 3.50m, "The Rolling Stones - Sticky Fingers", "images/Music.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 36, 5, 309, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 36, 5, 309, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 7, 9, 36, 5, 309, DateTimeKind.Local).AddTicks(1767));
        }
    }
}
