using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class SpaanseAanpassingenBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Hendrik Pickery (1828–1894) fue un escultor brujense. Fue alumno del escultor liejense Eugène Simonis (1810–1882). Las estatuas sobre las escaleras y en la fachada de la Corte Provincial (en la plaza de <em>Markt</em>), y la estatua de Hans Memling (plaza de Woensdagmarkt) son obra de Pickery.", "https://rkd.nl/en/explore/artists/63327" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 96L,
                column: "Text",
                value: "El Burg como fortaleza (Siglo XII).");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Description",
                value: "<p><strong>Siglo XI</strong><br>Construcción del <em>Love</em>, residencia de los condes de Flandes</p><p><strong>Siglo XV</strong><br>La administración del <em>Brugse Vrije</em> (el campo que rodeaba Brujas) se traslada a esta ubicación desde el <em>Steen</em>, situado al otro lado</p><p><strong>1520-1525</strong><br>Construcción de una sala para el escabinado, con una monumental chimenea</p><p><strong>1528-1532</strong><br>Construcción de una galería con arcos de medio punto</p><p><strong>Siglo XVII</strong><br>Ampliación con una capilla y un juzgado de huérfanos</p><p><strong>1722-1727</strong><br>Reforma en estilo clasicista</p><p><strong>1794</strong><br>El mansión se convierte en tribunal&nbsp;</p><p><strong>1984</strong><br>Se pone al servicio de la administración municipal</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Description",
                value: "<p><strong>1280</strong> <br>Tras un incendio en el campanario de Belfort de la plaza de <em>Markt</em>, los escabinos se instalan en el <em>ghyselhuus</em>, la antigua cárcel condal &nbsp;</p> <p><strong>1376</strong> <br>El conde Luis II manda derribar el «<em>ghyselhuus</em>» para reemplazarlo por una verdadera <em>scepenhuus</em> (casa escabinal), diseñada por Jan Roegiers</p> <p><strong>1887</strong> <br>Un incendio devasta el interior </p> <p><strong>1895-1905</strong> <br>Louis Delacenserie y Jean-Baptiste de Béthune renuevan el interior en estilo neogótico </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Description",
                value: "<p><strong>1088</strong> <br>Nombrado por primera vez como residencia de los condes de Flandes </p> <p><strong>Siglo XII</strong> <br>Los condes abandonan el edificio y se instalan en el «<em>Love</em>» al otro lado del Burg (la actual <em>Landhuis</em> del <em>Brugse Vrije</em>), el <em>Steen</em> pasa a ser una cárcel&nbsp;</p> <p><strong>1689</strong> <br>El edificio se incendia casi en su totalidad </p> <p><strong>1751</strong> <br>La ciudad de Brujas pasa a ser propietaria del <em>Steen</em> y lo manda demoler en 1784 &nbsp;&nbsp;</p> <p><strong>1851</strong> <br>Se instala una herrería en este sitio </p> <p><strong>1931</strong> <br>Construcción de un edificio con tres fachadas escalonadas de estilo neogótico (en la actualidad <em>Brasserie Tompouce</em>)</p> <p><strong>1977</strong> <br>Construcción del pasaje comercial de <em>Ter Steeghere</em></p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Description",
                value: "<p>El prebostazgo (1666) es la antigua sede principal del dominio eclesiástico de San Donaciano.&nbsp;</p> <p>El edificio, de estilo barroco triunfalista, fue diseñado por el arquitecto Cornelis Verhouve y por el canónigo Frederic Hillewerve, ambos procedentes de Amberes. Las influencias de Amberes pueden verse claramente en el edificio.&nbsp;</p> <p>El prebostazgo es en la actualidad la vivienda oficial del gobernador de la provincia de Flandes Occidental.&nbsp;</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Hendrik Pickery (1828–1894) fue un escultor brujense. Fue alumno del escultor liejense Eugène Simonis (1810–1882). Las estatuas sobre las escaleras y en la fachada de la Corte Provincial (en la plaza del Markt), y la estatua de Hans Memling (plaza de Woensdagmarkt) son obra de Pickery.", "https://rkd.nl/en/explore/artists/63328" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 96L,
                column: "Text",
                value: "El Burg compo fortaleza (Siglo XII).");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Description",
                value: "<p><strong>Siglo XI</strong><br>Construcción del «<em>Love</em>», residencia de los condes de Flandes</p><p><strong>Siglo XV</strong><br>La administración del <em>Brugse Vrije</em> (el campo que rodeaba Brujas) se traslada a esta ubicación desde el <em>Steen</em>, situado al otro lado</p><p><strong>1520-1525</strong><br>Construcción de una sala para el escabinado, con una monumental chimenea</p><p><strong>1528-1532</strong><br>Construcción de una galería con arcos de medio punto</p><p><strong>Siglo XVII</strong><br>Ampliación con una capilla y un juzgado de huérfanos</p><p><strong>1722-1727</strong><br>Reforma en estilo clasicista</p><p><strong>1794</strong><br>El <em>landhuis</em> se convierte en tribunal&nbsp;</p><p><strong>1984</strong><br>Se pone al servicio de la administración municipal</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Description",
                value: "<p><strong>1280</strong> <br>Tras un incendio en el campanario de Belfort de la plaza de <em>Markt</em>, los escabinos se instalan en el «<em>ghyselhuus</em>», la antigua cárcel condal &nbsp;</p> <p><strong>1376</strong> <br>El conde Lodewijk van Male manda derribar el «<em>ghyselhuus</em>» para reemplazarlo por una verdadera «<em>scepenhuus</em>» (casa escabinal), diseñada por Jan Roegiers</p> <p><strong>1887</strong> <br>Un incendio devasta el interior </p> <p><strong>1895-1905</strong> <br>Louis Delacenserie y Jean-Baptiste de Béthune renuevan el interior en estilo neogótico </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Description",
                value: "1088 Nombrado por primera vez como residencia de los condes de Flandes Siglo XII Los condes abandonan el edificio y se instalan en el «Love» al otro lado del Burg (la actual Landhuis del Brugse Vrije), el Steen pasa a ser una cárcel 1689 El edificio se incendia casi en su totalidad 1751 La ciudad de Brujas pasa a ser propietaria del Steen y lo manda demoler en 1784 1851 Se instala una herrería en este sitio 1931 Construcción de un edificio con tres fachadas escalonadas de estilo neogótico (en la actualidad Brasserie Tompouce) 1977 Construcción del pasaje comercial de Ter Steeghere");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Description",
                value: "<p>El prebostazgo es la antigua sede principal del dominio eclesiástico de San Donaciano.&nbsp;</p> <p>El edificio, de estilo barroco triunfalista, fue diseñado por el arquitecto Cornelis Verhouve y por el canónigo Frederic Hillewerve, ambos procedentes de Amberes. Las influencias de Amberes pueden verse claramente en el edificio.&nbsp;</p> <p>El prebostazgo es en la actualidad la vivienda oficial del gobernador de la provincia de Flandes Occidental.&nbsp;</p>");
        }
    }
}
