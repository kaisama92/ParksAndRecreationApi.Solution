using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksAndRecreationApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsStatePark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsNationalPark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    County = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasBathrooms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasFamilyFriendlyBathrooms = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasPlayStructure = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Latitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Longitude = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "County", "HasBathrooms", "HasFamilyFriendlyBathrooms", "HasPlayStructure", "IsNationalPark", "IsStatePark", "Latitude", "Longitude", "ParkName" },
                values: new object[] { 1, null, false, false, false, false, true, "45.52075 N", "122.74365 W", "Willamette Stone State Heritage Site" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "County", "HasBathrooms", "HasFamilyFriendlyBathrooms", "HasPlayStructure", "IsNationalPark", "IsStatePark", "Latitude", "Longitude", "ParkName" },
                values: new object[] { 2, null, false, false, false, false, true, "45.66018 N", "122.83870 W", "Wapato Access Greenway State Park" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "County", "HasBathrooms", "HasFamilyFriendlyBathrooms", "HasPlayStructure", "IsNationalPark", "IsStatePark", "Latitude", "Longitude", "ParkName" },
                values: new object[] { 3, null, false, true, false, true, false, "45.62280 N", "122.66215 W", "Fort Vanouver National Historic Site" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
