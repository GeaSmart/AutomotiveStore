using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stocks",
                newSchema: "Catalog");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "Catalog");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 206m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 221m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 181m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 244m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 16m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 32m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 139m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 217m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 61m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 32m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 43m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 178m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 16m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 278m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 207m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 119m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 32m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 214m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Price",
                value: 249m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Price",
                value: 4m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Price",
                value: 181m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Price",
                value: 34m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Price",
                value: 120m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Price",
                value: 38m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Price",
                value: 125m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Price",
                value: 75m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Price",
                value: 291m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Price",
                value: 280m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Price",
                value: 118m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Price",
                value: 117m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Price",
                value: 32m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Price",
                value: 79m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Price",
                value: 107m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Price",
                value: 64m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Price",
                value: 129m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Price",
                value: 96m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Price",
                value: 271m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Price",
                value: 128m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Price",
                value: 13m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Price",
                value: 52m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Price",
                value: 264m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Price",
                value: 289m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Price",
                value: 102m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Price",
                value: 155m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Price",
                value: 211m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Price",
                value: 282m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Price",
                value: 14m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Price",
                value: 26m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Price",
                value: 19m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Price",
                value: 37m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Price",
                value: 156m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Price",
                value: 84m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Price",
                value: 136m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Price",
                value: 233m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Price",
                value: 172m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Price",
                value: 102m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Price",
                value: 143m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Price",
                value: 119m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Price",
                value: 241m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Price",
                value: 40m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Price",
                value: 158m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Price",
                value: 99m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Price",
                value: 174m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Price",
                value: 215m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Price",
                value: 12m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Price",
                value: 99m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Price",
                value: 208m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Price",
                value: 215m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Price",
                value: 79m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Price",
                value: 24m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Price",
                value: 60m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Price",
                value: 87m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Price",
                value: 236m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Price",
                value: 251m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Price",
                value: 217m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Price",
                value: 45m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Price",
                value: 19m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Price",
                value: 182m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Price",
                value: 214m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Price",
                value: 92m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Price",
                value: 278m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Price",
                value: 254m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Price",
                value: 99m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Price",
                value: 150m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Price",
                value: 260m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Price",
                value: 248m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Price",
                value: 243m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Price",
                value: 174m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Price",
                value: 191m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Price",
                value: 27m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Price",
                value: 252m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Price",
                value: 153m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Price",
                value: 273m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Price",
                value: 194m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Price",
                value: 165m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Price",
                value: 116m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Price",
                value: 186m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Price",
                value: 144m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 264);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 2,
                column: "Stock",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 3,
                column: "Stock",
                value: 211);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 301);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 104);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 156);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 155);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 8,
                column: "Stock",
                value: 432);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 9,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 356);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 185);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 12,
                column: "Stock",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 158);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 116);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 195);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 99);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 19,
                column: "Stock",
                value: 119);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 20,
                column: "Stock",
                value: 396);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 294);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 456);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 23,
                column: "Stock",
                value: 415);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 54);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 280);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 160);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 467);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 462);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 138);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 460);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 223);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 455);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 34,
                column: "Stock",
                value: 186);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 35,
                column: "Stock",
                value: 488);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 341);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 145);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 150);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 293);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 26);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 72);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 43,
                column: "Stock",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 211);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 274);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 266);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 47,
                column: "Stock",
                value: 196);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 449);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 467);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 50,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 51,
                column: "Stock",
                value: 407);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 52,
                column: "Stock",
                value: 167);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 73);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 98);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 407);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 307);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 135);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 157);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 241);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 323);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 495);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 187);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 470);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 370);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 396);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 66,
                column: "Stock",
                value: 461);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 67,
                column: "Stock",
                value: 83);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 472);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 128);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 160);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 376);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 74,
                column: "Stock",
                value: 326);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 75,
                column: "Stock",
                value: 370);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 222);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 420);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 204);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 279);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 294);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 83);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 82,
                column: "Stock",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 371);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 85,
                column: "Stock",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 293);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 150);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 357);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 278);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 90,
                column: "Stock",
                value: 180);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 91,
                column: "Stock",
                value: 206);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 92,
                column: "Stock",
                value: 488);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 409);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 184);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 297);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 96,
                column: "Stock",
                value: 338);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 102);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 165);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 314);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 313);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Stocks",
                schema: "Catalog",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Catalog",
                newName: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 278m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 130m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 71m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 232m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 15m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 269m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 118m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 232m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 117m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 233m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 183m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 37m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 71m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 176m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 232m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 17m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 111m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 257m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Price",
                value: 169m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Price",
                value: 42m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Price",
                value: 238m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Price",
                value: 241m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Price",
                value: 77m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Price",
                value: 299m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Price",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Price",
                value: 79m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Price",
                value: 4m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Price",
                value: 174m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Price",
                value: 249m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Price",
                value: 138m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Price",
                value: 166m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Price",
                value: 118m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Price",
                value: 293m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Price",
                value: 291m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Price",
                value: 289m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Price",
                value: 258m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Price",
                value: 132m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Price",
                value: 2m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Price",
                value: 38m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Price",
                value: 225m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Price",
                value: 51m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Price",
                value: 135m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Price",
                value: 207m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Price",
                value: 85m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Price",
                value: 16m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Price",
                value: 47m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Price",
                value: 180m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Price",
                value: 23m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Price",
                value: 284m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Price",
                value: 259m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Price",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Price",
                value: 59m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Price",
                value: 117m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Price",
                value: 234m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Price",
                value: 37m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Price",
                value: 54m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Price",
                value: 71m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Price",
                value: 48m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Price",
                value: 235m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Price",
                value: 266m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Price",
                value: 243m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Price",
                value: 282m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Price",
                value: 278m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Price",
                value: 68m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Price",
                value: 65m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Price",
                value: 44m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Price",
                value: 80m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Price",
                value: 273m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Price",
                value: 185m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Price",
                value: 109m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Price",
                value: 220m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Price",
                value: 244m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Price",
                value: 291m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Price",
                value: 103m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Price",
                value: 55m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Price",
                value: 170m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Price",
                value: 214m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Price",
                value: 169m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Price",
                value: 33m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Price",
                value: 123m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Price",
                value: 151m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Price",
                value: 265m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Price",
                value: 179m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Price",
                value: 146m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Price",
                value: 60m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Price",
                value: 177m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Price",
                value: 57m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Price",
                value: 252m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Price",
                value: 205m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Price",
                value: 61m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Price",
                value: 254m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Price",
                value: 102m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Price",
                value: 259m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Price",
                value: 107m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Price",
                value: 153m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Price",
                value: 208m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Price",
                value: 139m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Price",
                value: 21m);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 2,
                column: "Stock",
                value: 290);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 3,
                column: "Stock",
                value: 280);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 293);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 190);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 400);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 336);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 8,
                column: "Stock",
                value: 352);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 9,
                column: "Stock",
                value: 426);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 238);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 264);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 12,
                column: "Stock",
                value: 459);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 497);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 162);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 174);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 183);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 362);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 19,
                column: "Stock",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 20,
                column: "Stock",
                value: 489);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 379);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 323);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 23,
                column: "Stock",
                value: 321);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 324);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 349);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 288);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 418);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 136);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 347);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 34,
                column: "Stock",
                value: 285);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 35,
                column: "Stock",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 378);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 267);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 400);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 43,
                column: "Stock",
                value: 446);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 240);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 276);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 47,
                column: "Stock",
                value: 258);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 452);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 50,
                column: "Stock",
                value: 405);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 51,
                column: "Stock",
                value: 449);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 52,
                column: "Stock",
                value: 461);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 152);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 431);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 238);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 289);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 468);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 455);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 417);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 343);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 290);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 66,
                column: "Stock",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 67,
                column: "Stock",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 303);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 419);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 114);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 295);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 349);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 74,
                column: "Stock",
                value: 283);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 75,
                column: "Stock",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 363);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 376);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 177);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 82,
                column: "Stock",
                value: 336);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 385);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 85,
                column: "Stock",
                value: 187);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 133);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 444);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 416);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 90,
                column: "Stock",
                value: 289);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 91,
                column: "Stock",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 92,
                column: "Stock",
                value: 423);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 366);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 155);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 96,
                column: "Stock",
                value: 482);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 72);
        }
    }
}
