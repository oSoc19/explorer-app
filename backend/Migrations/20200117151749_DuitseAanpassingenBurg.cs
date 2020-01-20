using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class DuitseAanpassingenBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SourceLink",
                value: "https://rkd.nl/en/explore/artists/63327");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Text",
                value: "Die goldenen Kronen auf der Schornsteine verweisen auf eine Äußerung von König Karl VII. von Frankreich (1403–1461).");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Rathaus_von_Br%C3%BCgge");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Het_Steen_(Br%C3%BCgge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "<p>Die Propstei (1666) ist der ehemalige Hauptsitz des kirchlichen Herrschaftsguts „Sankt Donatus“.</p> <p>Das Gebäude im triumphalistischen Barockstil wurde vom Architekten Cornelis Verhouve und dem Kanoniker Frederic Hillewerve entworfen, die beide aus Antwerpen stammten. Das Gebäude ist deutlich von Antwerpener Stilmerkmalen geprägt.</p> <p>Die Propstei gehört gegenwärtig zur Amtswohnung des Gouverneurs der Provinz Westflandern.</p>", "https://de.wikipedia.org/wiki/Propstei_des_Hl._Donatian_(Br%C3%BCgge)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SourceLink",
                value: "https://rkd.nl/en/explore/artists/63328");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 165L,
                column: "Text",
                value: "Die goldenen Kronen auf der Schornsteine verweisen auf ein Urteil von König Karl VII. von Frankreich (1403–1461).");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Bruges_City_Hall");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Draft:Het_Steen_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "<p>Die Propstei ist der ehemalige Hauptsitz des kirchlichen Herrschaftsguts „Sint-Donaas“.</p> <p>Das Gebäude im triumphalistischen Barockstil wurde vom Architekten Cornelis Verhouve und dem Kanoniker Frederic Hillewerve entworfen, die beide aus Antwerpen stammten. Das Gebäude ist deutlich von Antwerpener Stilmerkmalen geprägt.</p> <p>Die Propstei gehört gegenwärtig zur Amtswohnung des Gouverneurs der Provinz Westflandern.</p>", "https://en.wikipedia.org/wiki/Provostry_of_St._Donatian" });
        }
    }
}
