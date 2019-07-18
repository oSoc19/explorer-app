using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class sourcelinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "TechniqueTranslation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "PaintingTranslation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "MovementTranslation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "ArtistTranslation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "TechniqueTranslation");

            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "PaintingTranslation");

            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "MovementTranslation");

            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "ArtistTranslation");
        }
    }
}
