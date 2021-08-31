using Microsoft.EntityFrameworkCore.Migrations;

namespace vehicles.API.Migrations
{
    public partial class AddTableDocumentTypeIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_documentTypes_Description",
                table: "documentTypes",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_documentTypes_Description",
                table: "documentTypes");
        }
    }
}
