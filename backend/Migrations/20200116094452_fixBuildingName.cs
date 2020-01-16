using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class fixBuildingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Name",
                value: "Das Schloss Steen");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Name",
                value: "El castillo Steen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Name",
                value: "Basilika");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Name",
                value: "Basílica");
        }
    }
}
