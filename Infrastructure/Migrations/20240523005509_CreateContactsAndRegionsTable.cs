using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateContactsAndRegionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Ddd = table.Column<int>(type: "INT", nullable: false),
                    RegionName = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Ddd);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    RegionDdd = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Regions_RegionDdd",
                        column: x => x.RegionDdd,
                        principalTable: "Regions",
                        principalColumn: "Ddd");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_RegionDdd",
                table: "Contacts",
                column: "RegionDdd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
