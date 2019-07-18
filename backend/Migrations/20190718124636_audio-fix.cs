using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class audiofix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PaintingId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 4L,
                column: "PaintingId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 7L,
                column: "PaintingId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PaintingId",
                value: 8L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PaintingId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 4L,
                column: "PaintingId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 7L,
                column: "PaintingId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "PaintingAudio",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PaintingId",
                value: 1L);
        }
    }
}
