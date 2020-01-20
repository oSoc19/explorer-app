using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class finalDatabaseFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SourceLink",
                value: "https://rkd.nl/en/explore/artists/63327");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "<p><strong>11th century</strong><br>'Love' building, the residence of the counts of Flanders</p><p><strong>15th century</strong><br>the government of the Franc of Bruges (the area of countryside surrounding Bruges) moved from Steen Castle (which was on the opposite side) to this location.</p><p><strong>1520-1525</strong><br>construction of an aldermen’s room with monumental fireplace</p><p><strong>1528-1532</strong><br>construction of an arched gallery</p><p><strong>17th century</strong><br>further extensions including a chapel and orphanage</p><p><strong>1722-1727</strong><br>renovations in the classical style</p><p><strong>1794</strong><br>the manor became a court of justice</p><p><strong>1984</strong><br>came into use by the city administration</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Description",
                value: "<p><strong>1280</strong> <br>Tras un incendio en el campanario de Belfort de la plaza de <em>Markt</em>, los escabinos se instalan en el <em>ghyselhuus</em>, la antigua cárcel condal &nbsp;</p> <p><strong>1376</strong> <br>El conde Luis II manda derribar el <em>ghyselhuus</em> para reemplazarlo por una verdadera <em>scepenhuus</em> (casa escabinal), diseñada por Jan Roegiers</p> <p><strong>1887</strong> <br>Un incendio devasta el interior </p> <p><strong>1895-1905</strong> <br>Louis Delacenserie y Jean-Baptiste de Béthune renuevan el interior en estilo neogótico </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Description",
                value: "<p><strong>1088</strong> <br>Le bâtiment est mentionné pour la première fois comme résidence des comtes de Flandre. </p> <p><strong>12<sup>e</sup> siècle</strong> <br>Les comtes quittent le bâtiment et s’installent dans le « Love » situé de l’autre côté de la place du Bourg (l’actuelle Maison du Franc de Bruges). Le « Steen » devient alors une prison. </p> <p><strong>1689</strong> <br>Le bâtiment brûle en grande partie. </p> <p><strong>1751</strong> <br>La ville de Bruges devient propriétaire du bâtiment et le fait démolir en 1784. </p> <p><strong>1851</strong> <br>Une ferronnerie s’installe à cet endroit. </p> <p><strong>1931</strong> <br>Construction d’un bâtiment avec trois pignons à gradins dans un style néogothique (aujourd’hui Brasserie Tompouce). </p> <p><strong>1977</strong> <br>Construction de la galerie commerciale Ter Steeghere. </p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Description",
                value: "<p><strong>Romaans</strong></p> <p>De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.</p> <p><strong>Gotisch</strong></p> <p>Gotische architectuur ontstond in het 12<sup>de</sup>-eeuwse Frankrijk. Aanvankelijk werd de bouwstijl vooral toegepast voor kerkgebouwen. Vanaf de late 15de eeuw inspireerden de gotische kathedralen ook de bouw van stadhuizen in het huidige Noord-Frankrijk, België en Nederland.</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SourceLink",
                value: "https://rkd.nl/en/explore/artists/63328");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "<p><strong>11th century</strong><br>'Love' building, the residence of the counts of Flanders</p><p><strong>15th century</strong><br>the government of the Franc of Bruges (the area of countryside surrounding Bruges) moved from Steen Castle (which was on the opposite side) to this location.</p><p><strong>1520-1525</strong><br>construction of an alderman’s room with monumental fireplace</p><p><strong>1528-1532</strong><br>construction of an arched gallery</p><p><strong>17th century</strong><br>further extensions including a chapel and orphanage</p><p><strong>1722-1727</strong><br>renovations in the classical style</p><p><strong>1794</strong><br>the manor became a court of justice</p><p><strong>1984</strong><br>came into use by the city administration</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Description",
                value: "<p><strong>1280</strong> <br>Tras un incendio en el campanario de Belfort de la plaza de <em>Markt</em>, los escabinos se instalan en el <em>ghyselhuus</em>, la antigua cárcel condal &nbsp;</p> <p><strong>1376</strong> <br>El conde Luis II manda derribar el «<em>ghyselhuus</em>» para reemplazarlo por una verdadera <em>scepenhuus</em> (casa escabinal), diseñada por Jan Roegiers</p> <p><strong>1887</strong> <br>Un incendio devasta el interior </p> <p><strong>1895-1905</strong> <br>Louis Delacenserie y Jean-Baptiste de Béthune renuevan el interior en estilo neogótico </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Description",
                value: "<p><strong>1088</strong> <br>Le bâtiment est mentionné pour la première fois comme résidence des comtes de Flandre. </p> <p><strong>12<sup>e</sup> siècle</strong> <br>Les comtes quittent le bâtiment et s’installent dans le « Love » situé de l’autre côté de la place du Bourg (l’actuelle Maison du Franc de Bruges). Le « Het Steen » devient alors une prison. </p> <p><strong>1689</strong> <br>Le bâtiment brûle en grande partie. </p> <p><strong>1751</strong> <br>La ville de Bruges devient propriétaire du bâtiment « Het Steen » et le fait démolir en 1784. </p> <p><strong>1851</strong> <br>Une ferronnerie s’installe à cet endroit. </p> <p><strong>1931</strong> <br>Construction d’un bâtiment avec trois pignons à gradins dans un style néogothique (aujourd’hui Brasserie Tompouce). </p> <p><strong>1977</strong> <br>Construction de la galerie commerciale Ter Steeghere. </p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Description",
                value: "<p><strong>Romaans</strong></p> <p>De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt op Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.</p> <p><strong>Gotisch</strong></p> <p>Gotische architectuur ontstond in het 12<sup>de</sup>-eeuwse Frankrijk. Aanvankelijk werd de bouwstijl vooral toegepast voor kerkgebouwen. Vanaf de late 15de eeuw inspireerden de gotische kathedralen ook de bouw van stadhuizen in het huidige Noord-Frankrijk, België en Nederland.</p>");
        }
    }
}
