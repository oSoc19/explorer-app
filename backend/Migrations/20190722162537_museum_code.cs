using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class museum_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MuseumNumber",
                table: "Painting");

            migrationBuilder.AddColumn<string>(
                name: "MuseumCode",
                table: "Painting",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MuseumCode",
                table: "Painting");

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
                value: 22L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumNumber",
                value: 23L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumNumber",
                value: 26L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumNumber",
                value: 27L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumNumber",
                value: 28L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumNumber",
                value: 29L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumNumber",
                value: 24L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumNumber",
                value: 25L);

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumNumber",
                value: 30L);
        }
    }
}
