using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Griffie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 11L, 3L, "<p><strong>1537</strong><br>Construit comme le bureau du greffier civil, l’un des plus importants fonctionnaires de la ville.</p><p><strong>1877-1881</strong><br>Restauration sous la direction de l’architecte de la ville Louis Delacenserie.</p><p><strong>1883</strong><br>Ajout de statues en bronze réalisées par le sculpteur brugeois Hendrik Pickery.</p><p><strong>2000</strong><br>Une nouvelle restauration redonne au bâtiment sa splendeur d’origine.</p>", 1L, "Greffe", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 12L, 3L, "<p><strong>1537</strong><br>opgetrokken als kantoor van de griffier-civiel, een van de belangrijkste stadsambtenaren</p><p><strong>1877-1881</strong><br>restauratie onder leiding van stadsarchitect Louis Delacenserie</p><p><strong>1883</strong><br>toevoeging bronzen beelden door de Brugse beeldhouwer Hendrik Pickery</p><p><strong>2000</strong><br>een nieuwe restauratie geeft het gebouw zijn oorspronkelijke kleurenpracht terug</p>", 2L, "Griffie", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 13L, 3L, "<p><strong>1537</strong><br>came into use as the office of the Civil Registrar, one of the most important city officials</p><p><strong>1877-1881</strong><br>renovations led by city architect Louis Delacenserie</p><p><strong>1883</strong><br>addition of bronze sculptures by Bruges sculptor Hendrik Pickery</p><p><strong>2000</strong><br>another renovation restores the original beautiful colours to the building</p>", 3L, "Registry", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 14L, 3L, "<p><strong>1537</strong><br>Errichtung als Büro des Kanzleileiters des Zivilgerichts, der zu den wichtigsten Stadtbeamten gehört.</p><p><strong>1877–1881</strong><br>Restaurierung unter der Leitung des Stadtarchitekten Louis Delacenserie.</p><p><strong>1883</strong><br>Hinzufügung von Bronzeskulpturen des Brügger Bildhauers Hendrik Pickery.</p><p><strong>2000</strong><br>Im Zuge einer neuen Restaurierung erhält das Gebäude seine ursprüngliche Farbenpracht wieder.</p>", 4L, "Alte Zivilkanzlei", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 15L, 3L, "<p><strong>1537</strong><br>Se construye como oficina del secretario judicial civil, uno de los funcionarios municipales más importantes</p><p><strong>1877-1881</strong><br>Restauración dirigida por el arquitecto municipal Louis Delacenserie</p><p><strong>1883</strong><br>Adición de esculturas de bronce del escultor brujense Hendrik Pickery</p><p><strong>2000</strong><br>Una nueva restauración le devuelve al edificio su colorido original</p>", 5L, "Escribanía civil", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 15L);
        }
    }
}
