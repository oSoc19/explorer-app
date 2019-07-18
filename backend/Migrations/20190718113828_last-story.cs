using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class laststory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_ART@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_MOV@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_TECH@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_ART@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_MOV@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_TECH@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_ART@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_MOV@2x-100.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/5_TECH@2x-100.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L,
                column: "ImageUrl",
                value: "/api/images/painting-stories/");
        }
    }
}
