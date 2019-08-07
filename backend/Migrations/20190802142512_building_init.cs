using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class building_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BuildingId",
                table: "PaintingTranslation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    MuseumCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "MuseumCode", "Year" },
                values: new object[] { 1L, "60A", 1699 });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "MuseumCode", "Year" },
                values: new object[] { 2L, "61A", 1699 });

            migrationBuilder.CreateIndex(
                name: "IX_PaintingTranslation_BuildingId",
                table: "PaintingTranslation",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaintingTranslation_Building_BuildingId",
                table: "PaintingTranslation",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaintingTranslation_Building_BuildingId",
                table: "PaintingTranslation");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropIndex(
                name: "IX_PaintingTranslation_BuildingId",
                table: "PaintingTranslation");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "PaintingTranslation");
        }
    }
}
