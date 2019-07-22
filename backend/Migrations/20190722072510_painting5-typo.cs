using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class painting5typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 40L,
                column: "LanguageId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L,
                column: "LanguageId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 42L,
                column: "LanguageId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 43L,
                column: "LanguageId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 44L,
                column: "LanguageId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 45L,
                column: "LanguageId",
                value: 3L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 40L,
                column: "LanguageId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L,
                column: "LanguageId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 42L,
                column: "LanguageId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 43L,
                column: "LanguageId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 44L,
                column: "LanguageId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 45L,
                column: "LanguageId",
                value: 1L);
        }
    }
}
