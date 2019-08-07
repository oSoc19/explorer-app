using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class TranslationBuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 1L, 1L, null, 1L, "Hôtel de Ville de Bruges", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 2L, 1L, null, 2L, "Stadhuis van Brugge", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 3L, 1L, null, 3L, "Town Hall of Bruges", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 4L, 1L, null, 4L, "Rathaus von Brügge", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 5L, 1L, null, 5L, "Ayuntamiento de Brujas", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
