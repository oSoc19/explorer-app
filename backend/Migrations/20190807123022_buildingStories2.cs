using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class buildingStories2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 83L,
                column: "BuildingId",
                value: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 83L,
                column: "BuildingId",
                value: 2L);
        }
    }
}
