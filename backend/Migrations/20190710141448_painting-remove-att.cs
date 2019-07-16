using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class paintingremoveatt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Painting");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Painting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Painting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Painting",
                nullable: true);
        }
    }
}
