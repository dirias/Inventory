using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "AHJ", "Jardín" },
                    { "FRD", "Mueblería" },
                    { "LKS", "Personal" },
                    { "DEW", "Hogar" },
                    { "JTK", "Salud" },
                    { "VFA", "Video Juegos" },
                    { "CDA", "Computadoras" },
                    { "YTH", "Perfumería" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "82f5dd17-f963-4679-ac46-d7df208371d4", "932 Pallet Street, La Grange (Dutchess), NY 12540", "Main Warehouse" },
                    { "67811a3a-32be-4fce-990e-9cc69834c6d7", "4447 Dane Street, Yakima, WA 98908", "Second Warehouse" },
                    { "226edd07-6f8a-4272-b5bb-95865f9218c4", "3003 Arrowood Drive, Jacksonville, FL 32257", "Third Warehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "AHJ");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CDA");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "DEW");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "FRD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "JTK");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "LKS");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VFA");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "YTH");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "226edd07-6f8a-4272-b5bb-95865f9218c4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "67811a3a-32be-4fce-990e-9cc69834c6d7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "82f5dd17-f963-4679-ac46-d7df208371d4");
        }
    }
}
