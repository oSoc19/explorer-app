using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class NederlandseAanpassingenBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Text",
                value: "In de basiliek wordt het relikwie van het Heilig Bloed bewaard, dat elk jaar op Hemelvaart wordt rondgedragen in de stad.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Brugse_Vrije#Het_Landhuis_van_het_Brugse_Vrije_te_Brugge");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Stadhuis_van_Brugge");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Description",
                value: "<p>De Proosdij (1666) is de voormalige hoofdzetel van de kerkelijke heerlijkheid Sint-Donaas.</p> <p>Het gebouw in triomfalistische barokstijl is ontworpen door architect Cornelis Verhouve en kanunnik Frederic Hillewerve, beiden afkomstig uit Antwerpen. De Antwerpse invloeden zijn duidelijk zichtbaar in het gebouw.</p> <p>De proosdij behoort vandaag tot de ambtswoning van de gouverneur van de provincie West-Vlaanderen.</p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Description",
                value: "De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 178L,
                column: "Text",
                value: "In de basiliek wordt het relikwie van het Heilig Bloed bewaard, die elk jaar op Hemelvaart wordt rondgedragen in de stad.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Brugse_Vrije");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Bruges_City_Hall");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Description",
                value: "<p>De proosdij is de voormalige hoofdzetel van de kerkelijke heerlijkheid Sint-Donaas.</p> <p>Het gebouw in triomfalistische barokstijl is ontworpen door architect Cornelis Verhouve en kanunnik Frederic Hillewerve, beiden afkomstig uit Antwerpen. De Antwerpse invloeden zijn duidelijk zichtbaar in het gebouw.</p> <p>De proosdij behoort vandaag tot de ambtswoning van de gouverneur van de provincie West-Vlaanderen.</p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Description",
                value: "De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt op Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.");
        }
    }
}
