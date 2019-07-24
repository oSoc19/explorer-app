using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class update_paintings_codes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "22A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "23A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumCode",
                value: "26A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumCode",
                value: "27A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumCode",
                value: "28A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumCode",
                value: "29A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumCode",
                value: "24A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumCode",
                value: "25A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumCode",
                value: "30A");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "22");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "23");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumCode",
                value: "26");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumCode",
                value: "27");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumCode",
                value: "28");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumCode",
                value: "29");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumCode",
                value: "24");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumCode",
                value: "25");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumCode",
                value: "30");
        }
    }
}
