using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations
{
    public partial class HotFixProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "https://i.ibb.co/s1pCNrL/action-games-24px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "https://i.ibb.co/rph11zV/rpg-games-24px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "https://i.ibb.co/tbcPJTd/boxing-games-24px.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "https://i.ibb.co/vZ6mQXF/race-games-24px.png");

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 7.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 5.19m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 5.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 4.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 0m, 25.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "https://ibb.co/xgKYBQV");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "https://ibb.co/3FbLLjn");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "https://ibb.co/8j247Lh");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "https://ibb.co/gzLwP42");

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 19.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 29.99m, 8.19m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 8.99m, 7.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 15.99m, 5.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 40.01m, 35.99m });
        }
    }
}
