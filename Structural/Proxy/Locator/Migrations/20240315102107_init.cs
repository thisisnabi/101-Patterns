using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thisisnabi.DesignPattern.Structural.Proxy.Locator.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "locator");

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "locator",
                columns: table => new
                {
                    IP = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ContinentName = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CountryName = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    State = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: false),
                    City = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: false),
                    CallingCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.IP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations",
                schema: "locator");
        }
    }
}
