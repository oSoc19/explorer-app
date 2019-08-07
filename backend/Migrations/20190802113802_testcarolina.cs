using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class testcarolina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Barok");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Barok (stijlperiode)");
        }
    }
}
