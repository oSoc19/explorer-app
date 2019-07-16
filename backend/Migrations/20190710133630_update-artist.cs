using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class updateartist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Artist");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Artist",
                nullable: true);
        }
    }
}
