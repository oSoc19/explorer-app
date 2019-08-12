using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class letterCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EndYear",
                table: "Use",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "Use",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Year",
                value: 1400);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Use",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndYear", "StartYear" },
                values: new object[] { -1, 1400 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndYear",
                table: "Use");

            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "Use");

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Year",
                value: 1699);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "10A");
        }
    }
}
