using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AjustInTheContactsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Regions_RegionDdd",
                table: "Contacts");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Regions_RegionDdd",
                table: "Contacts",
                column: "RegionDdd",
                principalTable: "Regions",
                principalColumn: "Ddd",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Regions_RegionDdd",
                table: "Contacts");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Regions_RegionDdd",
                table: "Contacts",
                column: "RegionDdd",
                principalTable: "Regions",
                principalColumn: "Ddd");
        }
    }
}
