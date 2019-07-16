using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Technique");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Technique");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movement");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Movement");

            migrationBuilder.RenameColumn(
                name: "FieldTranslated",
                table: "PaintingTranslation",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "PaintingTranslation",
                newName: "Description");

            migrationBuilder.CreateTable(
                name: "MovementTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovementId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementTranslation_Movement_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TechniqueId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechniqueTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechniqueTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechniqueTranslation_Technique_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "Birthdate", "Deathdate", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { 1L, "1626-01-16", "1699-05-12", "Lucas", "Achtschellinck", "Belgian" },
                    { 2L, "1603-07-01", "1671-03-03", "Jacob I", "Van Oost", "Belgian" },
                    { 3L, "1637", "1713-09-29", "Jacob II", "Van Oost", "Belgian" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1L, "FR", "Français" });

            migrationBuilder.InsertData(
                table: "Movement",
                column: "Id",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Technique",
                column: "Id",
                value: 1L);

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name" },
                values: new object[] { 1L, "Baroque description too lazy to look for it", 1L, 1L, "Baroque" });

            migrationBuilder.InsertData(
                table: "Painting",
                columns: new[] { "Id", "AuthorId", "Height", "ImageUrl", "MovementId", "TechniqueId", "Width", "Year" },
                values: new object[] { 1L, 2L, 116f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I", 1L, 1L, 222f, 1668 });

            migrationBuilder.InsertData(
                table: "TechniqueTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "TechniqueId" },
                values: new object[] { 1L, "Too lazy again", 1L, "Peinture à l'huile", 1L });

            migrationBuilder.InsertData(
                table: "PaintingTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "PaintingId" },
                values: new object[] { 1L, "Once again again lazy", 1L, "Portrait d’un théologien et son secrétaire", 1L });

            migrationBuilder.CreateIndex(
                name: "IX_MovementTranslation_LanguageId",
                table: "MovementTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementTranslation_MovementId",
                table: "MovementTranslation",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_TechniqueTranslation_LanguageId",
                table: "TechniqueTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_TechniqueTranslation_TechniqueId",
                table: "TechniqueTranslation",
                column: "TechniqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovementTranslation");

            migrationBuilder.DropTable(
                name: "TechniqueTranslation");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PaintingTranslation",
                newName: "FieldTranslated");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PaintingTranslation",
                newName: "Content");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Technique",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Technique",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movement",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Movement",
                nullable: true);
        }
    }
}
