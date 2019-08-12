using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class newLetterCodes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "AC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "60A");

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "61A");
        }
    }
}
