using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class buildingHtmlTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "FR Description <br> test test");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Description",
                value: "NL Description <br> test test");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "EN Description <br> test test");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Description",
                value: "DE Description <br> test test");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: "ES Description <br> test test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: null);
        }
    }
}
