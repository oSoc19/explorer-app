using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class ProosdijDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 31L, 7L, "<p>La prévôté est l’ancien siège de la seigneurie ecclésiastique de Saint-Donatien.</p> <p>Le bâtiment de style baroque triomphaliste a été conçu par l’architecte Cornelis Verhouve et le chanoine Frederic Hillewerve, tous deux originaires d’Anvers. Les influences anversoises sont clairement visibles dans le bâtiment.</p> <p>La prévôté fait aujourd’hui partie de la résidence officielle du gouverneur de la province de Flandre occidentale.</p>", 1L, "Prévôté de Saint-Donatien", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 32L, 7L, "<p>De proosdij is de voormalige hoofdzetel van de kerkelijke heerlijkheid Sint-Donaas.</p> <p>Het gebouw in triomfalistische barokstijl is ontworpen door architect Cornelis Verhouve en kanunnik Frederic Hillewerve, beiden afkomstig uit Antwerpen. De Antwerpse invloeden zijn duidelijk zichtbaar in het gebouw.</p> <p>De proosdij behoort vandaag tot de ambtswoning van de gouverneur van de provincie West-Vlaanderen.</p>", 2L, "Sint-Donaasproosdij", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 33L, 7L, "<p>The provostry is the former seat of the ecclesiastical glory of Saint Donatian.</p> <p>The triumphal baroque style building was designed by architect Cornelis Verhouve and canon Frederic Hillewerve, who both came from Antwerp. The Antwerp influence can clearly be seen in the building.</p> <p>Today, the provostry is part of the official residence of the Governor of the province of West Flanders.&nbsp;</p>", 3L, "Provostry of Saint-Donatian", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 34L, 7L, "<p>Die Propstei ist der ehemalige Hauptsitz des kirchlichen Herrschaftsguts „Sint-Donaas“.</p> <p>Das Gebäude im triumphalistischen Barockstil wurde vom Architekten Cornelis Verhouve und dem Kanoniker Frederic Hillewerve entworfen, die beide aus Antwerpen stammten. Das Gebäude ist deutlich von Antwerpener Stilmerkmalen geprägt.</p> <p>Die Propstei gehört gegenwärtig zur Amtswohnung des Gouverneurs der Provinz Westflandern.</p>", 4L, "Propstei Sankt-Donatian ", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 35L, 7L, "<p>El prebostazgo es la antigua sede principal del dominio eclesiástico de San Donaciano.&nbsp;</p> <p>El edificio, de estilo barroco triunfalista, fue diseñado por el arquitecto Cornelis Verhouve y por el canónigo Frederic Hillewerve, ambos procedentes de Amberes. Las influencias de Amberes pueden verse claramente en el edificio.&nbsp;</p> <p>El prebostazgo es en la actualidad la vivienda oficial del gobernador de la provincia de Flandes Occidental.&nbsp;</p>", 5L, "Prebostazgo de San Donatiano", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 35L);
        }
    }
}
