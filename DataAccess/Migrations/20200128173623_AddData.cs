using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseWherehouseId",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehouseWherehouseId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "WherehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WherehouseName",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseWherehouseId",
                table: "Storages");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseId",
                table: "Warehouses",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "Warehouses",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "WarehouseId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "79af36b7-e7cb-44c4-871c-fd1fdda2cea7", "Calle 8 con 23", "Bodega Central" },
                    { "d0c16942-bb6f-4695-b13a-31503c9f6b19", "Calle norte con occidente", "Bodega Norte" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Warehouses_WarehouseId",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Storages_WarehouseId",
                table: "Storages");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "79af36b7-e7cb-44c4-871c-fd1fdda2cea7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d0c16942-bb6f-4695-b13a-31503c9f6b19");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "Storages");

            migrationBuilder.AddColumn<string>(
                name: "WherehouseId",
                table: "Warehouses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WherehouseName",
                table: "Warehouses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseWherehouseId",
                table: "Storages",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "WherehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_WarehouseWherehouseId",
                table: "Storages",
                column: "WarehouseWherehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Warehouses_WarehouseWherehouseId",
                table: "Storages",
                column: "WarehouseWherehouseId",
                principalTable: "Warehouses",
                principalColumn: "WherehouseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
