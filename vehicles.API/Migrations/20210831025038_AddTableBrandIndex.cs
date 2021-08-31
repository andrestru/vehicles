using Microsoft.EntityFrameworkCore.Migrations;

namespace vehicles.API.Migrations
{
    public partial class AddTableBrandIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Brands_Description",
                table: "Brands",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Brands_Description",
                table: "Brands");
        }
    }
}
