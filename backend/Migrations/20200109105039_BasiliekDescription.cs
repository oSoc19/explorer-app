using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class BasiliekDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 21L, 5L, "<p><strong>1134-1149</strong> <br>Construction d’une double chapelle romane pour les comtes de Flandre qui séjournent dans le « Het Steen » adjacent : la chapelle Saint-Basile inférieure et, plus tard, la chapelle du Saint-Sang supérieure. </p> <p><strong>13<sup>e</sup> siècle</strong> <br>La relique du Saint-Sang est conservée dans la chapelle supérieure. </p> <p><strong>15<sup>e</sup> siècle</strong> <br>Restauration de la chapelle supérieure dans un style gothique. </p> <p><strong>1528-1532</strong> <br>Construction d’un escalier de style gothique tardif pour accéder à la chapelle du Saint-Sang. </p> <p><strong>1819-1839</strong> <br>Reconstruction et restauration des chapelles avec la dévastation et le déclin sous la domination française. </p> <p><strong>1923</strong> <br>Élévation de la chapelle du Saint-Sang au rang de basilique. </p>", 1L, "Basilique", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 22L, 5L, "<p><strong>1134-1149</strong> <br>bouw van een romaanse dubbelkappel voor de graven van Vlaanderen, die verblijven in het naastgelegen Steen: onderaan de Sint-Basiliuskapel, bovenaan de latere Heilig-Bloedkapel </p> <p><strong>13de eeuw</strong> <br>de relikwie van het Heilig Bloed wordt in de bovenkapel ondergebracht </p> <p><strong>15de eeuw</strong> <br>restauratie van de bovenkapel in gotische stijl </p> <p><strong>1528-1532</strong> <br>bouw van een laatgotisch trappenhuis als toegang tot de Heilig-Bloedkapel </p> <p><strong>1819-1839</strong> <br>heropbouw en restauratie van de kapellen na verwoesting en verval onder de Franse overheersing </p> <p><strong>1923</strong> <br>verheffing van de Heilig-Bloedkapel tot basiliek </p>", 2L, "Basiliek", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 23L, 5L, "<p><strong>1134-1149</strong> <br>construction of a Romanesque double chapel for the Counts of Flanders, who lived in the nearby Steen Castle, with the lower Saint Basil’s Chapel and above it the upper Chapel of the Holy Blood, which was built later. </p> <p><strong>13th century</strong> <br>the relic of the Holy Blood is housed in the upper chapel </p> <p><strong>15th century</strong> <br>restoration of the upper chapel in Gothic style </p> <p><strong>1528-1532</strong> <br>construction of late Gothic staircase to access the Chapel of the Holy Blood </p> <p><strong>1819-1839</strong> <br>reconstruction and restoration of the chapels following destruction and decay under French rule </p> <p><strong>1923</strong> <br>elevation of the Chapel of the Holy Blood to a basilica </p>", 3L, "Basilic", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 24L, 5L, "<p><strong>1134–1149</strong> <br>Bau einer romanischen Doppelkirche für die Grafen von Flandern, die im benachbarten „Steen“ wohnen: Unten befindet sich die Sankt Basiliuskapelle, oben die spätere Heilig-Blut-Kapelle. </p> <p><strong>13. Jahrhundert</strong> <br>Die Reliquie des Heiligen Blutes wird in der Oberkirche untergebracht. </p> <p><strong>15. Jahrhundert</strong> <br>Restaurierung der Oberkirche im gotischen Stil. </p> <p><strong>1528–1532</strong> <br>Bau eines spätgotischen Treppenhauses als Zugang zur Heilig-Blut-Kapelle. </p> <p><strong>1819–1839</strong> <br>Wiederaufbau und Restaurierung der Kapellen nach der Verwüstung und dem Verfall unter der französischen Verwaltung. </p> <p><strong>1923</strong> <br>Erhebung der Heilig-Blut-Kapelle zur Basilika. </p>", 4L, "Basilika", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 25L, 5L, "<p><strong>1134-1149</strong> <br>Construcción de una capilla doble románica para los condes de Flandes, que se hospedaban en el edificio conjunto llamado <em>Steen</em>: en la parte inferior de la Capilla de San Basilio, en la parte superior de la posterior capilla de la Santa Sangre</p> <p><strong>Siglo XIII</strong> <br>La reliquia de la Santa Sangre se conserva en la capilla superior &nbsp; </p> <p><strong>Siglo XV</strong> <br>Restauración de la capilla superior en estilo gótico </p> <p><strong>1528-1532</strong> <br>Construcción de una caja de escalera del gótico tardío como acceso a la capilla de la Santa Sangre </p> <p><strong>1819-1839</strong> <br>Reconstrucción y restauración de las capillas tras su destrucción y ruina bajo el dominio francés </p> <p><strong>1923</strong> <br>Elevación a basílica de la capilla de la Santa Sangre </p>", 5L, "Basílica", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 25L);
        }
    }
}
