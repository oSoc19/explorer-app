using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class toevoegenNLJacobOostJongere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId", "SourceLink" },
                values: new object[] { 30L, 3L, "Jacob II van Oost of Jacob van Oost de Jongere (Brugge, 1639 - Brugge, 29 september 1713) was een Vlaams barokschilder. Hij was de zoon van de Brugse stadsschilder Jacob I van Oost (1603-1671). Zijn broer Willem van Oost (1639-1713) was eveneens kunstschilder. De H. Carolus Borromeus bidt voor het einde van de pest (1668). Omstreeks 1660 vertrok Jacob II naar Parijs. Daarna bracht hij enkele jaren door in Rome. In 1668 vestigde hij zich in Rijsel, waar hij twee jaar later trouwde met Marie Bourgeois. Hun zoon Dominique (1677-1738) werd net als zijn vader kunstschilder in Rijsel. In 1703 keerde Jacob II definitief terug naar zijn geboortestad Brugge. Hij overleed er vijf jaar later. Hij is vooral bekend als schilder van portretten en genretaferelen. Verschillende van zijn werken zijn te bezichtigen in het Groeningemuseum in Brugge en de Sint-Mauritiuskerk in Rijsel. ", 2L, "https://nl.wikipedia.org/wiki/Jacob_II_van_Oost" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 30L);
        }
    }
}
