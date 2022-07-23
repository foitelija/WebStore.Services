using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class SeedingNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "aperture", "Action", "action-games" },
                    { 2, "aperture", "Role-play", "role-play-games" },
                    { 3, "aperture", "Fight", "fighting-games" },
                    { 4, "aperture", "Race", "racing-games" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 16, 14, 30, 23, 331, DateTimeKind.Local).AddTicks(774), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " мультиплатформенная компьютерная игра в жанре шутера от первого лица, разработанная американской компанией Infinity Ward и изданная Activision. Игра является четвёртой в серии Call of Duty и первой в подсерии Modern Warfare; официально проект был анонсирован 26 мая 2007 года.", "https://upload.wikimedia.org/wikipedia/ru/2/29/Cod4.jpg", false, false, 19.99m, 9.99m, "Call of Duty 4: Modern Warfare" },
                    { 2, 1, new DateTime(2022, 5, 16, 14, 30, 23, 335, DateTimeKind.Local).AddTicks(3125), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2 Description", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", false, false, 29.99m, 8.19m, "Half-Life 2" },
                    { 3, 1, new DateTime(2022, 5, 16, 14, 30, 23, 335, DateTimeKind.Local).AddTicks(3152), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rockstar Games", "https://upload.wikimedia.org/wikipedia/ru/c/c8/GTAV_Official_Cover_Art.jpg", false, false, 8.99m, 7.99m, "Grand Theft Auto 5" },
                    { 6, 2, new DateTime(2022, 5, 16, 14, 30, 23, 335, DateTimeKind.Local).AddTicks(3159), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "World of Warcraft: Battle for Azeroth — седьмой дополнение для одной из самых известных MMORPG, World of Warcraft.", "https://upload.wikimedia.org/wikipedia/ru/thumb/a/ae/World_of_Warcraft_Battle_for_Azeroth_Box_Shot.jpg/800px-World_of_Warcraft_Battle_for_Azeroth_Box_Shot.jpg", false, false, 40.01m, 35.99m, "World of Warcraft: Battle for Azeroth" },
                    { 4, 3, new DateTime(2022, 5, 16, 14, 30, 23, 335, DateTimeKind.Local).AddTicks(3155), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Мультиплатформенная компьютерная игра в жанре файтинг, разработанная компанией NetherRealm Studios для игровых платформ PlayStation 4, Xbox One и Microsoft Windows.", "https://upload.wikimedia.org/wikipedia/ru/thumb/3/34/Mortal_Kombat_X.jpg/800px-Mortal_Kombat_X.jpg", false, false, 11.09m, 11.09m, "Mortal Kombat X" },
                    { 5, 4, new DateTime(2022, 5, 16, 14, 30, 23, 335, DateTimeKind.Local).AddTicks(3157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Представляем новинку революционной серии игр The Crew! Насладитесь азартом и атмосферой американских моторных состязаний в потрясающем открытом мире The Crew 2.", "https://upload.wikimedia.org/wikipedia/ru/4/42/The_Crew_2_coverart.jpg", false, false, 15.99m, 5.99m, "The Crew 2" }
                });
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
