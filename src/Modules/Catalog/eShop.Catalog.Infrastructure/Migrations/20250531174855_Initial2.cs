using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Catalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Products",
                newName: "Products");
        }
    }
}
