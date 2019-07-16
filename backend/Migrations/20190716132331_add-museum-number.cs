using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class addmuseumnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MuseumNumber",
                table: "Painting",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumNumber",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumNumber",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumNumber",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumNumber",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumNumber",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumNumber",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumNumber",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumNumber",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumNumber",
                value: 9L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MuseumNumber",
                table: "Painting");
        }
    }
}
