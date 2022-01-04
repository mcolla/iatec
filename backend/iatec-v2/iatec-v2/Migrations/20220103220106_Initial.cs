using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iatec_v2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true),
                    Brand = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Doors = table.Column<int>(type: "int", nullable: false),
                    Cambium = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Pneu aro 15", 256.50m, 10 },
                    { 2, "Limpador de parabrisas universal", 45.99m, 30 },
                    { 3, "Kit de carpet emborrachado", 110.60m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "id", "Brand", "Cambium", "Doors", "Fuel", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "Volkswagen", "m", 4, "f", "Gol", 2015 },
                    { 2, "Ford", "m", 2, "g", "Fiesta", 2017 },
                    { 3, "Renault", "a", 4, "a", "Duster", 2019 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
