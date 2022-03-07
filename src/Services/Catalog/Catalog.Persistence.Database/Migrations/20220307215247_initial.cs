using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "descripcion 1", "nombre 1", 278m },
                    { 73, "descripcion 73", "nombre 73", 220m },
                    { 72, "descripcion 72", "nombre 72", 109m },
                    { 71, "descripcion 71", "nombre 71", 185m },
                    { 70, "descripcion 70", "nombre 70", 273m },
                    { 69, "descripcion 69", "nombre 69", 187m },
                    { 68, "descripcion 68", "nombre 68", 80m },
                    { 67, "descripcion 67", "nombre 67", 44m },
                    { 66, "descripcion 66", "nombre 66", 65m },
                    { 65, "descripcion 65", "nombre 65", 68m },
                    { 64, "descripcion 64", "nombre 64", 278m },
                    { 63, "descripcion 63", "nombre 63", 282m },
                    { 62, "descripcion 62", "nombre 62", 243m },
                    { 61, "descripcion 61", "nombre 61", 266m },
                    { 60, "descripcion 60", "nombre 60", 235m },
                    { 59, "descripcion 59", "nombre 59", 48m },
                    { 58, "descripcion 58", "nombre 58", 71m },
                    { 57, "descripcion 57", "nombre 57", 54m },
                    { 56, "descripcion 56", "nombre 56", 37m },
                    { 55, "descripcion 55", "nombre 55", 234m },
                    { 54, "descripcion 54", "nombre 54", 117m },
                    { 53, "descripcion 53", "nombre 53", 59m },
                    { 74, "descripcion 74", "nombre 74", 244m },
                    { 52, "descripcion 52", "nombre 52", 21m },
                    { 75, "descripcion 75", "nombre 75", 291m },
                    { 77, "descripcion 77", "nombre 77", 55m },
                    { 98, "descripcion 98", "nombre 98", 208m },
                    { 97, "descripcion 97", "nombre 97", 153m },
                    { 96, "descripcion 96", "nombre 96", 107m },
                    { 95, "descripcion 95", "nombre 95", 259m },
                    { 94, "descripcion 94", "nombre 94", 102m },
                    { 93, "descripcion 93", "nombre 93", 254m },
                    { 92, "descripcion 92", "nombre 92", 61m },
                    { 91, "descripcion 91", "nombre 91", 205m },
                    { 90, "descripcion 90", "nombre 90", 252m },
                    { 89, "descripcion 89", "nombre 89", 57m },
                    { 88, "descripcion 88", "nombre 88", 177m },
                    { 87, "descripcion 87", "nombre 87", 60m },
                    { 86, "descripcion 86", "nombre 86", 146m },
                    { 85, "descripcion 85", "nombre 85", 179m },
                    { 84, "descripcion 84", "nombre 84", 265m },
                    { 83, "descripcion 83", "nombre 83", 151m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "descripcion 82", "nombre 82", 123m },
                    { 81, "descripcion 81", "nombre 81", 33m },
                    { 80, "descripcion 80", "nombre 80", 169m },
                    { 79, "descripcion 79", "nombre 79", 214m },
                    { 78, "descripcion 78", "nombre 78", 170m },
                    { 76, "descripcion 76", "nombre 76", 103m },
                    { 51, "descripcion 51", "nombre 51", 259m },
                    { 50, "descripcion 50", "nombre 50", 284m },
                    { 49, "descripcion 49", "nombre 49", 23m },
                    { 22, "descripcion 22", "nombre 22", 241m },
                    { 21, "descripcion 21", "nombre 21", 238m },
                    { 20, "descripcion 20", "nombre 20", 42m },
                    { 19, "descripcion 19", "nombre 19", 169m },
                    { 18, "descripcion 18", "nombre 18", 257m },
                    { 17, "descripcion 17", "nombre 17", 111m },
                    { 16, "descripcion 16", "nombre 16", 17m },
                    { 15, "descripcion 15", "nombre 15", 232m },
                    { 14, "descripcion 14", "nombre 14", 176m },
                    { 13, "descripcion 13", "nombre 13", 71m },
                    { 12, "descripcion 12", "nombre 12", 37m },
                    { 11, "descripcion 11", "nombre 11", 183m },
                    { 10, "descripcion 10", "nombre 10", 233m },
                    { 9, "descripcion 9", "nombre 9", 117m },
                    { 8, "descripcion 8", "nombre 8", 232m },
                    { 7, "descripcion 7", "nombre 7", 118m },
                    { 6, "descripcion 6", "nombre 6", 269m },
                    { 5, "descripcion 5", "nombre 5", 15m },
                    { 4, "descripcion 4", "nombre 4", 232m },
                    { 3, "descripcion 3", "nombre 3", 71m },
                    { 2, "descripcion 2", "nombre 2", 130m },
                    { 23, "descripcion 23", "nombre 23", 77m },
                    { 24, "descripcion 24", "nombre 24", 299m },
                    { 25, "descripcion 25", "nombre 25", 185m },
                    { 26, "descripcion 26", "nombre 26", 79m },
                    { 48, "descripcion 48", "nombre 48", 180m },
                    { 47, "descripcion 47", "nombre 47", 47m },
                    { 46, "descripcion 46", "nombre 46", 16m },
                    { 45, "descripcion 45", "nombre 45", 85m },
                    { 44, "descripcion 44", "nombre 44", 207m },
                    { 43, "descripcion 43", "nombre 43", 187m },
                    { 42, "descripcion 42", "nombre 42", 135m },
                    { 41, "descripcion 41", "nombre 41", 51m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "descripcion 40", "nombre 40", 225m },
                    { 39, "descripcion 39", "nombre 39", 38m },
                    { 99, "descripcion 99", "nombre 99", 139m },
                    { 38, "descripcion 38", "nombre 38", 2m },
                    { 36, "descripcion 36", "nombre 36", 258m },
                    { 35, "descripcion 35", "nombre 35", 289m },
                    { 34, "descripcion 34", "nombre 34", 291m },
                    { 33, "descripcion 33", "nombre 33", 293m },
                    { 32, "descripcion 32", "nombre 32", 118m },
                    { 31, "descripcion 31", "nombre 31", 166m },
                    { 30, "descripcion 30", "nombre 30", 138m },
                    { 29, "descripcion 29", "nombre 29", 249m },
                    { 28, "descripcion 28", "nombre 28", 174m },
                    { 27, "descripcion 27", "nombre 27", 4m },
                    { 37, "descripcion 37", "nombre 37", 132m },
                    { 100, "descripcion 100", "nombre 100", 21m }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 112 },
                    { 73, 73, 349 },
                    { 72, 72, 99 },
                    { 71, 71, 295 },
                    { 70, 70, 114 },
                    { 69, 69, 419 },
                    { 68, 68, 303 },
                    { 67, 67, 111 },
                    { 66, 66, 167 },
                    { 65, 65, 143 },
                    { 64, 64, 290 },
                    { 63, 63, 343 },
                    { 62, 62, 417 },
                    { 61, 61, 111 },
                    { 60, 60, 340 },
                    { 59, 59, 217 },
                    { 58, 58, 455 },
                    { 57, 57, 468 },
                    { 56, 56, 289 },
                    { 55, 55, 238 },
                    { 54, 54, 431 },
                    { 53, 53, 152 },
                    { 74, 74, 283 },
                    { 52, 52, 461 },
                    { 75, 75, 89 },
                    { 77, 77, 376 },
                    { 98, 98, 156 },
                    { 97, 97, 172 },
                    { 96, 96, 482 },
                    { 95, 95, 155 },
                    { 94, 94, 172 },
                    { 93, 93, 366 },
                    { 92, 92, 423 },
                    { 91, 91, 79 },
                    { 90, 90, 289 },
                    { 89, 89, 46 },
                    { 88, 88, 416 },
                    { 87, 87, 444 },
                    { 86, 86, 133 },
                    { 85, 85, 187 },
                    { 84, 84, 104 },
                    { 83, 83, 385 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 336 },
                    { 81, 81, 90 },
                    { 80, 80, 299 },
                    { 79, 79, 83 },
                    { 78, 78, 177 },
                    { 76, 76, 363 },
                    { 51, 51, 449 },
                    { 50, 50, 405 },
                    { 49, 49, 33 },
                    { 22, 22, 323 },
                    { 21, 21, 379 },
                    { 20, 20, 489 },
                    { 19, 19, 50 },
                    { 18, 18, 362 },
                    { 17, 17, 183 },
                    { 16, 16, 174 },
                    { 15, 15, 162 },
                    { 14, 14, 497 },
                    { 13, 13, 88 },
                    { 12, 12, 459 },
                    { 11, 11, 264 },
                    { 10, 10, 238 },
                    { 9, 9, 426 },
                    { 8, 8, 352 },
                    { 7, 7, 336 },
                    { 6, 6, 400 },
                    { 5, 5, 190 },
                    { 4, 4, 293 },
                    { 3, 3, 280 },
                    { 2, 2, 290 },
                    { 23, 23, 321 },
                    { 24, 24, 324 },
                    { 25, 25, 75 },
                    { 26, 26, 349 },
                    { 48, 48, 452 },
                    { 47, 47, 258 },
                    { 46, 46, 276 },
                    { 45, 45, 240 },
                    { 44, 44, 143 },
                    { 43, 43, 446 },
                    { 42, 42, 15 },
                    { 41, 41, 400 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 267 },
                    { 39, 39, 13 },
                    { 99, 99, 0 },
                    { 38, 38, 83 },
                    { 36, 36, 48 },
                    { 35, 35, 78 },
                    { 34, 34, 285 },
                    { 33, 33, 347 },
                    { 32, 32, 96 },
                    { 31, 31, 94 },
                    { 30, 30, 136 },
                    { 29, 29, 9 },
                    { 28, 28, 418 },
                    { 27, 27, 288 },
                    { 37, 37, 378 },
                    { 100, 100, 72 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                table: "Stocks",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
