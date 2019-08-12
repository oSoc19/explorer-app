using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class buildingStories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingStory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false),
                    BuildingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingStory_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingStory_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { 82L, 1L, "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg", 1L, "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Stadhuis FR", "style" });

            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { 83L, 2L, "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg", 2L, "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Stadhuis NL", "style" });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingStory_BuildingId",
                table: "BuildingStory",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingStory_LanguageId",
                table: "BuildingStory",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingStory");
        }
    }
}
