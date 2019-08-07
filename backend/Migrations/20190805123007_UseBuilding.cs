using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class UseBuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaintingTranslation_Building_BuildingId",
                table: "PaintingTranslation");

            migrationBuilder.DropIndex(
                name: "IX_PaintingTranslation_BuildingId",
                table: "PaintingTranslation");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "PaintingTranslation");

            migrationBuilder.AddColumn<long>(
                name: "UseId",
                table: "Building",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "BuildingTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuildingId = table.Column<long>(nullable: false),
                    LanguageId = table.Column<long>(nullable: false),
                    SourceLink = table.Column<string>(nullable: true),
                    BuildingId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingTranslation_Painting_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Painting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingTranslation_Building_BuildingId1",
                        column: x => x.BuildingId1,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Use",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Use", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UseTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UseId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false),
                    SourceLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UseTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UseTranslation_Use_UseId",
                        column: x => x.UseId,
                        principalTable: "Use",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Use",
                column: "Id",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UseId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UseId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "UseTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "SourceLink", "UseId" },
                values: new object[,]
                {
                    { 1L, "FR", 1L, "Hôtel de Ville de Bruges", "https://fr.wikipedia.org/wiki/Baroque", 1L },
                    { 2L, "NL", 2L, "Stadhuis van Brugge", "https://nl.wikipedia.org/wiki/Barok_(stijlperiode)", 1L },
                    { 3L, "EN", 3L, "Town Hall of Bruges", "https://en.wikipedia.org/wiki/Baroque", 1L },
                    { 4L, "DE", 4L, "Rathaus von Brügge", "https://de.wikipedia.org/wiki/Barock", 1L },
                    { 5L, "ES", 5L, "Ayuntamiento de Brujas", "https://es.wikipedia.org/wiki/Barroco", 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_UseId",
                table: "Building",
                column: "UseId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTranslation_BuildingId",
                table: "BuildingTranslation",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTranslation_BuildingId1",
                table: "BuildingTranslation",
                column: "BuildingId1");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTranslation_LanguageId",
                table: "BuildingTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UseTranslation_LanguageId",
                table: "UseTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UseTranslation_UseId",
                table: "UseTranslation",
                column: "UseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Use_UseId",
                table: "Building",
                column: "UseId",
                principalTable: "Use",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Building_Use_UseId",
                table: "Building");

            migrationBuilder.DropTable(
                name: "BuildingTranslation");

            migrationBuilder.DropTable(
                name: "UseTranslation");

            migrationBuilder.DropTable(
                name: "Use");

            migrationBuilder.DropIndex(
                name: "IX_Building_UseId",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "UseId",
                table: "Building");

            migrationBuilder.AddColumn<long>(
                name: "BuildingId",
                table: "PaintingTranslation",
                nullable: true);

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
    }
}
