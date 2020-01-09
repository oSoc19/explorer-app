using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Burg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "AA");

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "MuseumCode", "Year" },
                values: new object[] { "AB", 1400 });

            migrationBuilder.InsertData(
                table: "Building",
                columns: new[] { "Id", "MovementId", "MuseumCode", "UseId", "Year" },
                values: new object[,]
                {
                    { 3L, 2L, "AC", 1L, 1699 },
                    { 4L, 2L, "AD", 1L, 1699 },
                    { 5L, 2L, "AE", 1L, 1699 },
                    { 6L, 2L, "AF", 1L, 1699 },
                    { 7L, 2L, "AG", 1L, 1699 },
                    { 8L, 2L, "AH", 1L, 1699 }
                });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>La place du Bourg est l’un des centres urbains les plus anciens de la ville de Bruges. Il s’agit d’une ancienne forteresse. Au départ, elle était fortifiée et dotée de portes d’accès.</p><p>La forteresse se situait à la jonction de la route Oudenburg-Aardenburg et du Reie, un cours d’eau.</p><p>Le comte Arnulf Ier de Flandre (889-965) a fait de la forteresse un centre de pouvoir avec une fonction administrative et religieuse. La résidence du comte, le conseil municipal, l’église de Saint-Donatien et, plus tard, la Basilique du Saint-Sang ont trouvé leur place dans la forteresse.</p><p>La cathédrale Saint-Donatien a été démolie en 1799. L’église n’a pas été reconstruite. Par conséquent, la place a doublé de taille.</p>", "Place du Bourg" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>De Burg is een van de oudste kernen van de stad. Het is een voormalige vesting. Aanvankelijk was ze omwald en voorzien van toegangspoorten.</p><p>De versterkte vesting bevond zich op het knooppunt van de weg Oudenburg-Aardenburg en de waterloop de Reie.</p><p>Graaf Arnulf I van Vlaanderen (889-965) bouwde de burcht uit tot een machtscentrum met een bestuurlijke en religieuze functie. De grafelijke residentie, het stadsbestuur, de Sint-Donaaskerk en de latere Heilig-Bloedbasiliek vonden een plaats binnen de vesting.</p><p>In 1799 werd de Sint-Donaaskathedraal gesloopt. De kerk werd niet heropgebouwd. Daardoor verdubbelde het plein in omvang.</p>", "Burg" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>Burg Square is one of the oldest parts of the city centre. It is a former fortress and was originally walled in and had entrance gates.</p><p>The fortress was located at the meeting-point of the Oudenburg-Aardenburg road and the Reie canal.</p><p>Count Arnulf I van Vlaanderen (889-965) extended the fortress, transforming it into a powerful religious and administrative centre. The Count’s Residence, the City Council, Saint Donatian’s Church and later the Basilica of the Holy Blood were also located within the fortress walls.</p><p>Saint Donatian’s Cathedral was demolished in 1799. It was never re-built, meaning that the square doubled to twice its previous size.</p>", "Burg Square" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>Der Burgplatz, eine ehemalige Festung, ist einer der ältesten Kernbereiche der Stadt. Anfänglich war der Platz mit Wällen und Zugangstoren versehen.</p><p>Die Festung befand sich am Knotenpunkt der Straße von Oudenburg nach Aardenburg und dem Fluss Reie.</p><p>Graf Arnulf I. von Flandern (889–965) verwandelte die Festung in ein Machtzentrum, das religiöse und verwaltungstechnische Funktionen erfüllte. In dieser Festung wurden die gräfliche Residenz, die Stadtverwaltung, die Kathedrale Sankt Donatian und die spätere Heilig-Blut-Basilika untergebracht.</p><p>1799 wurde die Kathedrale Sankt Donatian abgerissen und nicht wieder aufgebaut, wodurch der Platz zweimal so groß wurde.</p>", "Burg" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>El edificio de Burg constituye uno de los núcleos más antiguos de la ciudad. Se trata de una antigua fortaleza. Originariamente estaba amurallado y contaba con puertas de acceso.&nbsp;</p><p>La fortaleza estaba situada en la intersección de la carretera de <em>Oudenburg-Aardenburg</em> y el canal de <em>Reie</em>.</p><p>El conde Arnulfo I de Flandes (889-965) amplió el castillo a un centro de poder con una función administrativa y religiosa. La residencia condal, las autoridades municipales, la Iglesia de San Donaciano y la posterior Basílica de la Santa Sangre se encontraban en el interior de la fortaleza. &nbsp; &nbsp;</p><p>En 1799 se destruyó la Catedral de San Donaciano. La iglesia no volvió a construirse, algo que permitió que la plaza doblara su extensión.</p>", "Burg" });

            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[] { 6L, 1L, "<strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.<br><br><strong>1376</strong><br> Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.<br><br><strong>1887</strong><br> Un incendie ravage l’intérieur.<br><br><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.", 1L, "Hôtel de Ville de Bruges", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "MuseumCode", "Year" },
                values: new object[] { "AC", 1699 });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.<br><br><strong>1376</strong><br> Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.<br><br><strong>1887</strong><br> Un incendie ravage l’intérieur.<br><br><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.", "Hôtel de Ville de Bruges" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "NL Description <br> test test", "Stadhuis van Brugge" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "EN Description <br> test test", "Town Hall of Bruges" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "DE Description <br> test test", "Rathaus von Brügge" });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "ES Description <br> test test", "Ayuntamiento de Brujas" });
        }
    }
}
